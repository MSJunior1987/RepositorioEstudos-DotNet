
var videoStream = null;
var vdCamera = null;
var cvFoto = null;
var filmroll = null;
var dialog = null;

window.onload = inicializar;

//função de inicialização
//Criado por: Márcio Junior
//Criado em: 23/06/2015
function inicializar() {    
    vdCamera = document.getElementById("vdCamera");
    cvFoto = document.getElementById("cvFoto");
    filmroll = document.getElementById("filmroll");
    dialog = document.getElementById("dialog");
    document.getElementById("btnSalvar").onclick = guardarFoto;    
    document.getElementById("imgCamera").onclick = fotografar;
    document.getElementById("imgLixeira").onclick = cancelar;
    inicializarCamera();
}

//Inicializa a camera
//Criado por: Márcio Junior
//Criado em: 23/06/2015
function inicializarCamera() {
    window.navigator = window.navigator || {};
    navigator.getUserMedia = navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia || null;
    if (navigator.getUserMedia === null) {
        alert("seu navegador não possui suporte a captura de imagem.");
        //Altera a visualização da div principal caso o navegador não de suporte a camera
        document.getElementById("divPrincipal").style.display = "none";
    }
    else {
        var createSrc = window.URL ? window.URL.createObjectURL : function (stream) { return stream; };
        var audioContext = window.AudioContext || window.webkitAudioContext || null;
        if (audioContext === null) {
            alert("Seu navegador não da suporte a captura de audio.");
        }
        ligarCamera(createSrc);
    }
}

//Método responsável por ligar a camera
//Criado por: Márcio Junior
//Criado em: 23/06/2015
function ligarCamera(pSrc) {
    // Capture user's audio and video source
    navigator.getUserMedia({
        video: true,
        audio: false
    },
    function (stream) {
        videoStream = stream;
        // Stream the data
        // vdCamera.src = pSrc(stream);
        vdCamera.src = pSrc;
        vdCamera.play();
    },
    function (error) {
        console.log("Video capture error: ", error.code);
    });
}

//Método responsável por fotografar
//Criado por: Márcio Junior
//Criado em: 23/06/2015
function fotografar() {

    // Deixa o canvas com o tamanho do vídeo capturado pela camera
    // dobrando o tamanho da figura
    /*cvFoto.width = vdCamera.clientWidth
    cvFoto.height = vdCamera.clientHeight*/

    // Desenha o momento do video no canvas
    c = cvFoto.getContext("2d")
    c.drawImage(vdCamera, 0, 0, cvFoto.width , cvFoto.height)
    
    abrirModal(dialog)
}

//Método responsável por guardar a foto salva
//Criado por: Márcio Junior
//Criado em: 23/06/2015
function guardarFoto() {
    // Cria o elemento img arrastável utilizando a fotografia no canvas
    img = document.createElement("img")
    img.src = cvFoto.toDataURL("image/png")
    img.style.padding = 5
    img.width = cvFoto.width / 2
    img.height = cvFoto.height / 2
    img.draggable = true

    //criar tag br
    //br = document.createElement("br")

    // Adiciona a imagem a div filmroll
    filmroll.appendChild(img)
    //filmroll.appendChild(br)
    fecharModal(dialog)
}

function cancelar() {
    fecharModal(dialog)
}









