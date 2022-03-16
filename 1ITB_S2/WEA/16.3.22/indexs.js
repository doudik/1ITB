function praxe(arg) {
	if (arg == 'jablko') {
		console.log('zelena');
	}else if (arg == 'boruvka') {
		console.log('modra');
	}else if(arg == 'jahoda'){
		console.log('cervena');
	}
}

function heslo(){
    let x = document.getElementById('password').value;
    console.log(x);
    if(x.length  > 6){
        if(!(x.includes(' '))){
            //false
            console.log('v pořádku!');
        }else{
            console.log('obsahuje mezeru');
        }
    }else{
        console.log('moc krátké heslo');
    }
}

function nastav(){
    let y = 'parametr';
    document.getElementById('password').value = y;
    
}
let vit = 1;
let str = 1;
let dex = 1;

function pridej(arg){

document.getElementById(arg).innerHTML++;
    
}
function odecti(arg){
    document.getElementById(arg).innerHTML--;

}