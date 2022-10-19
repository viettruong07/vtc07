$(function (){
    var $p = $('p');

    var $clonedQuote = $p.clone();
    $p.remove();
    $clonedQuote.inserAfter('h2');

    var $moveItem = $('#one').detach();
    $moveItem.appendTo('ul');

});
