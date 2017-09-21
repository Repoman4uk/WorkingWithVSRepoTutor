document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This is the elemnt from the third.js file";
    document.querySelector("body").appendChild(element);
});