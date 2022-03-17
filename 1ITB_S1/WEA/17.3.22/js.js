function pridej(x){
    document.getElementById(x).innerHTML++;
}
function odecti(x){
    document.getElementById(x).innerHTML--;
}
function pridejXP(){
    let xp = document.getElementById("xp").innerHTML;
    let xpTo = document.getElementById("xpTo").innerHTML;
    let lvl = document.getElementById("lvl").innerHTML;
    
    if(xp >= xpTo){
        document.getElementById('xp').innerHTML = 0;
        xpTo = xpTo*1 + xpTo/2;
        document.getElementById('xpTo').innerHTML = xpTo;
        document.getElementById('lvl').innerHTML = parseInt(lvl)+1;
        
    }else{
        document.getElementById("xp").innerHTML++;
    }
    
}