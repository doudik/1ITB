let dnyVtydnu = ["pondělí", "úterý", "středa", "čtvrtek", "pátek", "sobota", "neděle"];

// push 
dnyVtydnu.push("neznám");
// pop
dnyVtydnu.pop("neznám");
// shift
dnyVtydnu.shift("neznám");
// unshift
dnyVtydnu.unshift("neznám");

//dnyvtydnu velke pismena

function velkePismeno(){
    dnyVtydnu.forEach(element => {
        console.log(element.toUpperCase());
    });
}

//najdi všechny 'a' v arrayi
function najdiPismenko(pismenko){
    let counter = 0;
    dnyVtydnu.forEach(element => {
            if(element.indexOf(pismenko) !== -1){
                counter++;
            }
        });
    console.log("Počet: " + counter)
}
function forCyklus(cislo){
    for (let index = 0; index <= cislo; index++) {
        console.log(index);
    }
}


//a-h-o-j
function rozdelText(text){
    let vysledek = "";
    for (let index = 0; index < text.length; index++) {
        vysledek = vysledek + text.charAt(index) + " - ";
        
    };
    console.log(vysledek);
}