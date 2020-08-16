// This file was auto-generated based on version 1.2.0 of the canonical data.

using Xunit;

public class RotationalCipherTests
{
    [Fact]
    public void Rotate_a_by_0_same_output_as_input()
    {
        Assert.Equal("a", RotationalCipher.Rotate("a", 0));
    }

    [Fact]
    public void Rotate_a_by_1()
    {
        Assert.Equal("b", RotationalCipher.Rotate("a", 1));
    }

    [Fact]
    public void Rotate_a_by_26_same_output_as_input()
    {
        Assert.Equal("a", RotationalCipher.Rotate("a", 26));
    }

    [Fact]
    public void Rotate_m_by_13()
    {
        Assert.Equal("z", RotationalCipher.Rotate("m", 13));
    }

    [Fact]
    public void Rotate_n_by_13_with_wrap_around_alphabet()
    {
        Assert.Equal("a", RotationalCipher.Rotate("n", 13));
    }

    [Fact]
    public void Rotate_capital_letters()
    {
        Assert.Equal("TRL", RotationalCipher.Rotate("OMG", 5));
    }

    [Fact]
    public void Rotate_spaces()
    {
        Assert.Equal("T R L", RotationalCipher.Rotate("O M G", 5));
    }

    [Fact]
    public void Rotate_numbers()
    {
        Assert.Equal("Xiwxmrk 1 2 3 xiwxmrk", RotationalCipher.Rotate("Testing 1 2 3 testing", 4));
    }

    [Fact]
    public void Rotate_punctuation()
    {
        Assert.Equal("Gzo'n zvo, Bmviyhv!", RotationalCipher.Rotate("Let's eat, Grandma!", 21));
    }

    [Fact]
    public void Rotate_all_letters()
    {
        Assert.Equal("Gur dhvpx oebja sbk whzcf bire gur ynml qbt.", RotationalCipher.Rotate("The quick brown fox jumps over the lazy dog.", 13));
    }

