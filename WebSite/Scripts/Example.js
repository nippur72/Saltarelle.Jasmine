(function() {
	'use strict';
	var $asm = {};
	ss.initAssembly($asm, 'Example');
	////////////////////////////////////////////////////////////////////////////////
	// JasmineTests
	var $JasmineTests = function() {
		ss.shallowCopy({}, this);
	};
	$JasmineTests.__typeName = 'JasmineTests';
	global.JasmineTests = $JasmineTests;
	////////////////////////////////////////////////////////////////////////////////
	// JasmineTests.MatcherResult
	var $JasmineTests$MatcherResult = function(pass, message) {
		this.pass = false;
		this.message = null;
		this.pass = pass;
		this.message = message;
	};
	$JasmineTests$MatcherResult.__typeName = 'JasmineTests$MatcherResult';
	global.JasmineTests$MatcherResult = $JasmineTests$MatcherResult;
	////////////////////////////////////////////////////////////////////////////////
	// JasmineTests.ToBeDivisibleBy
	var $JasmineTests$ToBeDivisibleBy = function(util, customEqualityTesters) {
		$JasmineTests$ToBeDivisibleBy.Util = util;
		$JasmineTests$ToBeDivisibleBy.CustomEqualityTesters = customEqualityTesters;
	};
	$JasmineTests$ToBeDivisibleBy.__typeName = 'JasmineTests$ToBeDivisibleBy';
	global.JasmineTests$ToBeDivisibleBy = $JasmineTests$ToBeDivisibleBy;
	////////////////////////////////////////////////////////////////////////////////
	// JasmineTests.ToBeGoofy
	var $JasmineTests$ToBeGoofy = function(util, customEqualityTesters) {
		$JasmineTests$ToBeGoofy.Util = util;
		$JasmineTests$ToBeGoofy.CustomEqualityTesters = customEqualityTesters;
	};
	$JasmineTests$ToBeGoofy.__typeName = 'JasmineTests$ToBeGoofy';
	global.JasmineTests$ToBeGoofy = $JasmineTests$ToBeGoofy;
	////////////////////////////////////////////////////////////////////////////////
	// MatcherExtensions
	var $MatcherExtensions = function() {
	};
	$MatcherExtensions.__typeName = 'MatcherExtensions';
	global.MatcherExtensions = $MatcherExtensions;
	////////////////////////////////////////////////////////////////////////////////
	// newReporter
	var $newReporter = function() {
	};
	$newReporter.__typeName = 'newReporter';
	global.newReporter = $newReporter;
	ss.initClass($JasmineTests, $asm, {
		SpecRunner1: function() {
			//
			//        describe("generic",()=>
			//
			//        {
			//
			//        it("assigments should work",()=>
			//
			//        {
			//
			//        var a=5;
			//
			//        expect(a).not.toBe(6);
			//
			//        });
			//
			//        });
		},
		SpecRunner: function() {
			describe('A suite', function() {
				it('contains spec with an expectation', function() {
					expect(true).toBe(true);
				});
			});
			describe('A suite is just a function', function() {
				var a;
				it('and so is a spec', function() {
					a = true;
					expect(a).toBe(true);
				});
			});
			describe("The 'toBe' matcher compares with ===", function() {
				it('and has a positive case ', function() {
					expect(true).toBe(true);
				});
				it('and can have a negative case', function() {
					expect(false).not.toBe(true);
				});
			});
			describe('Included matchers:', function() {
				it("The 'toBe' matcher compares with ===", function() {
					var a1 = 12;
					var b = a1;
					expect(a1).toBe(b);
					expect(a1).not.toBe(null);
				});
				describe("The 'toEqual' matcher", function() {
					it('works for simple literals and variables', function() {
						var a2 = 12;
						expect(a2).toEqual(12);
					});
					it('should work for objects', function() {
						var foo = {};
						var bar = {};
						foo['a'] = 12;
						foo['b'] = 34;
						bar['a'] = 12;
						bar['b'] = 34;
						expect(foo).toEqual(bar);
					});
				});
				it("The 'toMatch' matcher is for regular expressions", function() {
					var message = 'foo bar baz';
					//expect(message).toMatch(/bar/);       // regex literal expressions do not exist in C#
					expect(message).toMatch('bar');
					//expect(message).not.toMatch(/quux/);  // regex literal expressions do not exist in C#
				});
				it("The 'toBeDefined' matcher compares against `undefined`", function() {
					var a3 = {};
					a3['foo'] = 'foo';
					expect(a3['foo']).toBeDefined();
					expect(a3.bar).not.toBeDefined();
					// dynamic so that you can call a.bar from C#
				});
				it('The `toBeUndefined` matcher compares against `undefined`', function() {
					var a4 = {};
					a4['foo'] = 'foo';
					expect(a4['foo']).not.toBeUndefined();
					expect(a4.bar).toBeUndefined();
				});
				it("The 'toBeNull' matcher compares against null", function() {
					var a5 = null;
					var foo1 = 'foo';
					expect(null).toBeNull();
					expect(a5).toBeNull();
					expect(foo1).not.toBeNull();
				});
				it("The 'toBeTruthy' matcher is for boolean casting testing", function() {
					var a6 = null;
					var foo2 = 'foo';
					expect(foo2).toBeTruthy();
					expect(a6).not.toBeTruthy();
				});
				it("The 'toBeFalsy' matcher is for boolean casting testing", function() {
					var a7 = null;
					var foo3 = 'foo';
					expect(a7).toBeFalsy();
					expect(foo3).not.toBeFalsy();
				});
				it("The 'toContain' matcher is for finding an item in an Array", function() {
					var a8 = ['foo', 'bar', 'baz'];
					expect(a8).toContain('bar');
					expect(a8).not.toContain('quux');
				});
				it("The 'toBeLessThan' matcher is for mathematical comparisons", function() {
					var pi = 3.1415926;
					var e = 2.78;
					expect(e).toBeLessThan(pi);
					expect(pi).not.toBeLessThan(e);
				});
				it("The 'toBeGreaterThan' is for mathematical comparisons", function() {
					var pi1 = 3.1415926;
					var e1 = 2.78;
					expect(pi1).toBeGreaterThan(e1);
					expect(e1).not.toBeGreaterThan(pi1);
				});
				it("The 'toBeCloseTo' matcher is for precision math comparison", function() {
					var pi2 = 3.1415926;
					var e2 = 2.78;
					expect(pi2).not.toBeCloseTo(e2, 2);
					expect(pi2).toBeCloseTo(e2, 0);
				});
				it("The 'toThrow' matcher is for testing if a function throws an exception", function() {
					var foo4 = function() {
						return 3;
					};
					var bar1 = function() {
						throw new ss.Exception('err!');
						return 2;
					};
					expect(foo4).not.toThrow();
					expect(bar1).toThrow();
				});
			});
			describe('A spec', function() {
				it('is just a function, so it can contain any code', function() {
					var foo5 = 0;
					foo5 += 1;
					expect(foo5).toEqual(1);
				});
				it('can have more than one expectation', function() {
					var foo6 = 0;
					foo6 += 1;
					expect(foo6).toEqual(1);
					expect(true).toEqual(true);
				});
			});
			describe('A spec (with setup and tear-down)', function() {
				var foo7 = 0;
				beforeEach(function() {
					foo7 = 0;
					foo7 += 1;
				});
				afterEach(function() {
					foo7 = 0;
				});
				it('is just a function, so it can contain any code', function() {
					expect(foo7).toEqual(1);
				});
				it('can have more than one expectation', function() {
					expect(foo7).toEqual(1);
					expect(true).toEqual(true);
				});
			});
			describe('A spec', function() {
				var foo8 = 0;
				beforeEach(function() {
					foo8 = 0;
					foo8 += 1;
				});
				afterEach(function() {
					foo8 = 0;
				});
				it('is just a function, so it can contain any code', function() {
					expect(foo8).toEqual(1);
				});
				it('can have more than one expectation', function() {
					expect(foo8).toEqual(1);
					expect(true).toEqual(true);
				});
				describe('nested inside a second describe', function() {
					var bar2 = 0;
					beforeEach(function() {
						bar2 = 1;
					});
					it('can reference both scopes as needed ', function() {
						expect(foo8).toEqual(bar2);
					});
				});
			});
			xdescribe('A spec', function() {
				var foo9 = 0;
				beforeEach(function() {
					foo9 = 0;
					foo9 += 1;
				});
				xit('is just a function, so it can contain any code', function() {
					expect(foo9).toEqual(1);
				});
			});
			//TODO: Pending() doesn't work in PhantomJS
			//describe("Pending specs", () =>
			//{
			//    /** Any spec declared with `xit` is marked as pending.
			//     */
			//    xit("can be declared 'xit'", () =>
			//    {
			//        expect(true).toBe(false);
			//    });
			//    /** Any spec declared without a function body will also be marked pending in results.
			//     */
			//    it("can be declared with 'it' but without a function");
			//    /** And if you call the function `pending` anywhere in the spec body, no matter the expectations, the spec will be marked pending.
			//     */
			//    it("can be declared by calling 'pending' in the spec body", () =>
			//    {
			//        expect(true).toBe(false);
			//        pending();
			//    });
			//});
			// TODO object containing a function
			describe('A spy', function() {
				var foo10 = {};
				foo10['setBar'] = null;
				var bar3 = null;
				var spy = null;
				beforeEach(function() {
					foo10['setBar'] = function(value) {
						bar3 = value;
					};
					spy = spyOn(foo10, 'setBar');
					foo10['setBar']('123');
					foo10['setBar']('456');
				});
				it('tracks that the spy was called', function() {
					expect(foo10['setBar']).toHaveBeenCalled();
				});
				it('tracks its number of calls', function() {
					expect(spy.calls.count()).toEqual(2);
				});
				it('tracks all the arguments of its calls', function() {
					expect(spy).toHaveBeenCalledWith('123');
				});
				it('allows access to the most recent call', function() {
					expect(spy.calls.mostRecent().args[0]).toEqual('456');
				});
				it('allows access to other calls', function() {
					expect(spy.calls.all()[0].args[0]).toEqual('123');
				});
				it('stops all execution on a function', function() {
					expect(bar3).toBeNull();
				});
			});
			// TODO object containing a function
			describe('A spy, when configured to call through', function() {
				var foo11 = {};
				foo11['setBar'] = null;
				foo11['getBar'] = null;
				var bar4 = null;
				var fetchedBar = null;
				var spy1 = null;
				beforeEach(function() {
					foo11['setBar'] = function(value1) {
						bar4 = value1;
					};
					foo11['getBar'] = function() {
						return bar4;
					};
					spy1 = spyOn(foo11, 'getBar').and.callThrough();
					ss.cast(foo11['setBar'], Function)('123');
					fetchedBar = ss.cast(foo11['getBar'], Function)();
				});
				it('tracks that the spy was called', function() {
					expect(spy1).toHaveBeenCalled();
				});
				it('should not effect other functions', function() {
					expect(bar4).toEqual('123');
				});
				it('when called returns the requested value', function() {
					expect(fetchedBar).toEqual('123');
				});
			});
			// TODO object containing a function
			describe('A spy, when faking a return value', function() {
				var foo12 = {};
				foo12['setBar'] = null;
				foo12['getBar'] = null;
				var bar5 = null;
				var fetchedBar1 = null;
				var spy2 = null;
				beforeEach(function() {
					foo12['setBar'] = function(value2) {
						bar5 = value2;
					};
					foo12['getBar'] = function() {
						return bar5;
					};
					spy2 = spyOn(foo12, 'getBar').and.returnValue('745');
					ss.cast(foo12['setBar'], Function)('123');
					fetchedBar1 = ss.cast(foo12['getBar'], Function)();
				});
				it('tracks that the spy was called', function() {
					expect(spy2).toHaveBeenCalled();
				});
				it('should not effect other functions', function() {
					expect(bar5).toEqual('123');
				});
				it('when called returns the requested value', function() {
					expect(fetchedBar1).toEqual('745');
				});
			});
			// TODO objects containing functions
			describe('A spy, when faking a function', function() {
				var foo13 = {};
				foo13['setBar'] = null;
				foo13['getBar'] = null;
				var bar6 = null;
				var fetchedBar2 = null;
				var spy3 = null;
				beforeEach(function() {
					foo13['setBar'] = function(value3) {
						bar6 = value3;
					};
					foo13['getBar'] = function() {
						return bar6;
					};
					spy3 = spyOn(foo13, 'getBar').and.callFake(function() {
						return '1001';
					});
					ss.cast(foo13['setBar'], Function)('123');
					fetchedBar2 = ss.cast(foo13['getBar'], Function)();
				});
				it('tracks that the spy was called', function() {
					expect(spy3).toHaveBeenCalled();
				});
				it('should not effect other functions', function() {
					expect(bar6).toEqual('123');
				});
				it('when called returns the requested value', function() {
					expect(fetchedBar2).toEqual('1001');
				});
			});
			describe('A spy, when configured to throw an error', function() {
				var foo14 = {};
				foo14['setBar'] = null;
				var bar7 = null;
				beforeEach(function() {
					foo14['setBar'] = function(value4) {
						bar7 = value4;
					};
					spyOn(foo14, 'setBar').and.throwError('quux');
				});
				it('throws the value', function() {
					expect(function() {
						foo14['setBar']('123');
					}).toThrowError('quux');
				});
			});
			describe('A spy', function() {
				var foo15 = {};
				foo15['setBar'] = null;
				var bar8 = null;
				var spy4 = null;
				beforeEach(function() {
					foo15['setBar'] = function(value5) {
						bar8 = value5;
					};
					spy4 = spyOn(foo15, 'setBar').and.callThrough();
				});
				it('can call through and then stub in the same spec', function() {
					foo15['setBar'](123);
					expect(bar8).toEqual(123);
					spy4.and.stub();
					bar8 = null;
					foo15['setBar'](123);
					expect(bar8).toBe(null);
				});
			});
			describe('A spy', function() {
				var foo16 = {};
				foo16['setBar'] = null;
				var bar9 = null;
				var fooSetBar = null;
				beforeEach(function() {
					foo16['setBar'] = function(value6) {
						bar9 = value6;
					};
					fooSetBar = spyOn(foo16, 'setBar');
				});
				it('tracks if it was called at all', function() {
					expect(fooSetBar.calls.any()).toEqual(false);
					foo16['setBar'](0);
					expect(fooSetBar.calls.any()).toEqual(true);
				});
				it('tracks the number of times it was called', function() {
					expect(fooSetBar.calls.count()).toEqual(0);
					foo16['setBar'](0);
					foo16['setBar'](0);
					expect(fooSetBar.calls.count()).toEqual(2);
				});
				it('tracks the arguments of each call', function() {
					foo16['setBar'](123);
					foo16['setBar'](456);
					expect(fooSetBar.calls.argsFor(0)).toEqual([123]);
					expect(fooSetBar.calls.argsFor(1)).toEqual([456]);
				});
				it('tracks the arguments of all calls', function() {
					foo16['setBar'](123);
					foo16['setBar'](456);
					expect(fooSetBar.calls.allArgs()).toEqual([[123], [456]]);
				});
				it('can provide the context and arguments to all calls', function() {
					foo16['setBar'](123);
					expect(fooSetBar.calls.all()).toEqual([{ object: foo16, args: [123], returnValue: undefined }]);
				});
				it('has a shortcut to the most recent call', function() {
					foo16['setBar'](123);
					foo16['setBar'](456);
					expect(fooSetBar.calls.mostRecent()).toEqual({ object: foo16, args: [456], returnValue: undefined });
				});
				it('has a shortcut to the first call', function() {
					foo16['setBar'](123);
					foo16['setBar'](456);
					expect(fooSetBar.calls.first()).toEqual({ object: foo16, args: [123], returnValue: undefined });
				});
				it('tracks the context', function() {
					var spy5 = jasmine.createSpy('spy');
					var baz = {};
					var quux = {};
					baz['fn'] = spy5;
					quux['fn'] = spy5;
					baz['fn'](123);
					quux['fn'](456);
					expect(spy5.calls.first().object).toBe(baz);
					expect(spy5.calls.mostRecent().object).toBe(quux);
				});
				it('can be reset', function() {
					foo16['setBar'](123);
					foo16['setBar'](456);
					expect(fooSetBar.calls.any()).toBe(true);
					fooSetBar.calls.reset();
					expect(fooSetBar.calls.any()).toBe(false);
				});
			});
			describe('A spy, when created manually', function() {
				var whatAmI = null;
				beforeEach(function() {
					whatAmI = jasmine.createSpy('whatAmI');
					whatAmI('I', 'am', 'a', 'spy');
				});
				it('is named, which helps in error reporting', function() {
					expect(whatAmI.and.identity()).toEqual('whatAmI');
				});
				it('tracks that the spy was called', function() {
					expect(whatAmI).toHaveBeenCalled();
				});
				it('tracks its number of calls', function() {
					expect(whatAmI.calls.count()).toEqual(1);
				});
				it('tracks all the arguments of its calls', function() {
					expect(whatAmI).toHaveBeenCalledWith('I', 'am', 'a', 'spy');
				});
				it('allows access to the most recent call', function() {
					expect(whatAmI.calls.mostRecent().args[0]).toEqual('I');
				});
			});
			describe('Multiple spies, when created manually', function() {
				var tape = null;
				beforeEach(function() {
					tape = jasmine.createSpyObj('tape', ['play', 'pause', 'stop', 'rewind']);
					tape.play();
					tape.pause();
					tape.rewind(0);
				});
				it('creates spies for each requested function', function() {
					expect(tape.play).toBeDefined();
					expect(tape.pause).toBeDefined();
					expect(tape.stop).toBeDefined();
					expect(tape.rewind).toBeDefined();
				});
				it('tracks that the spies were called', function() {
					expect(tape.play).toHaveBeenCalled();
					expect(tape.pause).toHaveBeenCalled();
					expect(tape.rewind).toHaveBeenCalled();
					expect(tape.stop).not.toHaveBeenCalled();
				});
				it('tracks all the arguments of its calls', function() {
					expect(tape.rewind).toHaveBeenCalledWith(0);
				});
			});
			// TODO any matcher
			describe('jasmine.any', function() {
				it('matches any value', function() {
					expect(null).toEqual(jasmine.any(Object));
					expect(12).toEqual(jasmine.any(Number));
				});
				describe('when used with a spy', function() {
					it('is useful for comparing arguments', function() {
						var foo17 = jasmine.createSpy('foo');
						foo17(12, function() {
							return true;
						});
						expect(foo17).toHaveBeenCalledWith(jasmine.any(Number), jasmine.any(Function));
					});
				});
			});
			describe('jasmine.objectContaining', function() {
				var foo18 = {};
				foo18['a'] = 0;
				foo18['b'] = 0;
				foo18['bar'] = '';
				beforeEach(function() {
					foo18['a'] = 1;
					foo18['b'] = 2;
					foo18['bar'] = 'baz';
				});
				it('matches objects with the expect key/value pairs', function() {
					expect(foo18).toEqual(jasmine.objectContaining({ bar: 'baz' }));
					expect(foo18).not.toEqual(jasmine.objectContaining({ c: 37 }));
				});
				describe('when used with a spy', function() {
					it('is useful for comparing arguments', function() {
						var callback = jasmine.createSpy('callback');
						callback({ bar: 'baz' });
						expect(callback).toHaveBeenCalledWith(jasmine.objectContaining({ bar: 'baz' }));
						expect(callback).not.toHaveBeenCalledWith(jasmine.objectContaining({ c: 37 }));
					});
				});
			});
			// TODO clock
			describe('Manually ticking the Jasmine Mock Clock', function() {
				var timerCallback = null;
				//
				// It is installed with a call to `jasmine.Clock.useMock` in a spec or suite that needs to call the timer functions.
				//
				beforeEach(function() {
					timerCallback = jasmine.createSpy('timerCallback');
					jasmine.clock().install();
				});
				afterEach(function() {
					timerCallback = jasmine.createSpy('timerCallback');
					jasmine.clock().uninstall();
				});
				//
				// Calls to any registered callback are triggered when the clock is ticked forward via the `jasmine.Clock.tick` function, which takes a number of milliseconds.
				//
				it('causes a timeout to be called synchronously', function() {
					window.setTimeout(function() {
						timerCallback();
					}, 100);
					expect(timerCallback).not.toHaveBeenCalled();
					jasmine.clock().tick(101);
					expect(timerCallback).toHaveBeenCalled();
				});
				it('causes an interval to be called synchronously', function() {
					window.setInterval(function() {
						timerCallback();
					}, 100);
					expect(timerCallback).not.toHaveBeenCalled();
					jasmine.clock().tick(101);
					expect(timerCallback.calls.count()).toEqual(1);
					jasmine.clock().tick(50);
					expect(timerCallback.calls.count()).toEqual(1);
					jasmine.clock().tick(50);
					expect(timerCallback.calls.count()).toEqual(2);
				});
			});
			describe('Asynchronous specs', function() {
				var value7 = 0;
				beforeEach(function(done) {
					window.setTimeout(function() {
						value7 = 0;
						done();
					}, 1000);
				});
				it('should support async execution of test preparation and expectations', function(done1) {
					value7++;
					expect(value7).toBeGreaterThan(0);
					ss.Task.delay(1).continueWith(function(T) {
						value7 = 1;
						expect(value7).toBeGreaterThan(0);
						done1();
					});
				});
				describe('long asynchronous specs', function() {
					var originalTimeout = 0;
					beforeEach(function() {
						originalTimeout = jasmine.DEFAULT_TIMEOUT_INTERVAL;
						jasmine.DEFAULT_TIMEOUT_INTERVAL = 1000;
					});
					it('takes a long time', function(done2) {
						window.setTimeout(function() {
							done2();
						}, 900);
					});
					afterEach(function() {
						jasmine.DEFAULT_TIMEOUT_INTERVAL = originalTimeout;
					});
				});
			});
			var customMatchers = {};
			customMatchers['toBeGoofy'] = function(util, customEqualityTesters) {
				return new $JasmineTests$ToBeGoofy(util, customEqualityTesters);
			};
			customMatchers['toBeDivisibleBy'] = function(util1, customEqualityTesters1) {
				return new $JasmineTests$ToBeDivisibleBy(util1, customEqualityTesters1);
			};
			describe("Custom matcher: 'toBeGoofy'", function() {
				beforeEach(function() {
					jasmine.addMatchers(customMatchers);
				});
				it('is available on an expectation', function() {
					expect({ hyuk: 'gawrsh' }).toBeGoofy();
				});
				it("can take an 'expected' parameter", function() {
					expect({ hyuk: 'gawrsh is fun' }).toBeGoofy(' is fun');
				});
				it('can be negated', function() {
					expect({ hyuk: 'this is fun' }).not.toBeGoofy();
				});
			});
			describe("Custom matcher: 'toBeDivisibleBy'", function() {
				beforeEach(function() {
					jasmine.addMatchers(customMatchers);
				});
				it('is available on an expectation', function() {
					expect(7).toBeDivisibleBy(7);
				});
				it('can be negated', function() {
					expect(8).not.toBeDivisibleBy(7);
				});
			});
			describe('custom equality', function() {
				var myCustomEquality = function(first, second) {
					if (typeof(first) === 'string' && typeof(second) === 'string') {
						return first.charCodeAt(0) === second.charCodeAt(1);
					}
					return false;
				};
				beforeEach(function() {
					jasmine.addCustomEqualityTester(myCustomEquality);
				});
				it('should be custom equal', function() {
					expect('abc').toEqual('aaa');
				});
				it('should be custom not equal', function() {
					expect('abc').not.toEqual('abc');
				});
			});
			var myReporter = new $newReporter();
			jasmine.getEnv().addReporter(myReporter);
			describe('Top Level suite', function() {
				it('spec', function() {
					expect(1).toBe(1);
				});
				describe('Nested suite', function() {
					it('nested spec', function() {
						expect(true).toBe(true);
					});
				});
			});
			//describe("Focused specs", () => {
			//    /** Any spec declared with `fit` is focused.
			//     */
			//    fit("is focused and will run", () => {
			//        expect(true).toBeTruthy();
			//    });
			//    it("is not focused and will not run", () =>{
			//        expect(true).toBeFalsy();
			//    });
			//    /** You can focus on a `describe` with `fdescribe`
			//     *
			//     */
			//    fdescribe("focused describe", () =>{
			//        it("will run", () =>{
			//            expect(true).toBeTruthy();
			//        });
			//        it("will also run", () =>{
			//            expect(true).toBeTruthy();
			//        });
			//    });
			//    /** If you nest focused and unfocused specs inside `fdescribes`, only focused specs run.
			//     *
			//     */
			//    fdescribe("another focused describe", () =>{
			//        fit("is focused and will run", () => {
			//            expect(true).toBeTruthy();
			//        });
			//        it("is not focused and will not run", () =>{
			//            expect(true).toBeFalsy();
			//        });
			//    });
			//});
		}
	}, Object);
	ss.initClass($JasmineTests$MatcherResult, $asm, {});
	ss.initClass($JasmineTests$ToBeDivisibleBy, $asm, {
		compare: function(actual, expected) {
			var resultPass = false;
			var resultMessage = '';
			var matcherResult = new $JasmineTests$MatcherResult(resultPass, resultMessage);
			var actualConvert = ss.safeCast(actual, ss.Int32);
			if (ss.isValue(actualConvert)) {
				matcherResult.pass = ss.unbox(actualConvert) % expected === 0;
			}
			else {
				matcherResult.message = ss.formatString('Expected {0} to be divisble by {1}, but it was not a number', actual, expected);
				return matcherResult;
			}
			if (matcherResult.pass) {
				matcherResult.message = ss.formatString('Expected {0} not to be divisble by {1}', actual, expected);
			}
			else {
				matcherResult.message = ss.formatString('Expected {0} to be divisble by {1}', actual, expected);
			}
			return matcherResult;
		}
	});
	ss.initClass($JasmineTests$ToBeGoofy, $asm, {
		compare: function(actual, expected) {
			if (ss.referenceEquals(expected, ss.cast(undefined, String))) {
				expected = '';
			}
			var resultPass = false;
			var resultMessage = '';
			resultPass = $JasmineTests$ToBeGoofy.Util.equals(actual['hyuk'], 'gawrsh' + expected, $JasmineTests$ToBeGoofy.CustomEqualityTesters);
			if (resultPass) {
				resultMessage = ss.formatString('Expected {0} not to be quite so goofy', actual);
			}
			else {
				resultMessage = ss.formatString('Expected {0} to be goofy, but it was not very goofy', actual);
			}
			return new $JasmineTests$MatcherResult(resultPass, resultMessage);
		}
	});
	ss.initClass($MatcherExtensions, $asm, {});
	ss.initClass($newReporter, $asm, {
		jasmineStarted: function(suiteInfo) {
			console.log('Running suite with ' + suiteInfo.totalSpecsDefined);
		},
		suiteStarted: function(result) {
			console.log('Suite started: ' + result.description + ' whose full description is: ' + result.fullName);
		},
		specStarted: function(result) {
			console.log('Spec started: ' + result.description + ' whose full description is: ' + result.fullName);
		},
		specDone: function(result) {
			console.log('Spec: ' + result.description + ' was ' + result.status);
			for (var i = 0; i < result.failedExpectations.length; i++) {
				console.log('Failure: ' + result.failedExpectations[i].message);
				console.log(result.failedExpectations[i].stack);
			}
		},
		suiteDone: function(result) {
			console.log('Suite: ' + result.description + ' was ' + result.status);
			for (var i = 0; i < result.failedExpectations.length; i++) {
				console.log('AfterAll ' + result.failedExpectations[i].message);
				console.log(result.failedExpectations[i].stack);
			}
		},
		jasmineDone: function() {
			console.log('Finished suite');
		}
	});
	$JasmineTests$ToBeGoofy.Util = null;
	$JasmineTests$ToBeGoofy.CustomEqualityTesters = null;
	$JasmineTests$ToBeDivisibleBy.Util = null;
	$JasmineTests$ToBeDivisibleBy.CustomEqualityTesters = null;
})();
