initClima = () => {
    $.get("https://goweather.herokuapp.com/weather/Berazategui")
        .done(c => {
            $("#Clima").text(
                "Clima en Berazategui: Temperatura: " + 
                c.temperature + ", viento:" + c.wind
            );
        }).fail(() => {
            $("#Clima").text("No se pudo obtener el clima");
        });
};

if (typeof jQuery === 'undefined') {
    throw new Error('Bootstrap\'s JavaScript requires jQuery')
} else {
    $(document).ready(initClima);
}