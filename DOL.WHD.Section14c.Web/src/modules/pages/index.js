'use strict';

module.exports = function(ngModule) {
  require('./accountPageController')(ngModule);
  require('./adminDashboardController')(ngModule);
  require('./appReviewPageController')(ngModule);
  require('./changePasswordPageController')(ngModule);
  require('./dashboardController')(ngModule);
  require('./homePageController')(ngModule);
  require('./userLoginPageController')(ngModule);
  require('./userManagementPageController')(ngModule);
  require('./userRegistrationPageController')(ngModule);
  require('./forgotPasswordPageController')(ngModule);
};
