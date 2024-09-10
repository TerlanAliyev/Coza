



//FilterMenu,SearcMenu
//$("#SearchMenu").hide()
$(".dropdown-menu").hide()
$("#FilterMenu").hide()
$('#searchButton').click(function () {
    $("#SearchMenu").slideToggle(300)

})
$('#filterButton').click(function () {
    $("#FilterMenu").slideToggle(1000)
})

$(".userpp").click(function () {
    $(".dropdown-menu").slideToggle()
})

$(".Overview").click(function () {
    $(".dropdown-menu").slideUp()
})
//$(".userpp").click(function () {
//    $(".dropdown-menu").slideDown()
//    $(".dropdown-menu").css("pointer-events","none")
//})
//$(".container").click(function () {
//    $(".dropdown-menu").slideUp()
//    $(".dropdown-menu").css("pointer-events", "auto")
//})



document.querySelectorAll('.heart').forEach(function (x) {
    x.addEventListener('click', function () {
        Swal.fire({
            title: 'Məhsul seçilmişlərə əlavə edildi',
            text: '',
            icon: 'success',
            confirmButtonText: 'Bağla'
        });
    })
});

let deyer = $('.searchbar input')

$(deyer).keyup(function () {
    $('.products .product').hide()
    $(".products .product").each(function () {
        if ($(this).text().toUpperCase().includes($(deyer).val().toUpperCase())) {
            $(this).show(500)
        }
        else {
            $(this).hide()
        }
    })
})

