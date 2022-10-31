let num = 6;
let quvvet = 0;

while (num >= 2) {
   num /= 2;
   quvvet++;

}
if (num > 1.5) {
   console.log(quvvet);
} else if (num == 1.5) {
   console.log("Her iki quvvete eyni uzaqlidadir ", quvvet, quvvet + 1);
} else {
   console.log(quvvet);
}

