using System;
using System.Collections.Generic;
using System.Linq;

public class TreeBuildingRecord
{
    public int ParentId { get; set; }
    public int RecordId { get; set; }

    public bool IsRoot => ParentId == RecordId && RecordId == 0;
}

public class Tree
{
    public int Id { get; set; }
    public int ParentId { get; set; }

    /// <summary>
    /// <para>Links trees to their id's</para>
    /// <para>Every sub-tree has the same index as root</para>
    /// </summary>
    private Dictionary<int, Tree> Index;

    public List<Tree> Children { get; set; }

    public bool IsLeaf => Children.Count == 0;

    internal Tree AddRecord(TreeBuildingRecord record)
    {
        if (record.IsRoot && Index == null)
        {
            Index = new Dictionary<int, Tree>();
        }

        ValidateRecord(record);

        var newTree = new Tree() { Id = record.RecordId, ParentId = record.ParentId, Children = new List<Tree>(), Index = Index };

        if(!record.IsRoot) 
            Index[record.ParentId].Children.Add(newTree);

        Index[newTree.Id] = newTree;

        return Index[0];
    }

    private void ValidateRecord(TreeBuildingRecord record)
    {
        // Hierarchy error
        if (record.ParentId > record.RecordId) throw new ArgumentException();
        // Self-reference allowed only for root
        if (record.ParentId == record.RecordId && !record.IsRoot) throw new ArgumentException();
        // No root node
        if (record.RecordId > 0 && Index == null) throw new ArgumentException();
        // Continuity error
        if (Index.Count != record.RecordId) throw new ArgumentException();
    }
}

public static class TreeBuilder
{
    public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
        => (!records.Any())
            ? throw new ArgumentException() 
            : records.OrderBy(x => x.RecordId).Aggregate(new Tree(), (tree, record) => tree.AddRecord(record));
    
}