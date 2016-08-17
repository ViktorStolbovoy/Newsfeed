'use strict';

// Declares how the application should be bootstrapped. See: http://docs.angularjs.org/guide/module
var app = angular.module('app', ['ngMaterial']);
app.config(function ($mdThemingProvider) {
	$mdThemingProvider.theme('default');
});

 app.controller('HomeCtrl', ['$scope', '$window', '$http', function ($scope, $window, $http) {

		var apiUrl = "/api/news";

		$scope.$root.title = 'Newsfeed Demo';
		$scope.loaded = false;
		$scope.newMessageDate = new Date();

		$http({
			method: 'GET',
			url: apiUrl
		}).then(function successCallback(res) {
			$scope.articles = res.data;
			if ($scope.articles) {
				for (var i = 0; i < $scope.articles.length; i++) {
					var item = $scope.articles[i];
					item.Published = new Date(item.Published);
				}
			}
			$scope.loaded = true;
		}, function errorCallback(response) {
			$scope.loaded = true;
			$window.alert("News retrievel failed");
		});


		$scope.publish = function () {
			if (!$scope.newMessageBody) {
				$window.alert("Please provide the text");
				return;
			}

			if (!$scope.newMessageDate) {
				$window.alert("Please provide the publication date");
				return;
			}

			var newArticle = {};
			newArticle.Body = $scope.newMessageBody;
			newArticle.Published = new Date($scope.newMessageDate);
			$scope.storing = true;
			$http({
				method: 'POST',
				url: apiUrl,
				data: newArticle
			}).then(function successCallback(response) {
				//Proper insert
				if ($scope.articles) {
					var inserted = false;
					for (var i = 0; i < $scope.articles.length; i++) {
						if ($scope.articles[i].Published <= newArticle.Published) {
							$scope.articles.splice(i, 0, newArticle);
							inserted = true;
							break;
						}

					}
					if (!inserted) {
						$scope.articles.push(newArticle);
					}
				}
				else {
					$scope.articles = [];
					$scope.articles.push(newArticle);
				}

				$scope.newMessageBody = "";

				$scope.storing = false;

			}, function errorCallback(response) {
				$scope.storing = false;
				$window.alert("Publication failed");
			});
		}

	}])

	// Path: /error/404
	app.controller('Error404Ctrl', ['$scope','$window', function ($scope, $window) {
		$scope.$root.title = 'Error 404: Page Not Found';
	}]);