app.controller('ItemsController', ['$scope', 'shopService', '$routeParams', 
    function ($scope, shopService, $routeParams) {
    
    this.getItems = function () {
        shopService.getItems()
            .success(function (items) {
                console.log('items returned to controller.', items);

                if ($routeParams.itemId != null)
                    $scope.currentItem = getItem($routeParams.itemId, items);

                $scope.items = chunk(items, 3); // splice items into rows to make good layout
            })
            .error(function () {
                console.log('items retrieval failed.');
            });
    };
    
    this.getItems();
    
    function chunk(items, size) {
        var arrays = [];
        while (items.length > 0)
            arrays.push(items.splice(0, size));
        return arrays;
    };

    function getItem(id, items) {
        for (var i = 0; i < items.length; i++) {
            if (items[i].Id == id) {
                return items[i];
            }
        }
        return null;
    };
}]);

