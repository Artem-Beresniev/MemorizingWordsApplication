
    'use strict';

    var wordsLearningApp = angular.module('wordsLearningApp', ['ngResource', 'ngRoute', 'ngCookies']).config([
        '$routeProvider',
        function($routeProvider) {
            $routeProvider.
                when('/words', {    //!Words
                    templateUrl: 'templates/Words.html',
                    controller: 'WordsController'
                }).
                when('/words/new', {
                    templateUrl: 'templates/AddEditWord.html',
                    controller: 'AddEditWordController'
                }).
                when('/words/:wordId', {
                    templateUrl: 'templates/AddEditWord.html',
                    controller: 'AddEditWordController'
                }).
                when('/contextManagement', {    //!Context Management
                    templateUrl: 'templates/ContextManagement.html',
                    controller: 'ContextManagementController'
                }).
                when('/contextManagement/:bookId', {
                    templateUrl: 'templates/ContextManagement.html',
                    controller: 'ContextManagementController'
                }).
                when('/contextManagement/:bookId/:unitId', {
                    templateUrl: 'templates/ContextManagement.html',
                    controller: 'ContextManagementController'
                }).
                when('/books', {    //!Books
                    templateUrl: 'templates/Books.html',
                    controller: 'BooksController'
                }).
                when('/books/new', {
                    templateUrl: 'templates/AddEditBook.html',
                    controller: 'AddEditBookController'
                }).
                when('/books/:bookId', {
                    templateUrl: 'templates/AddEditBook.html',
                    controller: 'AddEditBookController'
                }).
                when('/units', {     //!Units
                    templateUrl: 'templates/Units.html',
                    controller: 'UnitsController'
                }).
                when('/units/new', {
                    templateUrl: 'templates/AddEditUnit.html',
                    controller: 'AddEditUnitController'
                }).
                when('/units/:unitId', {
                    templateUrl: 'templates/AddEditUnit.html',
                    controller: 'AddEditUnitController'
                }).
                otherwise({
                    redirectTo: '/words'
                });
        }
    ]);
