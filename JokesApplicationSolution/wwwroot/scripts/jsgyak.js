window.onload = function () {

    console.log("betöltődött");

    drawPascal(10);
    

}

var drawPascal = function (sorszam) {

    var szuloelem = document.getElementById('pascal');

    for (var sor = 0; sor < sorszam; sor++) {

        var ujsor = document.createElement('div');
        ujsor.classList.add('sor');
        ujsor.id = sor*10;
        szuloelem.appendChild(ujsor);

        for (var oszlop = 0; oszlop <= sor; oszlop++) {
            var ujoszlop = document.createElement('div');
            ujoszlop.classList.add('oszlop');
            ujoszlop.innerText = faktoriális(sor) / (faktoriális(oszlop)*faktoriális(sor-oszlop));
            var szulosor = document.getElementById('sor');
            ujsor.appendChild(ujoszlop);
        }  
    }
}



var faktoriális = function (n) {
    let er = 1;
    for (let i = 2; i <= n; i++) {
        er = er * i;
    }
    return er;
}