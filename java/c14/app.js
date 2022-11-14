var app = angular.module('myApp', []);
app.controller("myCtrl", function ($scope){
    console.log("My controller.....");

    $scope.users = [
        {name: "Viet", email: "truongviet0707@gmail.com", fullname: "Truong Cong Viet"},
        {name: "VietTC", email: "congviet0707@gmail.com", fullname: "Truong Viet"},
        {name: "Tomorrow", email: "tomorrow2504@gmail.com", fullname: "Tomorrow2504"},
    ];

    $scope.addUser = function (){
        $scope.users.push($scope.newUser);
        $scope.newUser = {};
        $scope.message = "New User Added successfully";
    };

    $scope.selectUser = function (user){
        console.log(user);
        $scope.clickedUser = user;
    };

    $scope.editUser = function (){
        $scope.message = "User Edited successfully";
    };

    $scope.deleteUser = function (){
        $scope.users.splice($scope.users.indexOf($scope.clickedUser));
        $scope.message = "User Deleted successfully";
    };

    $scope.clearMessage = function (){
        $scope.message = "";
    };
});