var title;
var message;

title = "Molly's Special offers";
message = '<a href=\"sale.html\">25% off!</a>';

var elTitle = document.getElementById(elementld: 'title');
elTitle.textContent = title;

var elNote = document.getElementById(elementld: 'note');
elNote.innerHTML = message;