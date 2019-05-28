angular.module('timeTracker', []).
    controller('TimeLogController', function ($scope, $http, $location, $window) {
        $scope.cust = {};
        $scope.message = 'Hello World';
        $scope.result = "color-default";
        $scope.isViewLoading = false;
        //get called when user submits the form  
        $scope.submitForm = function () {
            $scope.isViewLoading = true;
            console.log('Form is submitted with:', $scope.cust);
            //$http service that send or receive data from the remote server  
            $http(
                {
                    method: 'POST',
                    url: '/Home/CreateCustomer',
                    data: $scope.cust
                }).success(function (data, status, headers, config) {
                    $scope.errors = [];
                    if (data.success === true) {
                        $scope.cust = {};
                        $scope.message = 'Form data Submitted!';
                        $scope.result = "color-green";
                        $location.path(data.redirectUrl);
                        $window.location.reload();
                    }
                    else {
                        $scope.errors = data.errors;
                    }
                }).error(function (data, status, headers, config) {
                    $scope.errors = [];
                    $scope.message = 'Unexpected Error while saving data!!';
                });
            $scope.isViewLoading = false;
        }
    }).config(function ($locationProvider) {
        //default = 'false'  
        $locationProvider.html5Mode(true);
    }); 