// Please add typescript only to functions.ts and not to functions.js. functions.js will be auto generated
var displayRoll = function (input) { return alert("You rolled a " + input); };
function makeRoll(numSides, qty, bonus) {
    if (bonus === void 0) { bonus = 0; }
    var sum = 0;
    var bound = 1;
    for (var r = 0; r < qty; r++) {
        sum += Math.floor(Math.random() * numSides + bound) + bound;
    }
    return sum + bonus;
}
