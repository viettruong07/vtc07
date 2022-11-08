var app = angular.module('myApp', []);
app.controller('firstControllerObj', function ($scope){
    $scope.firstModelObj = {
        firstName: "Chris"
    };
});
app.controller('secondControllerObj', function ($scope){
    $scope.secondModelObj = {
        lastName: "Hemsworth"
    };
    $scope.getFullName = function (){
        return $scope.firstModelObj.firstName + " " + $scope.secondModelObj.lastName;
    };
});
app.controller('thirdControllerObj', function ($scope){
    $scope.thirdModelObj = {
        middleName: "Whitelaw",
        lastName: "Pine"
    };
    $scope.getFullName = function (){
        return $scope.firstModelObj.firstName + " " + $scope.thirdModelObj.middleName + " " + $scope.thirdModelObj.lastName;
    };
});