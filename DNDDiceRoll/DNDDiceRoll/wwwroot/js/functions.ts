// Please add typescript only to functions.ts and not to functions.js. functions.js will be auto generated
let displayRoll = (input: number) => alert("You rolled a " + input);

function makeRoll(numSides: number, qty: number, bonus = 0): number {
    let sum: number = 0;
    let bound: number = 1;
    for (let r = 0; r < qty; r++) {
        sum += Math.floor(Math.random() * numSides + bound) + bound;
    }
    return sum + bonus;
}