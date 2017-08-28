'use strict';

module.exports = app => {
  let urlCtrl = require('../controllers/urlController.js');

  app.route('/api/url/:tipo/:area/:subarea')
    .get(urlCtrl.getUrl);
};
