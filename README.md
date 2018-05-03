# DoomFaceBattery
Windows Phone 8.1 App

Battery Percentage = Health %

![DoomGoodFaceS](https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomGoodFaceS.png)
![DoomMussedS](https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomMussedS.png)
![DoomSwollenS](https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomSwollenS.png)
![DoomDirtyS](https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomDirtyS.png)
![DoomBloodyS](https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomBloodyS.png)


<html>
   <head>
      <title>change picture</title>
      <script type = "text/javascript">
          function displayNextImage() {
              x = (x === images.length - 1) ? 0 : x + 1;
              document.getElementById("img").src = images[x];
          }
          function startTimer() {
              setInterval(displayNextImage, 3000);
          }
          var images = [], x = -1;
          images[0] = "https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomGoodFaceS.png";
          images[1] = "https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomMussedS.png";
          images[2] = "https://github.com/Danielkaas94/DoomFaceBattery/blob/master/DoomFaceBattery/Assets/ImageFace/DoomSwollenS.png";
      </script>
   </head>

   <body onload = "startTimer()">
       <img id="img" src="startpicture.jpg"/>
       <button type="button" onclick="displayPreviousImage()">Previous</button>
       <button type="button" onclick="displayNextImage()">Next</button>
   </body>
</html>
