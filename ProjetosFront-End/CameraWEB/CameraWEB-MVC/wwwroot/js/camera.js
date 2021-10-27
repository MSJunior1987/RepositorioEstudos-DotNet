document.querySelector('#btnInserirImagem').addEventListener('click', function (e) {
   $('#divVideo').show();
   $('#divBotoesFotografar').show();
   $('#divCanvas').hide();
   $('#divBotoesImagem').hide();
   navigator.mediaDevices.getUserMedia({
      video: true
   })

   .then(function (stream) {
      var video = document.querySelector('#video');
      video.srcObject = stream;
      video.play();
   })
})

document.querySelector('#btnFotografar').addEventListener('click', function (e) {

 var canvas = document.querySelector("#cvFoto");
 var video = document.querySelector('#video');

 canvas.height = video.videoHeight;
 canvas.width = video.videoWidth;

 var context = canvas.getContext('2d');
 context.drawImage(video, 0, 0)
})

document.querySelector('#btnFotografar').addEventListener('click', function (e) {  
   $('#divCanvas').show();
   $('#divBotoesImagem').show();
   $('#divVideo').hide();
   $('#divBotoesFotografar').hide();
}) 

document.querySelector('#idExcluirFoto').addEventListener('click', function (e) {    
   $('#divVideo').show();
   $('#divBotoesFotografar').show();
   $('#divCanvas').hide();
   $('#divBotoesImagem').hide();
}) 

document.querySelector('#idFechar').addEventListener('click', function (e) {  
   var video = document.querySelector('#video');
   video.pause();
   video.src = ""; 
   stream.getTracks()[0].stop();  
})   


