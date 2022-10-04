
/*creo las constantes para acceder al form y a los inputs*/ 
    const form  = document.getElementById('formulario');
    const inputs = document.querySelectorAll ('#formulario input');
    
//variables para capturar los valores 
var c_nombre ="";
var c_apellido ="";
var c_edad ="";
var c_sexo =""; 
var c_empresa="";

//constantes para botones del form y la modal
const btn_restablecer = document.getElementById('restablecerForm');

const expresiones = {
	nombre: /^[a-zA-ZÀ-ÿ\s]{1,40}$/,
    apellido: /^[a-zA-ZÀ-ÿ\s]{1,40}$/, // Letras y espacios, pueden llevar acentos.
    edad:/^[0-9]{1,3}$/,
};
//objeto que me permite luego utilizarla para saber si se completaron todos los cmapos obligatorios
const campos = {
    nombre: false,
    apellido: false,
    edad: false,
    sexo: false,
    empresa:false,
}



//funcion principal de validacion, valida todo el formulario cuyo campo sea obligatorio
const validarForms = (e) =>{
    switch (e.target.name){
        
         case "nombre":
           validarCampoText(expresiones.nombre, e.target, 'nombre');
           c_nombre = e.target.value;
         break;
         case "apellido":
            validarCampoText(expresiones.apellido, e.target, 'apellido');
            c_apellido = e.target.value;

         break;
         case "edad":
            validarCampoText(expresiones.edad, e.target, 'edad');
            c_edad = e.target.value;
         break;
         case "sexo":
            validarRadioHM(e);
            c_sexo = e.target.value;

         break;
         case "empresa":
            c_empresa = e.target.value;
         break;
     }
};
//validar si se clickeo en algun radio de las opcion hombre, mujer u otros
const validarRadioHM = function(e){
    if(e.target.value == 'hombre' ||e.target.value == 'mujer'  || e.target.value =='otro'  ){
        document.getElementById( 'grupo_sexo').className ='grid-field success';
        campos[e.target.name] = true;


    }else{
        document.getElementById( 'grupo_sexo').className ='grid-field error';
        campos[e.target.name] = false;

    }
};

//valido cualquie campo de string, que respete la exp regular
function validarCampoText(expresion, input, campo){
    if(expresion.test(input.value)){
                
        document.getElementById( `grupo_${campo}`).className ='grid-field success';
        campos[campo] = true;

    }else{

        document.getElementById(`grupo_${campo}`).className ='grid-field error';
        campos[campo] = false;
    }

};
const enviarForm = function(e){
    alert(' Formulario enviado!, los campos son:  '
        + '  Nombres: '+ c_nombre
        + '  Apellido: '+ c_apellido
        + '  Edad '+ c_edad
        + '  Sexo: '+ c_sexo
        + '  Empresa: '+ c_empresa
    );
}

//controlo el comportamiento al soltar una tecla o cambiar de foco
inputs.forEach((input) =>{
    input.addEventListener('keyup', validarForms);
    input.addEventListener('blur',validarForms);
});


form.addEventListener('submit',(e)=>{
    e.preventDefault();

    //verifico q todos los campos obligatorios esten completos
    if (campos.nombre && campos.apellido && campos.edad  && campos.sexo ) {
        enviarForm();
        form.reset();
        //quito los iconos y el color del input
        document.querySelectorAll('.grid-field.success i.fa-circle-check').forEach((icon)=>{
            icon.className = '.grid-field i.fa-circle-check';
        });
        //recargho la pagina
        window.location.reload();

    }else{
        alert('completar todos los campos!!');
    }
});

btn_restablecer.addEventListener('click',()=>{
    window.location.reload();
});







