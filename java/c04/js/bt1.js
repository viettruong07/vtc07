var diem;
var ketqua;
ketqua = 100;
if(diem => 80){
    ketqua = 'Ban Da Do';
} else if(diem < 80){
    ketqua = 'Ban Da Truot';
} else{
    ketqua = 'Welcome';
}
document.write('<h3>' + ketqua + '</h3>');