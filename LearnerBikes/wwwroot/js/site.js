/*Open and close mobile filter and navigation menus*/
function toggleDisplay(id) {
    var filterSection = document.getElementById(id);
    if (filterSection.style.display === "block") {
        filterSection.style.display = "none";
    } else {
        filterSection.style.display = "block";
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

document.addEventListener("scroll", handleScroll)
/**/

/*Submit Contact Form*/
function SendEmail() {
    document.getElementById("contactForm").submit();
}
/**/