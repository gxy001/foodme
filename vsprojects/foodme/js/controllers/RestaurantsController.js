'use strict';

foodMeApp.controller('RestaurantsController',
    function RestaurantsController($scope, customer, $location, Restaurant) {

//if the customer hasn't input the address yet, redirect them to the customer page to input the address.
  if (!customer.address) {
    $location.url('/customer');
  }

//get all the Restaurants data and set up the query.
 var allRestaurants = Restaurant.query(filterAndSortRestaurants);

 var filter = $scope.filter = {
    cuisine: [],
    price: null,
    rating: null
  };

//register a listener to re-run the query when filter obejct value changes.
  $scope.$watch('filter', filterAndSortRestaurants, true);

  function filterAndSortRestaurants() {
    $scope.restaurants = [];
    // filter using Angular's angular.foreach() function
    angular.forEach(allRestaurants, function(item, key) {
      if (filter.price && filter.price !== item.price) {
        return;
      }

      if (filter.rating && filter.rating !== item.rating) {
        return;
      }

      if (filter.cuisine.length && filter.cuisine.indexOf(item.cuisine) === -1) {
        return;
      }

      $scope.restaurants.push(item);
    });


    // sort JS' array.sort() function
    $scope.restaurants.sort(function(a, b) {
      if (a[filter.sortBy] > b[filter.sortBy]) {
        return filter.sortAsc ? 1 : -1;
      }

      if (a[filter.sortBy] < b[filter.sortBy]) {
        return filter.sortAsc ? -1 : 1;
      }

      return 0;
    });
  };


  $scope.sortBy = function (key) {
//only one data column in the view can be selected for sorting.
//if sorting has already been applied for the selected column, then reverse the sorting.
    if (filter.sortBy === key) {
      filter.sortAsc = !filter.sortAsc;
    }
//else, then initial the sorting for the selected column.
    else {
      filter.sortBy = key;
      filter.sortAsc = true;
    }
  };


  $scope.sortIconFor = function(key) {
    if (filter.sortBy !== key) {
      return '';
    }

    return filter.sortAsc ? '\u25B2' : '\u25BC';
  };


  $scope.CUISINE_OPTIONS = {
    african: 'African',
    american: 'American',
    barbecue: 'Barbecue',
    cafe: 'Cafe',
    chinese: 'Chinese',
    'czech/slovak': 'Czech / Slovak',
    german: 'German',
    indian: 'Indian',
    japanese: 'Japanese',
    mexican: 'Mexican',
    pizza: 'Pizza',
    thai: 'Thai',
    vegetarian: 'Vegetarian'
  };

});
