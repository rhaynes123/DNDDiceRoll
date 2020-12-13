// Please add typescript only to functions.ts and not to functions.js. functions.js will be auto generated
function displayRoll(input: number) {
    alert("You rolled a " + input); console.log(typeof input); console.log(input);
}
function getRandomFromDiceTypes(typeofDice: number) {
    let bound: number = 1;
    let result = Math.floor(Math.random() * typeofDice + bound) + bound;
    console.log("random result: "+result);
    return result;
}
function makeRoll(numSides: number, qty: number, bonus: number): number {
    let sum: number = 0;
    for (let r = 0; r < qty; r++) {
        sum += getRandomFromDiceTypes(numSides + bonus);
        console.log("sum: "+sum);
    }
    console.log(sum);
    return sum;
}