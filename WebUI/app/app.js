var app = angular.module('shopApp', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider
        .when('/food',
            {
                controller: 'FoodController',
                templateUrl: '/app/partials/food.html'
            })
        .otherwise({ redirectTo: '/food' });
});




