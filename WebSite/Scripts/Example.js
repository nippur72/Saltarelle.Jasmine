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
	ss.initClass($JasmineTests, $asm, {
		SpecRunner1: function() {
			//
			//      describe("generic",()=>
			//
			//      {
			//
			//      it("assigments should work",()=>
			//
			//      {
			//
			//      var a=5;
			//
			//      expect(a).not.toBe(6);
			//
			//      });
			//
			//      });
		},
		SpecRunner: function() {
			describe('A suite', ss.mkdel(this, function() {
				it('contains spec with an expectation', ss.mkdel(this, function() {
					expect(true).toBe(true);
				}));
			}));
			describe('A suite is just a function', ss.mkdel(this, function() {
				var a;
				it('and so is a spec', ss.mkdel(this, function() {
					a = true;
					expect(a).toBe(true);
				}));
			}));
			describe("The 'toBe' matcher compares with ===", ss.mkdel(this, function() {
				it('and has a positive case ', ss.mkdel(this, function() {
					expect(true).toBe(true);
				}));
				it('and can have a negative case', ss.mkdel(this, function() {
					expect(false).not.toBe(true);
				}));
			}));
			describe('Included matchers:', ss.mkdel(this, function() {
				it("The 'toBe' matcher compares with ===", ss.mkdel(this, function() {
					var a1 = 12;
					var b = a1;
					expect(a1).toBe(b);
					expect(a1).not.toBe(null);
				}));
				describe("The 'toEqual' matcher", ss.mkdel(this, function() {
					it('works for simple literals and variables', ss.mkdel(this, function() {
						var a2 = 12;
						expect(a2).toEqual(12);
					}));
					it('should work for objects', ss.mkdel(this, function() {
						var foo = { a: 12, b: 34 };
						var bar = { a: 12, b: 34 };
						expect(foo).toEqual(bar);
					}));
				}));
				it("The 'toMatch' matcher is for regular expressions", ss.mkdel(this, function() {
					var message = 'foo bar baz';
					//expect(message).toMatch(/bar/);       // regex literal expressions do not exist in C#
					expect(message).toMatch('bar');
					//expect(message).not.toMatch(/quux/);  // regex literal expressions do not exist in C#
				}));
				it("The 'toBeDefined' matcher compares against `undefined`", ss.mkdel(this, function() {
					var a3 = { foo: 'foo' };
					expect(a3.foo).toBeDefined();
					expect(a3.bar).not.toBeDefined();
					// dynamic so that you can call a.bar from C# 
				}));
				it('The `toBeUndefined` matcher compares against `undefined`', ss.mkdel(this, function() {
					var a4 = { foo: 'foo' };
					expect(a4.foo).not.toBeUndefined();
					expect(a4.bar).toBeUndefined();
				}));
				it("The 'toBeNull' matcher compares against null", ss.mkdel(this, function() {
					var a5 = null;
					var foo1 = 'foo';
					expect(null).toBeNull();
					expect(a5).toBeNull();
					expect(foo1).not.toBeNull();
				}));
				it("The 'toBeTruthy' matcher is for boolean casting testing", ss.mkdel(this, function() {
					var a6 = null;
					var foo2 = 'foo';
					expect(foo2).toBeTruthy();
					expect(a6).not.toBeTruthy();
				}));
				it("The 'toBeFalsy' matcher is for boolean casting testing", ss.mkdel(this, function() {
					var a7 = null;
					var foo3 = 'foo';
					expect(a7).toBeFalsy();
					expect(foo3).not.toBeFalsy();
				}));
				it("The 'toContain' matcher is for finding an item in an Array", ss.mkdel(this, function() {
					var a8 = ['foo', 'bar', 'baz'];
					expect(a8).toContain('bar');
					expect(a8).not.toContain('quux');
				}));
				it("The 'toBeLessThan' matcher is for mathematical comparisons", ss.mkdel(this, function() {
					var pi = 3.1415926;
					var e = 2.78;
					expect(e).toBeLessThan(pi);
					expect(pi).not.toBeLessThan(e);
				}));
				it("The 'toBeGreaterThan' is for mathematical comparisons", ss.mkdel(this, function() {
					var pi1 = 3.1415926;
					var e1 = 2.78;
					expect(pi1).toBeGreaterThan(e1);
					expect(e1).not.toBeGreaterThan(pi1);
				}));
				it("The 'toBeCloseTo' matcher is for precision math comparison", ss.mkdel(this, function() {
					var pi2 = 3.1415926;
					var e2 = 2.78;
					expect(pi2).not.toBeCloseTo(e2, 2);
					expect(pi2).toBeCloseTo(e2, 0);
				}));
				it("The 'toThrow' matcher is for testing if a function throws an exception", ss.mkdel(this, function() {
					var foo4 = function() {
						return 3;
					};
					var bar1 = function() {
						throw new ss.Exception('err!');
						return 2;
					};
					expect(foo4).not.toThrow();
					expect(bar1).toThrow();
				}));
			}));
			describe('A spec', ss.mkdel(this, function() {
				it('is just a function, so it can contain any code', ss.mkdel(this, function() {
					var foo5 = 0;
					foo5 += 1;
					expect(foo5).toEqual(1);
				}));
				it('can have more than one expectation', ss.mkdel(this, function() {
					var foo6 = 0;
					foo6 += 1;
					expect(foo6).toEqual(1);
					expect(true).toEqual(true);
				}));
			}));
			describe('A spec (with setup and tear-down)', ss.mkdel(this, function() {
				var foo7 = 0;
				beforeEach(function() {
					foo7 = 0;
					foo7 += 1;
				});
				afterEach(function() {
					foo7 = 0;
				});
				it('is just a function, so it can contain any code', ss.mkdel(this, function() {
					expect(foo7).toEqual(1);
				}));
				it('can have more than one expectation', ss.mkdel(this, function() {
					expect(foo7).toEqual(1);
					expect(true).toEqual(true);
				}));
			}));
			describe('A spec', ss.mkdel(this, function() {
				var foo8 = 0;
				beforeEach(function() {
					foo8 = 0;
					foo8 += 1;
				});
				afterEach(function() {
					foo8 = 0;
				});
				it('is just a function, so it can contain any code', ss.mkdel(this, function() {
					expect(foo8).toEqual(1);
				}));
				it('can have more than one expectation', ss.mkdel(this, function() {
					expect(foo8).toEqual(1);
					expect(true).toEqual(true);
				}));
				describe('nested inside a second describe', ss.mkdel(this, function() {
					var bar2 = 0;
					beforeEach(function() {
						bar2 = 1;
					});
					it('can reference both scopes as needed ', ss.mkdel(this, function() {
						expect(foo8).toEqual(bar2);
					}));
				}));
			}));
			xdescribe('A spec', ss.mkdel(this, function() {
				var foo9 = 0;
				beforeEach(function() {
					foo9 = 0;
					foo9 += 1;
				});
				xit('is just a function, so it can contain any code', ss.mkdel(this, function() {
					expect(foo9).toEqual(1);
				}));
			}));
			// TODO object containing a function
			// describe("A spy", ()=> {
			// JsDictionary foo = new JsDictionary();
			// 
			// string bar = null;
			// 
			// beforeEach(()=> {
			// 
			// foo = new {
			// setBar = (value) => {
			// bar = value;
			// }
			// };
			// 
			// spyOn(foo, "setBar");
			// 
			// foo.setBar(123);
			// foo.setBar(456, "another param");
			// });
			// 
			// it("tracks that the spy was called", ()=> {
			// expect(foo.setBar).toHaveBeenCalled();
			// });
			// 
			// it("tracks its number of calls", ()=> {
			// expect(foo.setBar.calls.length).toEqual(2);
			// });
			// 
			// it("tracks all the arguments of its calls", ()=> {
			// expect(foo.setBar).toHaveBeenCalledWith(123);
			// expect(foo.setBar).toHaveBeenCalledWith(456, "another param");
			// });
			// 
			// it("allows access to the most recent call", ()=> {
			// expect(foo.setBar.mostRecentCall.args[0]).toEqual(456);
			// });
			// 
			// it("allows access to other calls", ()=> {
			// expect(foo.setBar.calls[0].args[0]).toEqual(123);
			// });
			// 
			// it("stops all execution on a function", ()=> {
			// expect(bar).toBeNull();
			// });
			// });
			// TODO object containing a function
			// describe("A spy, when configured to call through", ()=> {
			// var foo, bar, fetchedBar;
			// 
			// beforeEach(()=> {
			// foo = {
			// setBar: function(value) {
			// bar = value;
			// },
			// getBar: ()=> {
			// return bar;
			// }
			// };
			// 
			// spyOn(foo, "getBar").andCallThrough();
			// 
			// foo.setBar(123);
			// fetchedBar = foo.getBar();
			// });
			// 
			// it("tracks that the spy was called", ()=> {
			// expect(foo.getBar).toHaveBeenCalled();
			// });
			// 
			// it("should not effect other functions", ()=> {
			// expect(bar).toEqual(123);
			// });
			// 
			// it("when called returns the requested value", ()=> {
			// expect(fetchedBar).toEqual(123);
			// });
			// });
			// TODO object containing a function
			// describe("A spy, when faking a return value", ()=> {
			// var foo, bar, fetchedBar;
			// 
			// beforeEach(()=> {
			// foo = {
			// setBar: function(value) {
			// bar = value;
			// },
			// getBar: ()=> {
			// return bar;
			// }
			// };
			// 
			// spyOn(foo, "getBar").andReturn(745);
			// 
			// foo.setBar(123);
			// fetchedBar = foo.getBar();
			// });
			// 
			// it("tracks that the spy was called", ()=> {
			// expect(foo.getBar).toHaveBeenCalled();
			// });
			// 
			// it("should not effect other functions", ()=> {
			// expect(bar).toEqual(123);
			// });
			// 
			// it("when called returns the requested value", ()=> {
			// expect(fetchedBar).toEqual(745);
			// });
			// });
			// TODO objects containing functions
			// describe("A spy, when faking a return value", ()=> {
			// JsDictionary foo = new JsDictionary();
			// dynamic bar, fetchedBar;
			// 
			// beforeEach(()=> {
			// foo = {
			// setBar: function(value) {
			// bar = value;
			// },
			// getBar: ()=> {
			// return bar;
			// }
			// };
			// 
			// spyOn(foo, "getBar").andCallFake(()=> {
			// return 1001;
			// });
			// 
			// foo.setBar(123);
			// fetchedBar = foo.getBar();
			// });
			// 
			// it("tracks that the spy was called", ()=> {
			// expect(foo.getBar).toHaveBeenCalled();
			// });
			// 
			// it("should not effect other functions", ()=> {
			// expect(bar).toEqual(123);
			// });
			// 
			// it("when called returns the requested value", ()=> {
			// expect(fetchedBar).toEqual(1001);
			// });
			// });
			describe('A spy, when created manually', ss.mkdel(this, function() {
				var whatAmI = null;
				beforeEach(ss.mkdel(this, function() {
					whatAmI = jasmine.createSpy('whatAmI');
					whatAmI('I', 'am', 'a', 'spy');
				}));
				it('is named, which helps in error reporting', ss.mkdel(this, function() {
					expect(whatAmI.identity).toEqual('whatAmI');
				}));
				it('tracks that the spy was called', ss.mkdel(this, function() {
					expect(whatAmI).toHaveBeenCalled();
				}));
				it('tracks its number of calls', ss.mkdel(this, function() {
					expect(whatAmI.calls.length).toEqual(1);
				}));
				it('tracks all the arguments of its calls', ss.mkdel(this, function() {
					expect(whatAmI).toHaveBeenCalledWith('I', 'am', 'a', 'spy');
				}));
				it('allows access to the most recent call', ss.mkdel(this, function() {
					expect(whatAmI.mostRecentCall.args[0]).toEqual('I');
				}));
			}));
			describe('Multiple spies, when created manually', ss.mkdel(this, function() {
				var tape = null;
				beforeEach(ss.mkdel(this, function() {
					tape = jasmine.createSpyObj('tape', ['play', 'pause', 'stop', 'rewind']);
					tape.play();
					tape.pause();
					tape.rewind(0);
				}));
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
			}));
			// TODO any matcher
			// describe("jasmine.any", ()=> {
			// it("matches any value", ()=> {
			// expect({}).toEqual(jasmine.any(Object));
			// expect(12).toEqual(jasmine.any(Number));
			// });
			// 
			// describe("when used with a spy", ()=> {
			// it("is useful for comparing arguments", ()=> {
			// var foo = jasmine.createSpy("foo");
			// foo(12, ()=> {
			// return true;
			// });
			// 
			// expect(foo).toHaveBeenCalledWith(jasmine.any(Number), jasmine.any(Function));
			// });
			// });
			// });
			// TODO clock
			// describe("Manually ticking the Jasmine Mock Clock", ()=> {
			// var timerCallback;
			// 
			// //
			// // It is installed with a call to `jasmine.Clock.useMock` in a spec or suite that needs to call the timer functions.
			// //
			// beforeEach(()=> {
			// timerCallback = jasmine.createSpy("timerCallback");
			// jasmine.Clock.useMock();
			// });
			// 
			// //
			// // Calls to any registered callback are triggered when the clock is ticked forward via the `jasmine.Clock.tick` function, which takes a number of milliseconds.
			// //
			// it("causes a timeout to be called synchronously", ()=> {
			// setTimeout(()=> {
			// timerCallback();
			// }, 100);
			// 
			// expect(timerCallback).not.toHaveBeenCalled();
			// 
			// jasmine.Clock.tick(101);
			// 
			// expect(timerCallback).toHaveBeenCalled();
			// });
			// 
			// it("causes an interval to be called synchronously", ()=> {
			// setInterval(()=> {
			// timerCallback();
			// }, 100);
			// 
			// expect(timerCallback).not.toHaveBeenCalled();
			// 
			// jasmine.Clock.tick(101);
			// expect(timerCallback.callCount).toEqual(1);
			// 
			// jasmine.Clock.tick(50);
			// expect(timerCallback.callCount).toEqual(1);
			// 
			// jasmine.Clock.tick(50);
			// expect(timerCallback.callCount).toEqual(2);
			// });
			// });
			describe('Asynchronous specs', ss.mkdel(this, function() {
				var value = 0;
				var flag = false;
				it('should support async execution of test preparation and exepectations', ss.mkdel(this, function() {
					runs(function() {
						flag = false;
						value = 0;
						window.setTimeout(function() {
							flag = true;
						}, 500);
					});
					waitsFor(function() {
						value++;
						return flag;
					}, 'The Value should be incremented', 750);
					runs(ss.mkdel(this, function() {
						expect(value).toBeGreaterThan(0);
					}));
				}));
			}));
		}
	}, Object);
})();
