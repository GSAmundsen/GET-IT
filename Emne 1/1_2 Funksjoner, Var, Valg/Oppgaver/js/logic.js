generateBoard()

//Generates the chessboard and pieces
function generateBoard() {
    let HTMLCode = "";

    //For loop that adds the HTML for "drawing" the first/last lines of pieces and squares
    for (let c = 0; c < 8; c++) {
        //If we are on the first line
        if (c == 0) {
            //Draws the black pieces, alternating white and black squares
            HTMLCode += drawRoyalty('black', 'white', 'black') + drawPawns('black', 'black', 'white');
            //Since we are drawing 2 lines instead of 1, we increment the column counter by 1 extra
            c++;
            //If we are on the 2nd to last line
        } else if (c == 6) {
            //Draws the white pieces, alternating black and white squares
            HTMLCode += drawPawns('white', 'white', 'black') + drawRoyalty('white', 'black', 'white')
            c++;
            //If we are not on the first line, or on the 2nd to last line, draw empty squares 
        } else {

            for (let r = 0; r < 8; r++) {
                //Using modulo to alternate the squares. 
                //As the column counter c and row counter r increases, this alternates colors as the rows change. column 1 row 2 = (1+2 %)
                if (((c + r) % 2) == 0) { HTMLCode += `<div class="whiteSquare"></div>` }
                if (((c + r) % 2) == 1) { HTMLCode += `<div class="blackSquare"></div>` }
            }
        }
    }

    document.getElementById("board").innerHTML = `${HTMLCode}`
}


//returns the "non-Pawns" and squares
function drawRoyalty(color, firstColor, secondColor) {
    return `
                <div class="${firstColor}Square ${color}Piece">♜</div>
                <div class="${secondColor}Square ${color}Piece">♞</div>
                <div class="${firstColor}Square ${color}Piece">♝</div>
                <div class="${secondColor}Square ${color}Piece">♛</div>
                <div class="${firstColor}Square ${color}Piece">♚</div>
                <div class="${secondColor}Square ${color}Piece">♝</div>
                <div class="${firstColor}Square ${color}Piece">♞</div>
                <div class="${secondColor}Square ${color}Piece">♜</div>
            `
}

//returns the pawns
function drawPawns(color, firstColor, secondColor) {
    return `
                <div class="${firstColor}Square ${color}Piece">♟</div>
                <div class="${secondColor}Square ${color}Piece">♟</div>
                <div class="${firstColor}Square ${color}Piece">♟</div>
                <div class="${secondColor}Square ${color}Piece">♟</div>
                <div class="${firstColor}Square ${color}Piece">♟</div>
                <div class="${secondColor}Square ${color}Piece">♟</div>
                <div class="${firstColor}Square ${color}Piece">♟</div>
                <div class="${secondColor}Square ${color}Piece">♟</div>
            `
}
