describe('sectionAppInfo', function() {
  var element, rootScope;

  beforeEach(module('14c'));

  beforeEach(function() {
    element = angular.element('<section-app-info/>');
    inject(function($rootScope, $compile) {
      rootScope = $rootScope;
      $compile(element)(rootScope);
    });
  });

  it('invoke directive', function() {
    rootScope.$digest();
    expect(element).toBeDefined();
  });
});
