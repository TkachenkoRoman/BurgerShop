app.service('shopService', ['$http', function ($http) {

    var service = {
        items: [],
        getItems: getItems
    };
    return service;

    function getItems() {
        return $http.get('api/api/items').success(function (response) {
                service.items = response;
            });
    };
}]);