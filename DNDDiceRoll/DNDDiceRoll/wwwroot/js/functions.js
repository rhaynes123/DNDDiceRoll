// Please add typescript only to functions.ts and not to functions.js. functions.js will be auto generated
function displayRoll(input) {
    alert("You rolled a " + input);
    console.log(typeof input);
    console.log(input);
}
function getRandomFromDiceTypes(typeofDice) {
    var bound = 1;
    var result = Math.floor(Math.random() * typeofDice + bound) + bound;
    console.log("random result: " + result);
    return result;
}
function makeRoll(numSides, qty, bonus) {
    var sum = 0;
    for (var r = 0; r < qty; r++) {
        sum += getRandomFromDiceTypes(numSides + bonus);
        console.log("sum: " + sum);
    }
    console.log(sum);
    return sum;
}
