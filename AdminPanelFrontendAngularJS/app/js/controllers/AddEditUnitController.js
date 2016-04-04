(function () {
    'use strict';

    wordsLearningApp.controller("AddEditUnitController",

        function addEditUnitController($scope, $routeParams) {

            if ($routeParams.unitId) {
                $scope.pageTitle = "Edit unit";
            } else {
                $scope.pageTitle = "Add unit";
            }

            $scope.message = "Add\Edit unit controller message";

            

        });
})();
