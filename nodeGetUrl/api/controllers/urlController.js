'use strict';

exports.getUrl = function(req, res) {
  res.json({
    link: `https://www.minhaurl.com.br/?curso=${req.params.tipo}&area=${req.params.area}&subarea=${req.params.subarea}`
  });
};
