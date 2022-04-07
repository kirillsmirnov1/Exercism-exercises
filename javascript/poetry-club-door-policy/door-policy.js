// @ts-check

export function frontDoorResponse(line) {
  return line[0];
}

export function frontDoorPassword(word) {
  return word[0].toUpperCase() + word.substring(1, word.length).toLowerCase();
}

export function backDoorResponse(line) {
  var line = line.trim();
  return line[line.length-1];
}

export function backDoorPassword(word) {
  return frontDoorPassword(word) + ', please';
}
