(function() {
	'use strict';
	var $asm = {};
	global.Jasmine = global.Jasmine || {};
	ss.initAssembly($asm, 'Saltarelle.Jasmine');
	////////////////////////////////////////////////////////////////////////////////
	// jasmine
	var $jasmine = function() {
	};
	$jasmine.__typeName = 'jasmine';
	$jasmine.createSpyObj = function(baseName, methodNames) {
		return null;
	};
	global.jasmine = $jasmine;
	////////////////////////////////////////////////////////////////////////////////
	// Jasmine.Clock
	var $Jasmine_Clock = function() {
	};
	$Jasmine_Clock.__typeName = 'Jasmine.Clock';
	global.Jasmine.Clock = $Jasmine_Clock;
	////////////////////////////////////////////////////////////////////////////////
	// Jasmine.IAny
	var $Jasmine_IAny = function() {
	};
	$Jasmine_IAny.__typeName = 'Jasmine.IAny';
	global.Jasmine.IAny = $Jasmine_IAny;
	////////////////////////////////////////////////////////////////////////////////
	// Jasmine.IObjectContaining
	var $Jasmine_IObjectContaining = function() {
	};
	$Jasmine_IObjectContaining.__typeName = 'Jasmine.IObjectContaining';
	global.Jasmine.IObjectContaining = $Jasmine_IObjectContaining;
	ss.initClass($jasmine, $asm, {});
	ss.initClass($Jasmine_Clock, $asm, {});
	ss.initInterface($Jasmine_IAny, $asm, { jasmineMatches: null, jasmineToString: null });
	ss.initInterface($Jasmine_IObjectContaining, $asm, { jasmineMatches: null, jasmineToString: null });
})();
