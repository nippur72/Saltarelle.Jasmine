(function() {
	'use strict';
	var $asm = {};
	global.Jasmine = global.Jasmine || {};
	ss.initAssembly($asm, 'Saltarelle.Jasmine');
	////////////////////////////////////////////////////////////////////////////////
	// Jasmine.ICustomMatcherUtil
	var $Jasmine_ICustomMatcherUtil = function() {
	};
	$Jasmine_ICustomMatcherUtil.__typeName = 'Jasmine.ICustomMatcherUtil';
	global.Jasmine.ICustomMatcherUtil = $Jasmine_ICustomMatcherUtil;
	ss.initInterface($Jasmine_ICustomMatcherUtil, $asm, { buildFailureMessage: null, contains: null, equals: null });
})();
