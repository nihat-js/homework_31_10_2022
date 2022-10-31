let num = 21;
let sum = 0;
while (num >= 1) {
   sum += num % 10;
   num = (num - num % 10) / 10;
}

console.log(sum);