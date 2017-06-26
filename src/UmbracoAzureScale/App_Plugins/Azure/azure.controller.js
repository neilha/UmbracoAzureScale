function azureController($log, $scope, $timeout, notificationsService, azureResource, $q) {

    azureResource.getServerEnvironment().then(function (response) {
        $scope.env = response.data;
    });
}

