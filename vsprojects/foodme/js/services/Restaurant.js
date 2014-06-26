'use strict';

var serverUri = 'http://localhost:31594';

foodMeApp.factory('Restaurant', function($resource) {
    return $resource('http://localhost:31594/api/restaurant/:id', { id: '@id' });
});
