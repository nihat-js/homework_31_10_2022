let num = 101;
let start = 2;
let output = 'Sade ededdir';


if (num != 1) {
   while (start < num) {
      if (num % start == 0) {
         output = "Murekkeb ededdir";
         break;
      }
      start++;
   }

} else {
   output = "Ne murekkeb ne sade ededdir";
}

console.log(output);
