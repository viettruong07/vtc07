(function (){
    var hotel = {
        name : 'Park',
        roomRate: 240,
        discount: 15,
        offerPrice: function() {
            var offerRate = this.roomRate * ((100 - this.discount) / 100);
            return offerRate;
        }
    };
    var hotelName, roomRate, specialRate;

    hotelName = document.getElementById('hotelName');
    roomRate = document.getElementById('roomRate');
    specialRate = document.getElementById('specialRate');

    hotelName.textContent = hotel.name;
    roomRate.textContent = '$' + hotel.roomRate.toFixed(2);
    specialRate.textContent = '$' + hotel.offerPrice();

    var expiryMSg;
    var today;
    var elEnds;

    function offerExpires(today) {
        var weekFromToday, day, date, month, year, dayNames, monthNames;

        weekFromToday = new Date(today.getTime() + 7 * 24 * 60 * 1000);
        dayNames = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thurday', 'Friday', 'Saturday'];
        monthNames = ['January', 'February', 'Match', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];

        day = dayNames[weekFromToday.getDay()];
        date = weekFromToday.getDate();
        month = monthNames[weekFromToday.getMonth()];
        year = weekFromToday.getFullYear();

        expiryMSg = 'Offer expires next';
        expiryMSg += day + '<br/>(' + date + ' ' + month + ' ' + year + ')';
        return expiryMSg;
    }

    today = new Date();
    elEnds = document.getElementById('offerEnds');
    elEnds.innerHTML = offerExpires(today);
}());