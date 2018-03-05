window.onload = getRandomImage;
var randomImage = new Array(
    "https://images.pexels.com/photos/762080/pexels-photo-762080.jpeg?w=1260&h=750&dpr=2&auto=compress&cs=tinysrgb",
    "https://images.pexels.com/photos/615482/pexels-photo-615482.jpeg?w=940&h=650&dpr=2&auto=compress&cs=tinysrgb",
    "https://images.pexels.com/photos/631214/pexels-photo-631214.jpeg?w=940&h=650&dpr=2&auto=compress&cs=tinysrgb",
       "https://images.pexels.com/photos/897262/pexels-photo-897262.jpeg?w=940&h=650&dpr=2&auto=compress&cs=tinysrgb",
       "https://images.pexels.com/photos/665194/pexels-photo-665194.jpeg?w=940&h=650&dpr=2&auto=compress&cs=tinysrgb");

    function getRandomImage() {
        var number = Math.floor(Math.random() * randomImage.length);
        document.getElementById("myPicture").src = randomImage[number];
    }
  
