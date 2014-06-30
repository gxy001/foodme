'use strict';

foodMeApp.factory('Restaurant', function($resource) {
    return $resource('http://localhost:port/api/restaurant/:id', { port: portNumber, id: '@id' });
});
