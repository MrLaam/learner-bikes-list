/*Open and close mobile navigation menu*/
function toggleNavbar(id) {
    var filterSection = document.getElementById(id);
    var navbarBlankSpace = document.getElementById('navbarBlankSpace');
    if (filterSection.style.display === "block") {
        filterSection.style.display = "none";
        navbarBlankSpace.style.display = "none";
        document.getElementsByTagName("body")[0].style = "overflow: auto"
    } else {
        filterSection.style.display = "block";
        navbarBlankSpace.style.display = "block";
        document.getElementsByTagName("body")[0].style = "overflow: hidden";
    }
}
/**/

/*Toggle mobile filter menu*/
function toggleFilter(id) {
    var filter = document.getElementById(id);
    if (filter.style.display === "block") {
        filter.style.display = "none";
    } else {
        filter.style.display = "block";
    }
}
/**/

/*Motorcycle filtering*/
function applyFilters() {
    document.getElementById("bikeFilterForm").submit();
}
/**/


/*Scroll to top*/
var scrollToTopBtn = document.getElementById("scrollToTopBtn");
var rootElement = document.documentElement;

function scrollToTop() {
    rootElement.scrollTo({
        top: 0,
        behavior: "smooth"
    })
}

scrollToTopBtn.addEventListener("click", scrollToTop);

function handleScroll() {
    var scrollTotal = rootElement.scrollHeight - rootElement.clientHeight
    if ((rootElement.scrollTop / scrollTotal) > 0.75) {
        scrollToTopBtn.classList.add("showBtn")
    } else {
        scrollToTopBtn.classList.remove("showBtn")
    }
}

document.addEventListener("scroll", handleScroll);
/**/

/*Submit Contact Form*/
function sendEmail() {
    
}
/**/