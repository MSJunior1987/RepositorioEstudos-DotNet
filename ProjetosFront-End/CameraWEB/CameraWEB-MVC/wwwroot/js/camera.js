////Metodos de funcionalidade da camera////
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

document.querySelector('#idSalvarFoto').addEventListener('click', function (e) {     
   var foto = document.querySelector("#imgFoto");
   foto.src = document.querySelector('#cvFoto').toDataURL("image/png");      
   $('#divModalCamera').modal('hide')
}) 

//// Botao de Upload de imagem////
document.querySelector("#fileUpload").onchange = function (e){
   //Get count of selected files
   var countFiles = $(this)[0].files.length;

   var imgPath = $(this)[0].value;
   var extn = imgPath.substring(imgPath.lastIndexOf('.') + 1).toLowerCase();
   var imgFoto = $("#imgFoto");
   imgFoto.empty();
   
   // var image_holder = $("#image-holder");
   // image_holder.empty();

   if (extn == "gif" || extn == "png" || extn == "jpg" || extn == "jpeg") {
       if (typeof (FileReader) != "undefined") {

           //loop for each file selected for uploaded.
           for (var i = 0; i < countFiles; i++) {

               var reader = new FileReader();
               reader.onload = function (e) {
                   $("<img />", {
                       "src": e.target.result,
                           "class": "thumb-image"
                   }).appendTo(imgFoto);
               }

               imgFoto.show();
               reader.readAsDataURL($(this)[0].files[i]);
           }

       } else {
           alert("Seu browser não suporta o FileReader.");
       }
   } else {
       alert("Por favor selecione somente imagens.");
   }
};
/////////////////////////////////////////////////////
