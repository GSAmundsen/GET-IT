// Oppgave 161A

function fixText(txt){
    //Assign it to a new variable, and remove leading/trailing blank spaces.
    let result = txt.trim();
    // If the first character is a letter, always capitalize it.
    result = result[0].toUpperCase()+result.slice(1)    

    return result;

}

function checkIfEmail(txt){
    return txt.includes("@");
}