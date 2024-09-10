

// PRODUCT DETAIL

$('.littleimages img').click(function () {
    $(".mainimage img").attr("src", "")
    $(".mainimage img").fadeOut(1)
    $(".mainimage img").fadeIn(1500)
        $(".mainimage img").attr("src", $(this).attr('src'))


})

let index = 0;
const images = $('.littleimages img');
const imageCount = images.length;


function right() {
    $(".mainimage").css('transition',"5s")
    index = (index + 1) % imageCount;
    updateImage();
    $(".mainimage img").attr("src", "")
    $(".mainimage img").fadeOut(1)
    $(".mainimage img").fadeIn(1500)
    $(".mainimage img").attr("src", $(this).attr('src'))
}

function left() {
    index = (index - 1 + imageCount) % imageCount;
    updateImage();
    $(".mainimage img").attr("src", "")
    $(".mainimage img").fadeOut(1)
    $(".mainimage img").fadeIn(1500)
    $(".mainimage img").attr("src", $(this).attr('src'))
}



    //const minus = document.querySelector('.minus')
    //const plus = document.querySelector('.plus')
    //let quantity = 1
    //minus.addEventListener('click', () => {
    //    if (quantity > 1) {
    //        quantity = quantity - 1
    //        document.querySelector('.number').innerHTML = quantity
    //    }
    //})
    //plus.addEventListener('click', () => {
    //    quantity = quantity + 1
    //    document.querySelector('.number').innerHTML = quantity
    //})



document.querySelector('.addbtn').addEventListener('click', function () {
    Swal.fire({
        title: 'Məhsul karta əlavə edildi',
        text: '',
        icon: 'success',
        confirmButtonText: 'Bağla'
    });
})






