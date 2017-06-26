/*global Umbraco */
angular.module("umbraco.resources")
    .factory("azureResource", function ($http, umbRequestHelper) {
        return {
            
            getServerEnvironment: function () {
                return $http.get('/umbraco/backoffice/azure/environment/getserverenvironment');
            }
        };
    });