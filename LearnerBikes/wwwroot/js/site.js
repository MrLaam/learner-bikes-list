function toggleDisplay(id) {
    var filterSection = document.getElementById(id);
    if (filterSection.style.display === "block") {
        filterSection.style.display = "none";
    } else {
        filterSection.style.display = "block";
    }
}

function applyFilters() {
    document.getElementById("bikeFilterForm").submit();
}