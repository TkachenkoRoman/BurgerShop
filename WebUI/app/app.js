var app = angular.module('shopApp', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider
        .when('/shop/:category',
            {
                controller: 'ItemsController',
                templateUrl: '/app/partials/items.html'
            })
        .when('/items/:itemId',
            {
                controller: 'ItemsController',
                templateUrl: '/app/partials/itemDetails.html'
            })
        .otherwise({ redirectTo: '/shop/food' });
});


