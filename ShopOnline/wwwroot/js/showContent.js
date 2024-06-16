window.onscroll = function () {
    myFunction();
};

const header = document.getElementById("header");
const header2 = document.getElementById("header2");
const banner = document.getElementById("banner").offsetHeight;

const sticky = header.offsetTop + banner;

function myFunction() {
    if (window.scrollY > sticky) {
        header.classList.add("sticky");
        header2.classList.add("sticky");
    } else {
        header.classList.remove("sticky");
        header2.classList.remove("sticky");
    }
}

document.getElementById("clickMenu").addEventListener('click', function () {
    document.getElementById('menuMobile').style.display = 'block';
});
document.getElementById("close-menu").addEventListener('click', function () {
    document.getElementById('menuMobile').style.display = 'none';
});


document.getElementById('search-icon').addEventListener('click', function () {
    document.getElementById('search-bar').style.display = 'flex';
});

document.getElementById('close-search').addEventListener('click', function () {
    document.getElementById('search-bar').style.display = 'none';
});


document.getElementById("showContent").addEventListener('click', function (event) {
    document.getElementById('menuContentMobile').style.display = 'block';
    event.stopPropagation();
});

const content = document.getElementById('menuContentMobile');

function hideContent(event) {
    if (!content.contains(event.target) && event.target.id !== 'showContent') {
        content.style.display = "none";
    }
}

document.addEventListener('click', hideContent);

content.addEventListener('click', (event) => {
    content.style.display = "block";
    event.stopPropagation();
});

function scrollMenu(amount) {
    const menu = document.getElementById('menu');
    menu.scrollLeft += amount;
     
    if (menu.scrollLeft + amount === 0){
      document.getElementById('clickBack').style.display = "none";
    }else{
        document.getElementById('clickBack').style.display = "block";
    }
}