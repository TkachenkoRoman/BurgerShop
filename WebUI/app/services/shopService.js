app.service('shopService', ['$http', function ($http) {

    this.getItems = function (callback) {
        $http.get('api/api/items').success(function (response) {
            callback(response);
            console.log(response);
        });
    };
}]);