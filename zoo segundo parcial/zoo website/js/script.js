let login = document.querySelector(".login-form");

document.querySelector("#login-btn").onclick = () =>{
    login.classList.toggle('active');
    navbar.classList.remove('active');
}

let navbar = document.querySelector(".header .navbar");

document.querySelector('#menu-btn').onclick = () =>{
    login.classList.remove('active');
    navbar.classList.toggle('active');
}

window.onscroll = () =>{
    login.classList.remove('active');
    navbar.classList.remove('active');
}

var swiper = new Swiper(".gallery-slider", {
    grabCursor:true,
    loop:true,
    centeredSlides:true,
    spaceBetween:20,
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
    breakpoints: {
        0:{
            slidesPerView:1,
        },
        700:{
            slidesPerView:2,
        },
    }
})

 // Selecciona todos los botones "see details"
 var btns = document.querySelectorAll('.btn');
    
 // Agrega un evento de clic a cada botón
 btns.forEach(function(btn) {
     btn.addEventListener('click', function(e) {
         e.preventDefault();

         // Crea un modal
         var modal = document.createElement('div');
         modal.style.position = 'fixed';
         modal.style.top = '50%';
         modal.style.left = '50%';
         modal.style.transform = 'translate(-50%, -50%)';
         modal.style.backgroundColor = '#fff';
         modal.style.padding = '20px';
         modal.style.width = '400px';
         modal.style.height = '300px';
         modal.style.textAlign = 'center';
         modal.style.borderRadius = '10px';
         modal.style.boxShadow = '0px 0px 10px rgba(0, 0, 0, 0.25)';

         // Crea un párrafo de texto con la información del atributo de datos del botón
         var text = document.createElement('p');
         var info = this.getAttribute('data-info');
         text.innerHTML = info.replace(/\n/g, '<br>'); // Reemplaza los saltos de línea con <br>
         text.style.fontSize = '15px'; // Aumenta el tamaño de la fuente
         text.style.margin = '0'; // Elimina el margen
         text.style.padding = '0'; // Elimina el relleno

         // Crea un botón de cierre
         var closeButton = document.createElement('button');
         closeButton.textContent = 'X';
         closeButton.style.position = 'absolute';
         closeButton.style.right = '10px';
         closeButton.style.top = '10px';
         closeButton.style.backgroundColor = 'transparent';
         closeButton.style.border = 'none';
         closeButton.style.fontSize = '20px';
         closeButton.style.cursor = 'pointer';

         // Agrega un evento de clic al botón de cierre
         closeButton.addEventListener('click', function() {
             document.body.removeChild(modal);
         });

         // Agrega el párrafo de texto y el botón de cierre al modal
         modal.appendChild(text);
         modal.appendChild(closeButton);

         // Agrega el modal al DOM
         document.body.appendChild(modal);
     });
 });