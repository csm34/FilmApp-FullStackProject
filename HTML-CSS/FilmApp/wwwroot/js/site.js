// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var buttons = document.querySelectorAll(".buttons button");
buttons.forEach(function(button){
    button.addEventListener('click', function(){
        var filmId = this.getAttribute('data-filmid');
        var isLike = this.classList.contains('button-blue');
        var data = {
            filmId:filmId,
            isLike:isLike
        };
        fetch("/film/like", {
            method:"POST",
            headers:{
                "Content-Type":"application/json"
            },
            body:JSON.stringify(data),
        }).then(function(response){
            return response.json();
        }).then(function(data){
            if(data){
                button.innerHTML=data;
            }
        })
    });
});
