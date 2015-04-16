app.controller('FoodController', function ($scope, shopService) {

    init();

    $scope.items = [];

    function init() {
        shopService.getItems(function (data) {
            $scope.items = data;
            console.log($scope.items);
        });
    }
});
