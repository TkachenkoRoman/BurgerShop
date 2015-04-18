var itemsList = [];

app.controller('ItemsController', ['$scope', 'shopService', '$routeParams', function ($scope, shopService, $routeParams) {

    $scope.items = itemsList;

    if (itemsList.length == 0)
    {
        shopService.getItems(function (data) {
            itemsList = data;
            $scope.items = itemsList;
        });
    }
    
    

    if ($routeParams.itemId != null)
        $scope.currentItem = getItem($routeParams.itemId);

    function getItem(id) {
        for (var i = 0; i < itemsList.length; i++) {
            if (itemsList[i].Id == id) {
                console.log(itemsList[i]);
                return itemsList[i];
            }
        }
        return null;
    };
}]);

