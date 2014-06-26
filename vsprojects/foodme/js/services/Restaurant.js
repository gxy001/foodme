'use strict';

var serverUri = 'http://localhost:31594';

foodMeApp.factory('Restaurant', function($resource) {
    return $resource('http://localhost:port/api/restaurant/:id', { port: ':31594', id: '@id' });
});
