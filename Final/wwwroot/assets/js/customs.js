$(document).ready(function () {

    //addBasket
    $(document).on("click", ".addtocart", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url).then(response => response.text()).then(data => {
            $(".forbasket").html(data);
            var closebasket = document.querySelector(".closebasket");
            closebasket.addEventListener("click", function (e) {
                e.preventDefault();
                var basketfor = document.querySelector(".forbasket");
                basketfor.style.visibility = "hidden";
                basketfor.style.right = "-100%";
                basketfor.style.opacity = "0";
            })
        })

    })
    //basketcount
    $(document).on("click", ".basketUpdate", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        let count = parseInt($(this).parent().find(".countInp").text());
        let id = 0;

        if ($(this).hasClass("subCount")) {
            if (count != 1) {
                count--;
            }
            id = $(this).next().attr("data-id");


            $(this).next().text(count);
        }
        else if ($(this).hasClass("addCount")) {
            count++;
            id = $(this).prev().attr("data-id");


            $(this).prev().text(count);
        }

        url = "Basket/Update" + "?id=" + id + "&count=" + count;


        fetch(url).then(response => {
            fetch("Basket/GetBasket").then(response => response.text()).then(data => $(".forbasket").html(data))
            return response.text()

        }).then(data => $(".maincart").html(data))

    })
    //deleteproductformcard
    $(document).on("click", ".deletecard", function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url).then(response => {
            fetch("Basket/GetBasket").then(response => response.text()).then(data => $(".forbasket").html(data))

            return response.text()
        }).then(data => $(".maincart").html(data))
    })
    //deleteproductfrombasket
    $(document).on("click", ".deletebasket", function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url).then(response => {
            fetch("Basket/GetCard").then(response => response.text()).then(data => $(".maincart").html(data))

            return response.text()
        }).then(data => $(".forbasket").html(data))
    })
    //search
    $(document).on("keyup", "#searchBtn", function (e) {
        e.preventDefault()
        console.log($(this).val())
        let url = $("#searchForm").attr("action");
        fetch(url + "?key=" + $(this).val()).then(res => {
            return res.text()
        }).then(data => {
            $("#productList").html(data)
        })
    })
})