document.addEventListener("DOMContentLoaded", function (event) {
  const showNavbar = (toggleId, navId, bodyId, headerId) => {
    const toggle = document.getElementById(toggleId),
      nav = document.getElementById(navId),
      bodypd = document.getElementById(bodyId),
      headerpd = document.getElementById(headerId);

    if (toggle && nav && bodypd && headerpd) {
      toggle.addEventListener("click", () => {
        nav.classList.toggle("show");
        toggle.classList.toggle("bx-x");
        bodypd.classList.toggle("body-pd");
        headerpd.classList.toggle("body-pd");
      });
    }
  };

  showNavbar("header-toggle", "nav-bar", "body-pd", "header");

  const linkColor = document.querySelectorAll(".nav_link span");

  function colorLink() {
    event.preventDefault(); // Sayfanın yenilenmesini engeller

    if (linkColor) {
      linkColor.forEach((l) => l.classList.remove("active"));
      this.classList.add("active");
    }
  }
  linkColor.forEach((l) => l.addEventListener("click", colorLink));

  function colorLinkWhenRefresh() {
    event.preventDefault(); // Sayfanın yenilenmesini engeller
    var currentUrl = window.location.href;
    var filename = currentUrl.substring(currentUrl.lastIndexOf("/") + 1);
    linkColor.forEach((l) => l.classList.remove("active"));

    linkColor.forEach((link) => {
      if (link.getAttribute("href") === filename) {
        console.log("test");
        link.classList.add("active");
      }
    });
  }
  colorLinkWhenRefresh();
});
