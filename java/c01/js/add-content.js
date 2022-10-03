var today = new Date();
var hourNow = today.getHours();
var greeting;

if (hourNow > 18){
    greeting = 'Good evening!';
} eles if(hourNow > 12){
    greeting = 'Good afternoon!';
} else if(hourNow > 0){
    greeting = 'Good morning!';
} else {
    greeting = 'Welcome!';
}
document.wite('<h3>' + greeting + '</h3>');