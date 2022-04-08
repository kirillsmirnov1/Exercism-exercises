export const countWords = (phrase) => {
  var words = phrase
    .toLowerCase()
    .match(/\w+('\w+)?/g);

  var result = {};

  for (var i = 0; i < words.length; i++) {
    if(!result.hasOwnProperty(words[i])){
      result[words[i]] = 0;
    }
    result[words[i]]++;
  }
  return result;
};
