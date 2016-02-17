var app = angular.module('app', []);
        app.controller('Controller', function ($scope, $http) {
            $scope.Users = [];
            $http({
                method: 'GET',
                url: '/api/user'                
            }).success(function (result) {
                $scope.Users = result;
            });
        });
        
        app.filter("enum", function () {
           return function (id) {
                switch (id)
                {                  
                    case 1:
                    {
                        return "Music";
                        break;
                    }
                    case 2:
                    {
                        return "Picture";
                        break;
                    }
                    case 3:
                    {
                        return "Sport";
                        break;
                    }
                    case 4:
                    {
                        return "Game";
                        break;
                    }
                }
           }
        });