$(function (){
    var backgroundColor = $('li').css('background-color');
    $('ul').append('<p>Color was: ' + backgroundColor + '</p>');

    $('li').css({
        'background-color': '#c5a996',
        'border': '1px soild #fff',
        'color': '#000',
        'text-shadow': 'none',
        'font-family': 'Georgia',
        'padding-left': '+=75'
    });
});
