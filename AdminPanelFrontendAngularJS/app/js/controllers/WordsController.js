(function () {
    'use strict';

    wordsLearningApp.controller("WordsController",
        function wordsController($scope) {

            $scope.searchQuery = '';
            
            $scope.searchBtnClicked = function () {
                $scope.searchQuery = $scope.searchFieldText;
            };

            $scope.words = [{
                id: 1,
                label: 'word1'
            }, {
                id: 2,
                label: 'word2'
            }, {
                id: 3,
                label: 'word3'
            }];
        });
})();
