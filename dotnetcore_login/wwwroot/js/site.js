// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const btnLogin = document.getElementById('Login');

btnLogin.addEventListener('click', (e) => {
    
    const user = document.getElementById('user');
    const pass = document.getElementById('pass');

    if(user.value && pass.value) {
        if(user.value === "Geko" && pass.value === "123") {
            alert('Ingreso correcto!');
        } else {
            alert('Datos inválidos');
        }
    } else {
        alert('Ingrese las credenciales');
    }
})