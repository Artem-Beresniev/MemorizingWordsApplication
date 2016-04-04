(function () {
    'use strict';

    wordsLearningApp.controller("AddEditWordController",

        function addEditWordController($scope, $routeParams) {

            if ($routeParams.wordId) {
                $scope.pageTitle = "Edit word";
            } else {
                $scope.pageTitle = "Add word";
            }

            $scope.languages = [ {
                id: 1,
                label: 'English',
                isVisible: 1
            }, {
                id: 2,
                label: 'Russian',
                isVisible: 1
            }, {
                id: 3,
                label: 'Spanish',
                isVisible: 0
            }];

            $scope.selectedLanguageId = 2;

            $scope.translateToLanguages = [{
                id: 1,
                label: 'English',
                isVisible: 1
            }, {
                id: 2,
                label: 'Russian',
                isVisible: 0
            }, {
                id: 3,
                label: 'Spanish',
                isVisible: 1
            }];

            $scope.selectedTranslateToLanguageId = 3;

        });
})();
