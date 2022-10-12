// Create a variable for the subtotal and make a calculation
var subtotal = (13 + 1) * 5; //Sutotal is 70

// Create a variable for the shipping and make a calculation
var shipping = 0.5 * (13 + 1); //Shipping is 7

// Create the total by combining the subtotal and shipping values
var total = subtotal + shipping; //Total is 77

//Write the results to the screen
var slSub = document.getElementById(elementld: 'subtotal');
elSub.textContent = subtotal;

var elShip = document.getElementById(elementld: 'shipping');
elShip.textContent = shipping;

var elTotal = document.getElementById(elementld: 'total');
elTotal.textContent = total;