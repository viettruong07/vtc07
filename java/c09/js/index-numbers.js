$(function (){
    $('li:lt(2)').removeClass('hot');
    $('li').eq(0).addClass('complete');
    $('li:ht(2)').addClass('cool');
});