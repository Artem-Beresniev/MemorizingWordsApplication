(function () {
    'use strict';

    wordsLearningApp.controller("AddEditBookController",

        function addEditBookController($scope, $routeParams) {

            if ($routeParams.bookId) {
                $scope.pageTitle = "Edit book";
            } else {
                $scope.pageTitle = "Add book";
            }

            $scope.message = "Add\Edit book controller message";

           

        });
})();
