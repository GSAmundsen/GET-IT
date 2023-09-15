function buyCoke() {
    let coinsValue = valueFromCoinCounts(coinsInserted); // Her henter vi kroneverdien fra myntene som er lagt på
    let coins = [...coinsInserted]
    
    //Om vi har råd til coke..
    if(coinsValue >= priceOfCoke){
        cokesInStore--; //trekk fra antall coke i maskinen
        isCokeInDelivery = true; // coke er i utkastet
        coinsValue -= priceOfCoke; // Vi trekker fra prisen på coke fra kroneverdien vi la på maskinen
        coinsInserted = fromValueToCoins(coinsValue); //Vi konverterer kroneverdien til en liste med riktige mynter.
        
        //Vi legger myntene til myntene i maskinen
        for(let i = 0; i < coins.length;i++){
            coinsInMachine[i] += coins[i];
        }   
        returnCoins();  //Vi returnerer veksel.
    }
    updateView();
}

function canBuyCoke(){
    //Om det ikke er flere cola igjen, eller kroneverdien i innkastet er lavere enn prisen, eller det allerede er en cola i utkastet
    if(cokesInStore == 0 || valueFromCoinCounts(coinsInserted) < 25 || isCokeInDelivery){
        return false;
    }else{
        return true;
    }
}

function takeCoke(){
    if(!isCokeInDelivery) return;
    isCokeInDelivery = false; // Fjern cola fra utkast
    numberOfCokesPurchased++; // Telling på hvor mange cola man har tatt fra maskinen
    emptyCokeCans(); //Denne funksjonen sjekker om vi er tom for cola, og trigger en alert.
    updateView();
}

function takeCoins(){
    pocketChange += valueFromCoinCounts(coinsReturned); // Holder styr på hvor mye vi har fått tilbake fra maskinen
    coinsReturned = [0,0,0,0] // Nullstiller listen av mynter i utkastet
    updateView();
}


function insertCoin(value){ 
    if(valueFromCoinCounts(coinsInserted) >= 50){ // Hindrer bruker feil. Kan ikke legge paa en sum høyere en 50kr
        alert('Hey there stop! I\'d advice you to pick your next coin of choice carefully!');
        return;
    }else{
    const index = 
        value == 1 ? 0 : 
        value == 5 ? 1 : 
        value == 10 ? 2 :  
        value == 20 ? 3 : 
        null;
    coinsInserted[index]++;
    updateView();}
}


function cancelPurchase(){
    for(let i = 0; i < coinsInserted.length; i++){
        coinsReturned[i] += coinsInserted[i];
    }
    coinsInserted = [0,0,0,0];
    updateView();
}

// Vi har muligheten for at coinsInserted kan legges til paa maskin og angres
function returnCoins(){
    //
    for(let i = 0; i < coinsInserted.length; i++){
        coinsReturned[i] += coinsInserted[i]; // Returner veksel
        coinsInMachine[i] -= coinsInserted[i]; // Legg myntene til maskinen
    }
    
    coinsInserted = [0,0,0,0]; // Nullstiller innkastede mynter
    updateView();
}
// 
function canRefillCoke(){
    // Har du mindre enn 6 cola i skapet, og har råd til å betale innkjøpsPrisen kan du refille.
    if(cokesInStore < 6 && pocketChange >= cokePurchasePrice){ 
       return true;
    }else{
        return false;
    }
    
}
 
function fillCoke(){
        pocketChange -= cokePurchasePrice; // Tar småpæng i fra lommeboka
        cokesInStore++; // Brus legges til i skapet
        
        updateView();
    }

function emptyCokeCans(){
    if(cokesInStore == 0){ //Er vi tom for cola i maskinen?
        alert('Please put more coke in me. 5kr a piece! Pretty please.')
    }
}

    
