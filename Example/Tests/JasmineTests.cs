using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;

using Jasmine;

public class JasmineTests : JasmineSuite
{
   public void SpecRunner1()
   {
      /*
      describe("generic",()=>
      {
         it("assigments should work",()=>
         {
            var a=5;
            expect(a).not.toBe(6);
         });   
      });    
      */
   }

   public void SpecRunner()
   {

/**
 Jasmine is a behavior-driven development framework for testing JavaScript code. It does not depend on any other JavaScript frameworks. It does not require a DOM. And it has a clean, obvious syntax so that you can easily write tests.

 This guide is running against Jasmine version <span class="version">FILLED IN AT RUNTIME</span>.
 */

/**
 ## Suites: `describe` Your Tests

 A test suite begins with a call to the global Jasmine function `describe` with two parameters: a string and a function. The string is a name or title for a spec suite - usually what is under test. The function is a block of code that implements the suite.

 ## Specs

 Specs are defined by calling the global Jasmine function `it`, which, like `describe` takes a string and a function. The string is a title for this spec and the function is the spec, or test. A spec contains one or more expectations that test the state of the code under test.

 An expectation in Jasmine is an assertion that can be either true or false. A spec with all true expectations is a passing spec. A spec with one or more expectations that evaluate to false is a failing spec.
 */
describe("A suite", ()=> {
  it("contains spec with an expectation", ()=> {
    expect(true).toBe(true);
  });
});

/**
 ### It's Just Functions

 Since `describe` and `it` blocks are functions, they can contain any executable code necessary to implement the test. JavaScript scoping rules apply, so variables declared in a `describe` are available to any `it` block inside the suite.
 */
describe("A suite is just a function", ()=> {
  bool a;   

  it("and so is a spec", ()=> {
    a = true;

    expect(a).toBe(true);
  });
});

/**
 ## Expectations

 Expectations are built with the function `expect` which takes a value, called the actual. It is chained with a Matcher function, which takes the expected value.
 */
describe("The 'toBe' matcher compares with ===", ()=> {
  /**
   ### Matchers

   Each matcher implements a boolean comparison between the actual value and the expected value. It is responsible for reporting to Jasmine if the expectation is true or false. Jasmine will then pass or fail the spec.
   */

  it("and has a positive case ", ()=> {
    expect(true).toBe(true);
  });

  /**
   Any matcher can evaluate to a negative assertion by chaining the call to `expect` with a `not` before calling the matcher.

   */

  it("and can have a negative case", ()=> {
    expect(false).not.toBe(true);
  });
});

/**
 ### Included Matchers

 Jasmine has a rich set of matchers included. Each is used here - all expectations and specs pass.

 There is also the ability to write [custom matchers](https://github.com/pivotal/jasmine/wiki/Matchers) for when a project's domain calls for specific assertions that are not included below.
 */

describe("Included matchers:", ()=> {

  it("The 'toBe' matcher compares with ===", ()=> {
    var a = 12;
    var b = a;

    expect(a).toBe(b);
    expect(a).not.toBe(null);
  });

  describe("The 'toEqual' matcher", ()=> {

    it("works for simple literals and variables", ()=> {
      var a = 12;
      expect(a).toEqual(12);
    });

    it("should work for objects", ()=> {
      var foo = new {
        a=12,
        b=34
      };
      var bar = new {
        a=12,
        b=34
      };
      expect(foo).toEqual(bar);
    });
  });

  it("The 'toMatch' matcher is for regular expressions", ()=> {
    var message = "foo bar baz";

    //expect(message).toMatch(/bar/);       // regex literal expressions do not exist in C#
    expect(message).toMatch("bar");
    //expect(message).not.toMatch(/quux/);  // regex literal expressions do not exist in C#
  });

  it("The 'toBeDefined' matcher compares against `undefined`", ()=> {
    var a = new {
      foo = "foo"
    };

    expect(a.foo).toBeDefined();
    expect(((dynamic)a).bar).not.toBeDefined();    // dynamic so that you can call a.bar from C# 
  });

  it("The `toBeUndefined` matcher compares against `undefined`", ()=> {
    var a = new {
      foo="foo"
    };

    expect(a.foo).not.toBeUndefined();
    expect(((dynamic)a).bar).toBeUndefined();
  });

  it("The 'toBeNull' matcher compares against null", ()=> {
    string a = null;
    var foo = "foo";

    expect(null).toBeNull();
    expect(a).toBeNull();
    expect(foo).not.toBeNull();
  });

  it("The 'toBeTruthy' matcher is for boolean casting testing", ()=> {
    string a = null;
    var foo = "foo";

    expect(foo).toBeTruthy();
    expect(a).not.toBeTruthy();
  });

  it("The 'toBeFalsy' matcher is for boolean casting testing", ()=> {
    string a = null;
    var foo = "foo";

    expect(a).toBeFalsy();
    expect(foo).not.toBeFalsy();
  });

  it("The 'toContain' matcher is for finding an item in an Array", ()=> {
    var a = new string[] {"foo", "bar", "baz"};

    expect(a).toContain("bar");
    expect(a).not.toContain("quux");
  });

  it("The 'toBeLessThan' matcher is for mathematical comparisons", ()=> {
    var pi = 3.1415926;
    var e = 2.78;

    expect(e).toBeLessThan(pi);
    expect(pi).not.toBeLessThan(e);
  });

  it("The 'toBeGreaterThan' is for mathematical comparisons", ()=> {
    var pi = 3.1415926;
    var e = 2.78;

    expect(pi).toBeGreaterThan(e);
    expect(e).not.toBeGreaterThan(pi);
  });

  it("The 'toBeCloseTo' matcher is for precision math comparison", ()=> {
    var pi = 3.1415926;
    var e = 2.78;

    expect(pi).not.toBeCloseTo(e, 2);
    expect(pi).toBeCloseTo(e, 0);
  });

  it("The 'toThrow' matcher is for testing if a function throws an exception", ()=> {
    Func<int> foo = ()=> {
      return 1 + 2;
    };
    Func<int> bar = ()=> {
      throw new Exception("err!");
      return 1 + 1;
    };

    expect(foo).not.toThrow();
    expect(bar).toThrow();
  });
});

/**
 ## Grouping Related Specs with `describe`

 The `describe` function is for grouping related specs. The string parameter is for naming the collection of specs, and will be concatenated with specs to make a spec's full name. This aids in finding specs in a large suite. If you name them well, your specs read as full sentences in traditional [BDD][bdd] style.

 [bdd]: http://en.wikipedia.org/wiki/Behavior-driven_development
 */
describe("A spec", ()=> {
  it("is just a function, so it can contain any code", ()=> {
    var foo = 0;
    foo += 1;

    expect(foo).toEqual(1);
  });

  it("can have more than one expectation", ()=> {
    var foo = 0;
    foo += 1;

    expect(foo).toEqual(1);
    expect(true).toEqual(true);
  });
});

/**
 ### Setup and Teardown

 To help a test suite DRY up any duplicated setup and teardown code, Jasmine provides the global `beforeEach` and `afterEach` functions. As the name implies the `beforeEach` function is called once before each spec in the `describe` is run and the `afterEach` function is called once after each spec.

 Here is the same set of specs written a little differently. The variable under test is defined at the top-level scope -- the `describe` block --  and initialization code is moved into a `beforeEach` function. The `afterEach` function resets the variable before continuing.

 */

describe("A spec (with setup and tear-down)", ()=> {
  int foo = 0;

  beforeEach(()=> {
    foo = 0;
    foo += 1;
  });

  afterEach(()=> {
    foo = 0;
  });

  it("is just a function, so it can contain any code", ()=> {
    expect(foo).toEqual(1);
  });

  it("can have more than one expectation", ()=> {
    expect(foo).toEqual(1);
    expect(true).toEqual(true);
  });
});

/**
 ### Nesting `describe` Blocks

 Calls to `describe` can be nested, with specs defined at any level. This allows a suite to be composed as a tree of functions. Before a spec is executed, Jasmine walks down the tree executing each `beforeEach` function in order. After the spec is executed, Jasmine walks through the `afterEach` functions similarly.

 */
describe("A spec", ()=> {
  int foo = 0;

  beforeEach(()=> {
    foo = 0;
    foo += 1;
  });

  afterEach(()=> {
    foo = 0;
  });

  it("is just a function, so it can contain any code", ()=> {
    expect(foo).toEqual(1);
  });

  it("can have more than one expectation", ()=> {
    expect(foo).toEqual(1);
    expect(true).toEqual(true);
  });

  describe("nested inside a second describe", ()=> {
    int bar = 0;

    beforeEach(()=> {
      bar = 1;
    });

    it("can reference both scopes as needed ", ()=> {
      expect(foo).toEqual(bar);
    });
  });
});

/**
 ## Disabling Specs and Suites

 Suites and specs can be disabled with the `xdescribe` and `xit` functions, respectively. These suites and specs are skipped when run and thus their results will not appear in the results.

 */
xdescribe("A spec", ()=> {
  int foo = 0;

  beforeEach(()=> {
    foo = 0;
    foo += 1;
  });

  xit("is just a function, so it can contain any code", ()=> {
    expect(foo).toEqual(1);
  });
});

/**
 ## Spies

 Jasmine's test doubles are called spies. A spy can stub any function and tracks calls to it and all arguments. There are special matchers for interacting with spies.

 The `toHaveBeenCalled` matcher will return true if the spy was called. The `toHaveBeenCalledWith` matcher will return true if the argument list matches any of the recorded calls to the spy.
 */

/* TODO object containing a function
describe("A spy", ()=> {
  JsDictionary foo = new JsDictionary();

  string bar = null;  

  beforeEach(()=> {
 
    foo = new {
      setBar = (value) => {
        bar = value;
      }
    };

    spyOn(foo, "setBar");

    foo.setBar(123);
    foo.setBar(456, "another param");
  });

  it("tracks that the spy was called", ()=> {
    expect(foo.setBar).toHaveBeenCalled();
  });

  it("tracks its number of calls", ()=> {
    expect(foo.setBar.calls.length).toEqual(2);
  });

  it("tracks all the arguments of its calls", ()=> {
    expect(foo.setBar).toHaveBeenCalledWith(123);
    expect(foo.setBar).toHaveBeenCalledWith(456, "another param");
  });

  it("allows access to the most recent call", ()=> {
    expect(foo.setBar.mostRecentCall.args[0]).toEqual(456);
  });

  it("allows access to other calls", ()=> {
    expect(foo.setBar.calls[0].args[0]).toEqual(123);
  });

  it("stops all execution on a function", ()=> {
    expect(bar).toBeNull();
  });
});
*/

/**
 ### Spies: `andCallThrough`

 By chaining the spy with `andCallThrough`, the spy will still track all calls to it but in addition it will delegate to the actual implementation.
 */

/* TODO object containing a function
describe("A spy, when configured to call through", ()=> {
  var foo, bar, fetchedBar;

  beforeEach(()=> {
    foo = {
      setBar: function(value) {
        bar = value;
      },
      getBar: ()=> {
        return bar;
      }
    };

    spyOn(foo, "getBar").andCallThrough();

    foo.setBar(123);
    fetchedBar = foo.getBar();
  });

  it("tracks that the spy was called", ()=> {
    expect(foo.getBar).toHaveBeenCalled();
  });

  it("should not effect other functions", ()=> {
    expect(bar).toEqual(123);
  });

  it("when called returns the requested value", ()=> {
    expect(fetchedBar).toEqual(123);
  });
});
*/

/**
 ### Spies: `andReturn`

 By chaining the spy with `andReturn`, all calls to the function will return a specific value.
 */
/* TODO object containing a function
describe("A spy, when faking a return value", ()=> {
  var foo, bar, fetchedBar;

  beforeEach(()=> {
    foo = {
      setBar: function(value) {
        bar = value;
      },
      getBar: ()=> {
        return bar;
      }
    };

    spyOn(foo, "getBar").andReturn(745);

    foo.setBar(123);
    fetchedBar = foo.getBar();
  });

  it("tracks that the spy was called", ()=> {
    expect(foo.getBar).toHaveBeenCalled();
  });

  it("should not effect other functions", ()=> {
    expect(bar).toEqual(123);
  });

  it("when called returns the requested value", ()=> {
    expect(fetchedBar).toEqual(745);
  });
});
*/

/**
 ### Spies: `andCallFake`

 By chaining the spy with `andCallFake`, all calls to the spy will delegate to the supplied function.
 */
/* TODO objects containing functions
describe("A spy, when faking a return value", ()=> {
  JsDictionary foo = new JsDictionary();
  dynamic bar, fetchedBar;

  beforeEach(()=> {
    foo = {
      setBar: function(value) {
        bar = value;
      },
      getBar: ()=> {
        return bar;
      }
    };

    spyOn(foo, "getBar").andCallFake(()=> {
      return 1001;
    });

    foo.setBar(123);
    fetchedBar = foo.getBar();
  });

  it("tracks that the spy was called", ()=> {
    expect(foo.getBar).toHaveBeenCalled();
  });

  it("should not effect other functions", ()=> {
    expect(bar).toEqual(123);
  });

  it("when called returns the requested value", ()=> {
    expect(fetchedBar).toEqual(1001);
  });
});
*/

/**
 ### Spies: `createSpy`

 When there is not a function to spy on, `jasmine.createSpy` can create a "bare" spy. This spy acts as any other spy - tracking calls, arguments, etc. But there is no implementation behind it. Spies are JavaScript objects and can be used as such.

 */
describe("A spy, when created manually", ()=> {
  Spy whatAmI = null;

  beforeEach(()=> {
    whatAmI = createSpy("whatAmI");

    whatAmI.Call("I", "am", "a", "spy");
  });

  it("is named, which helps in error reporting", ()=> {
    expect(whatAmI.identity).toEqual("whatAmI");
  });

  it("tracks that the spy was called", ()=> {
    expect(whatAmI).toHaveBeenCalled();
  });

  it("tracks its number of calls", ()=> {
    expect(whatAmI.calls.Length).toEqual(1);
  });

  it("tracks all the arguments of its calls", ()=> {
    expect(whatAmI).toHaveBeenCalledWith("I", "am", "a", "spy");
  });

  it("allows access to the most recent call", ()=> {
    expect(whatAmI.mostRecentCall.args[0]).toEqual("I");
  });
});

/**
 ### Spies: `createSpyObj`

 In order to create a mock with multiple spies, use `jasmine.createSpyObj` and pass an array of strings. It returns an object that has a property for each string that is a spy.
 */
describe("Multiple spies, when created manually", ()=> {
  dynamic tape = null;

  beforeEach(()=> {
    tape = createSpyObj("tape", new string[] {"play", "pause", "stop", "rewind"});

    tape.play();
    tape.pause();
    tape.rewind(0);
  });

  it("creates spies for each requested function", ()=> {
    expect(tape.play).toBeDefined();
    expect(tape.pause).toBeDefined();
    expect(tape.stop).toBeDefined();
    expect(tape.rewind).toBeDefined();
  });

  it("tracks that the spies were called", ()=> {
    expect(tape.play).toHaveBeenCalled();
    expect(tape.pause).toHaveBeenCalled();
    expect(tape.rewind).toHaveBeenCalled();
    expect(tape.stop).not.toHaveBeenCalled();
  });

  it("tracks all the arguments of its calls", ()=> {
    expect(tape.rewind).toHaveBeenCalledWith(0);
  });
});

/**
 ## Matching Anything with `jasmine.any`

 `jasmine.any` takes a constructor or "class" name as an expected value. It returns `true` if the constructor matches the constructor of the actual value.
 */

/* TODO any matcher
describe("jasmine.any", ()=> {
  it("matches any value", ()=> {
    expect({}).toEqual(jasmine.any(Object));
    expect(12).toEqual(jasmine.any(Number));
  });

  describe("when used with a spy", ()=> {
    it("is useful for comparing arguments", ()=> {
      var foo = jasmine.createSpy("foo");
      foo(12, ()=> {
        return true;
      });

      expect(foo).toHaveBeenCalledWith(jasmine.any(Number), jasmine.any(Function));
    });
  });
});
*/

/**
 ## Mocking the JavaScript Clock

 The Jasmine Mock Clock is available for a test suites that need the ability to use `setTimeout` or `setInterval` callbacks. It makes the timer callbacks synchronous, thus making them easier to test.

 */
/* TODO clock
describe("Manually ticking the Jasmine Mock Clock", ()=> {
  var timerCallback;

  //
  // It is installed with a call to `jasmine.Clock.useMock` in a spec or suite that needs to call the timer functions.
  //
  beforeEach(()=> {
    timerCallback = jasmine.createSpy("timerCallback");
    jasmine.Clock.useMock();
  });

  //
  // Calls to any registered callback are triggered when the clock is ticked forward via the `jasmine.Clock.tick` function, which takes a number of milliseconds.
  //
  it("causes a timeout to be called synchronously", ()=> {
    setTimeout(()=> {
      timerCallback();
    }, 100);

    expect(timerCallback).not.toHaveBeenCalled();

    jasmine.Clock.tick(101);

    expect(timerCallback).toHaveBeenCalled();
  });

  it("causes an interval to be called synchronously", ()=> {
    setInterval(()=> {
      timerCallback();
    }, 100);

    expect(timerCallback).not.toHaveBeenCalled();

    jasmine.Clock.tick(101);
    expect(timerCallback.callCount).toEqual(1);

    jasmine.Clock.tick(50);
    expect(timerCallback.callCount).toEqual(1);

    jasmine.Clock.tick(50);
    expect(timerCallback.callCount).toEqual(2);
  });
});
*/

/**
 ## Asynchronous Support

 Jasmine also has support for running specs that require testing asynchronous operations.

 */
 /* TODO async
describe("Asynchronous specs", ()=> {
  var value, flag;

  it("should support async execution of test preparation and exepectations", ()=> {

    /**
     Specs are written by defining a set of blocks with calls to `runs`, which usually finish with an asynchronous call.
     /
    runs(()=> {
      flag = false;
      value = 0;

      setTimeout(()=> {
        flag = true;
      }, 500);
    });

    /**
     The `waitsFor` block takes a latch function, a failure message, and a timeout.

     The latch function polls until it returns true or the timeout expires, whichever comes first. If the timeout expires, the spec fails with the error message.
     /
    waitsFor(()=> {
      value++;
      return flag;
    }, "The Value should be incremented", 750);

    /**
     Once the asynchronous conditions have been met, another `runs` block defines final test behavior. This is usually expectations based on state after the asynch call returns.
     /
    runs(()=> {
      expect(value).toBeGreaterThan(0);
    });
  });
});

*/

   }
}



