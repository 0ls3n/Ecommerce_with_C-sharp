const navLinks = document.querySelector('.nav-links');

function onToggleMenu(e) {
    if (e.name === "menu-outline") 
    {
        e.name = "close";
        navLinks.classList.replace('nav-inactive', 'nav-active');
    } else if (e.name === "close") 
    {
        e.name = "menu-outline";
        navLinks.classList.replace('nav-active', 'nav-inactive');
    }
}
