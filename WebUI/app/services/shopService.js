app.service('shopService', function ($http) {

    this.getItems = function (callback) {
        $http.get('api/api/items').success(function (response) {
            callback(response);
        });
    };

    this.getItem = function (id) {
        for (var i = 0; i < items.length; i++) {
            if (items[i].id === id) {
                return items[i];
            }
        }
        return null;
    };

});