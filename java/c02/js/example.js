// Khai báo biến và gán giá trị
var greeting = 'Howdy';
var name = 'Molly';
var message = ', please check your order:';
// Khai báo biến và gán phép tính
var welcome = greeting + name + message;

// Khai báo biến và các kiểu
var sign = 'Montague House';
var tiles = sign.length;
var subTotal = tiles * 5;
var shipping = 7;
var grandTotal = subTotal + shipping;

// Tìm đến id=greeting và thay đổi nội dung của biến welcome
var el = document.getElementById('greeting');
el.textContent = welcome;

//Tìm đến id=userSign và thay đổi nội dung của biến sign
var elSign = document.getElementById( 'userSign');
elSign.textContent = sign;

//Tìm đến id=tiles và thay đổi nội dung của biến tiles
var elTiles = document.getElementById('tiles');
elTiles.textContent = tiles;

//Tìm đến id=subTotal và thay đổi nội dung của phép tính
var elSubTotal = document.getElementById('subTotal');
elSubTotal.textContent = '$' + subTotal;

//Tìm đến id=shipping và thay đổi nội dung của phép tính
var elShipping = document.getElementById('shipping');
elShipping.textContent = '$' + shipping;

//Tìm đến id=grandTotal và thay đổi nội dung của phép tính
var elGrandTotal = document.getElementById('grandTotal');
elGrandTotal .textContent = '$' + grandTotal;