    [Fact]
    public void Rotate_lorem_ipsum()
    {
        string loremIpsum =
            @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam pharetra et dui in pharetra. Curabitur venenatis convallis ullamcorper. Vivamus sapien augue, egestas in ante molestie, vestibulum ornare sem. Nulla posuere fermentum libero, tincidunt malesuada lectus volutpat ac. Curabitur rutrum laoreet nunc. Aenean et tellus felis. Phasellus ac ex felis. Nam in viverra lorem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nam convallis tempus massa at volutpat. Proin sagittis vel nulla in euismod.

Nullam dapibus diam justo, vitae pulvinar tortor ultrices ac. Duis sed vehicula nibh. Nullam libero libero, viverra in risus eget, sodales bibendum quam. Nullam sodales ligula in pretium tincidunt. Duis ut nibh quis lorem consequat ultrices feugiat quis neque. Suspendisse pulvinar diam ac felis blandit, quis ullamcorper velit egestas. Suspendisse lobortis augue magna, ut dictum sem ornare ac. Ut ante lacus, euismod sit amet ipsum a, convallis fringilla libero. Integer suscipit sapien id dictum vehicula. Maecenas egestas diam et arcu vehicula, ac viverra mi blandit.

Donec eget libero interdum, condimentum nisl pellentesque, eleifend risus. Aliquam aliquam dolor at arcu gravida, sed egestas est mattis. Cras ultricies ornare odio vel consequat. Morbi pellentesque, tortor vel tincidunt sagittis, ipsum dolor vulputate ligula, id scelerisque diam mauris vitae lorem. Pellentesque pharetra felis euismod sem congue, sed ultricies erat euismod. Aliquam iaculis vitae lectus pharetra interdum. Sed eu risus eu turpis semper suscipit. Ut convallis lectus eu sapien mattis volutpat. Sed a porttitor enim.

Donec cursus posuere arcu, sit amet dapibus nisi fringilla eget. Quisque laoreet fringilla turpis at tempor. Proin vel vehicula orci, eget aliquet massa. Sed viverra ipsum eu dolor varius tincidunt. Duis egestas arcu sapien, id vestibulum ante mollis eget. Praesent orci ligula, ullamcorper eget dignissim ut, rhoncus ut augue. Donec id placerat nunc.

Proin non diam eget ex rutrum pharetra. Duis eget neque in enim bibendum sagittis. Pellentesque vel nisi at nisl eleifend condimentum id eget ante. Praesent sit amet luctus dui, ut efficitur nulla. Nulla lacinia magna sit amet arcu aliquet gravida. Proin hendrerit dignissim eros. Etiam cursus arcu nec orci dapibus ullamcorper. Curabitur malesuada nisl non nulla ullamcorper iaculis. Quisque vehicula dignissim nisl.

Duis placerat bibendum ligula nec mollis. Quisque finibus, est eget condimentum varius, nunc tellus rhoncus arcu, non consequat odio nunc sit amet ligula. Mauris eu libero sed est rutrum faucibus vel ut ex. In et dui ut risus faucibus ullamcorper. Nulla facilisi. Morbi iaculis diam odio, in placerat elit aliquam id. Curabitur pellentesque nisl sed libero elementum vulputate. Phasellus quis nunc sem. Donec et ex dignissim, fermentum eros sit amet, pulvinar lorem.

Nunc semper facilisis nisi. Morbi eleifend orci orci, sit amet cursus nulla ultricies sit amet. Sed vulputate nulla tellus. Aenean quis pellentesque justo. Duis a lorem eget libero sagittis pharetra aliquam convallis metus. Suspendisse velit quam, tincidunt nec vulputate ac, pretium a nulla. Nunc leo elit, dignissim vitae dignissim eget, placerat eu turpis. Maecenas vel sem orci.

Vestibulum aliquam fermentum massa at blandit. Ut in lectus vulputate, feugiat lectus id, viverra nunc. Integer vel faucibus libero. Phasellus in neque id lorem tincidunt imperdiet ac ac libero. Quisque ut semper tellus. Nulla vestibulum ex tincidunt malesuada iaculis. Maecenas molestie nulla in vestibulum sodales. Sed vel diam at massa posuere lobortis eget quis lectus. Sed sagittis lacus nec metus porta sollicitudin in sit amet elit. Interdum et malesuada fames ac ante ipsum primis in faucibus.

Phasellus eu tempor mauris. Cras dapibus dapibus leo, at malesuada tellus sagittis et. Curabitur scelerisque mi orci, sed dictum neque scelerisque in. Sed interdum, dolor id fermentum accumsan, turpis lorem accumsan sem, in fermentum leo urna sit amet turpis. Etiam ultricies risus vitae lectus egestas feugiat sit amet non ex. Donec scelerisque imperdiet eleifend. Vivamus massa nulla, vulputate et mauris ac, semper gravida metus. Curabitur semper mauris nec mi sodales tincidunt. Donec ornare euismod nisl, sit amet convallis felis pharetra sit amet. In hac habitasse platea dictumst. Aenean egestas odio non elit euismod lobortis. Quisque placerat, ex ut feugiat tincidunt, felis dui vulputate justo, vitae sollicitudin metus tortor a tellus. Maecenas ac ultrices elit, eu faucibus nisi. Vestibulum malesuada leo nibh, ut lacinia felis elementum nec. Sed hendrerit ex eros, vel porta ipsum commodo rhoncus. Fusce vel libero eget magna condimentum efficitur.

Mauris scelerisque congue nunc, ac rhoncus neque malesuada sit amet. Donec faucibus vitae magna suscipit finibus. Nulla bibendum urna eget nibh tincidunt porta. Etiam ut nunc eu dui fringilla aliquet. Proin hendrerit quam et nibh aliquam lobortis. Quisque et molestie orci. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce porttitor diam augue, at mattis felis tempus et. Duis enim risus, dictum ut erat vitae, rutrum molestie felis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Proin eget elit id nisl gravida consequat nec quis lacus. Quisque efficitur dignissim nibh sed porttitor.

Maecenas et libero purus. Mauris blandit venenatis auctor. Praesent purus lacus, sagittis ac vehicula et, fermentum sit amet est. Nam at velit ante. Morbi porttitor pellentesque scelerisque. In eget ultrices lectus. Cras finibus sapien nec neque ultricies, vitae consectetur quam volutpat. In ultrices lobortis dolor, vel malesuada arcu semper quis. Curabitur malesuada purus non lectus dictum, ac tincidunt nulla dignissim. Duis pellentesque fermentum urna eu blandit. Nunc nisi ligula, ultricies eget odio at, faucibus varius dui. Phasellus condimentum iaculis sapien ornare consectetur. Ut et mauris ultrices, dapibus diam a, porttitor tortor. Nam ultricies scelerisque ligula eget porta. Sed et neque vel tortor scelerisque convallis quis at mauris.

Maecenas eget sapien in lacus condimentum efficitur. Maecenas euismod porttitor ornare. Donec elementum sollicitudin ex, ornare dictum magna suscipit eget. Nam bibendum viverra erat ac blandit. Etiam commodo mollis felis, gravida euismod quam facilisis ut. Maecenas lacus lorem, finibus et efficitur eu, tempor at sem. Donec quis mauris sit amet lorem vestibulum lobortis a ultricies quam.

Vivamus malesuada dolor et orci commodo facilisis. Sed gravida, augue id auctor cursus, libero est pulvinar tortor, sit amet fermentum odio orci ac ipsum. Suspendisse a nibh ac diam tempor ultricies. Donec vitae erat tellus.";

        for (int i = 0; i < 1000; i++)
        {
            Assert.Equal(loremIpsum, RotationalCipher.Rotate(loremIpsum, 0));
        }
    }
}