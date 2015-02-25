using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Threading.Tasks;
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
        describe("A suite", () =>
        {
            it("contains spec with an expectation", () =>
            {
                expect(true).toBe(true);
            });
        });

        /**
         ### It's Just Functions

         Since `describe` and `it` blocks are functions, they can contain any executable code necessary to implement the test. JavaScript scoping rules apply, so variables declared in a `describe` are available to any `it` block inside the suite.
         */
        describe("A suite is just a function", () =>
        {
            bool a;

            it("and so is a spec", () =>
            {
                a = true;

                expect(a).toBe(true);
            });
        });

        /**
         ## Expectations

         Expectations are built with the function `expect` which takes a value, called the actual. It is chained with a Matcher function, which takes the expected value.
         */
        describe("The 'toBe' matcher compares with ===", () =>
        {
            /**
             ### Matchers

             Each matcher implements a boolean comparison between the actual value and the expected value. It is responsible for reporting to Jasmine if the expectation is true or false. Jasmine will then pass or fail the spec.
             */

            it("and has a positive case ", () =>
            {
                expect(true).toBe(true);
            });

            /**
             Any matcher can evaluate to a negative assertion by chaining the call to `expect` with a `not` before calling the matcher.

             */

            it("and can have a negative case", () =>
            {
                expect(false).not.toBe(true);
            });
        });

        /**
         ### Included Matchers

         Jasmine has a rich set of matchers included. Each is used here - all expectations and specs pass.

         There is also the ability to write [custom matchers](https://github.com/pivotal/jasmine/wiki/Matchers) for when a project's domain calls for specific assertions that are not included below.
         */

        describe("Included matchers:", () =>
        {

            it("The 'toBe' matcher compares with ===", () =>
            {
                int a = 12;
                int b = a;

                expect(a).toBe(b);
                expect(a).not.toBe(null);
            });

            describe("The 'toEqual' matcher", () =>
            {

                it("works for simple literals and variables", () =>
                {
                    int a = 12;
                    expect(a).toEqual(12);
                });

                it("should work for objects", () =>
                {
                    JsDictionary<string, int> foo = new JsDictionary<string, int>();
                    JsDictionary<string, int> bar = new JsDictionary<string, int>();
                    foo["a"] = 12;
                    foo["b"] = 34;
                    bar["a"] = 12;
                    bar["b"] = 34;
                    expect(foo).toEqual(bar);
                });
            });

            it("The 'toMatch' matcher is for regular expressions", () =>
            {
                string message = "foo bar baz";

                //expect(message).toMatch(/bar/);       // regex literal expressions do not exist in C#
                expect(message).toMatch("bar");
                //expect(message).not.toMatch(/quux/);  // regex literal expressions do not exist in C#
            });

            it("The 'toBeDefined' matcher compares against `undefined`", () =>
            {
                JsDictionary<string, string> a = new JsDictionary<string, string>();
                a["foo"] = "foo";

                expect(a["foo"]).toBeDefined();
                expect((object)((dynamic)a).bar).not.toBeDefined();    // dynamic so that you can call a.bar from C#
            });

            it("The `toBeUndefined` matcher compares against `undefined`", () =>
            {
                JsDictionary<string, string> a = new JsDictionary<string, string>();
                a["foo"] = "foo";

                expect(a["foo"]).not.toBeUndefined();
                expect((object)((dynamic)a).bar).toBeUndefined();
            });

            it("The 'toBeNull' matcher compares against null", () =>
            {
                string a = null;
                string foo = "foo";

                expect(null).toBeNull();
                expect(a).toBeNull();
                expect(foo).not.toBeNull();
            });

            it("The 'toBeTruthy' matcher is for boolean casting testing", () =>
            {
                string a = null;
                string foo = "foo";

                expect(foo).toBeTruthy();
                expect(a).not.toBeTruthy();
            });

            it("The 'toBeFalsy' matcher is for boolean casting testing", () =>
            {
                string a = null;
                string foo = "foo";

                expect(a).toBeFalsy();
                expect(foo).not.toBeFalsy();
            });

            it("The 'toContain' matcher is for finding an item in an Array", () =>
            {
                string[] a = new string[] { "foo", "bar", "baz" };

                expect(a).toContain("bar");
                expect(a).not.toContain("quux");
            });

            it("The 'toBeLessThan' matcher is for mathematical comparisons", () =>
            {
                double pi = 3.1415926;
                double e = 2.78;

                expect(e).toBeLessThan(pi);
                expect(pi).not.toBeLessThan(e);
            });

            it("The 'toBeGreaterThan' is for mathematical comparisons", () =>
            {
                double pi = 3.1415926;
                double e = 2.78;

                expect(pi).toBeGreaterThan(e);
                expect(e).not.toBeGreaterThan(pi);
            });

            it("The 'toBeCloseTo' matcher is for precision math comparison", () =>
            {
                double pi = 3.1415926;
                double e = 2.78;

                expect(pi).not.toBeCloseTo(e, 2);
                expect(pi).toBeCloseTo(e, 0);
            });

            it("The 'toThrow' matcher is for testing if a function throws an exception", () =>
            {
                Func<int> foo = () =>
                {
                    return 1 + 2;
                };
                Func<int> bar = () =>
                {
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
        describe("A spec", () =>
        {
            it("is just a function, so it can contain any code", () =>
            {
                int foo = 0;
                foo += 1;

                expect(foo).toEqual(1);
            });

            it("can have more than one expectation", () =>
            {
                int foo = 0;
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

        describe("A spec (with setup and tear-down)", () =>
        {
            int foo = 0;

            beforeEach(() =>
            {
                foo = 0;
                foo += 1;
            });

            afterEach(() =>
            {
                foo = 0;
            });

            it("is just a function, so it can contain any code", () =>
            {
                expect(foo).toEqual(1);
            });

            it("can have more than one expectation", () =>
            {
                expect(foo).toEqual(1);
                expect(true).toEqual(true);
            });
        });

        /**
         ### Nesting `describe` Blocks

         Calls to `describe` can be nested, with specs defined at any level. This allows a suite to be composed as a tree of functions. Before a spec is executed, Jasmine walks down the tree executing each `beforeEach` function in order. After the spec is executed, Jasmine walks through the `afterEach` functions similarly.

         */
        describe("A spec", () =>
        {
            int foo = 0;

            beforeEach(() =>
            {
                foo = 0;
                foo += 1;
            });

            afterEach(() =>
            {
                foo = 0;
            });

            it("is just a function, so it can contain any code", () =>
            {
                expect(foo).toEqual(1);
            });

            it("can have more than one expectation", () =>
            {
                expect(foo).toEqual(1);
                expect(true).toEqual(true);
            });

            describe("nested inside a second describe", () =>
            {
                int bar = 0;

                beforeEach(() =>
                {
                    bar = 1;
                });

                it("can reference both scopes as needed ", () =>
                {
                    expect(foo).toEqual(bar);
                });
            });
        });

        /**
         ## Disabling Specs and Suites

         Suites and specs can be disabled with the `xdescribe` and `xit` functions, respectively. These suites and specs are skipped when run and thus their results will not appear in the results.

         */
        xdescribe("A spec", () =>
        {
            int foo = 0;

            beforeEach(() =>
            {
                foo = 0;
                foo += 1;
            });

            xit("is just a function, so it can contain any code", () =>
            {
                expect(foo).toEqual(1);
            });
        });

        /**
        ## Pending Specs
        Pending specs do not run, but their names will show up in the results as `pending`.
        */
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

        /**
         ## Spies

         Jasmine's test doubles are called spies. A spy can stub any function and tracks calls to it and all arguments. There are special matchers for interacting with spies.

         The `toHaveBeenCalled` matcher will return true if the spy was called. The `toHaveBeenCalledWith` matcher will return true if the argument list matches any of the recorded calls to the spy.
         */

        // TODO object containing a function
        describe("A spy", () =>
        {
            JsDictionary<string, Action<string>> foo = new JsDictionary<string, Action<string>>();
            foo["setBar"] = null;
            string bar = null;
            Spy spy = null;

            beforeEach(() =>
            {

                foo["setBar"] = (value) =>
                {
                    bar = value;
                };

                spy = spyOn(foo, "setBar");

                foo["setBar"]("123");
                foo["setBar"]("456");
            });

            it("tracks that the spy was called", () =>
            {
                expect(foo["setBar"]).toHaveBeenCalled();
            });

            it("tracks its number of calls", () =>
            {
                expect(spy.calls.count()).toEqual(2);
            });

            it("tracks all the arguments of its calls", () =>
            {
                expect(spy).toHaveBeenCalledWith("123");
            });

            it("allows access to the most recent call", () =>
            {
                expect(spy.calls.mostRecent().Args[0]).toEqual("456");
            });

            it("allows access to other calls", () =>
            {
                expect(spy.calls.all()[0].Args[0]).toEqual("123");
            });

            it("stops all execution on a function", () =>
            {
                expect(bar).toBeNull();
            });
        });


        /**
         ### Spies: `and.callThrough`

         By chaining the spy with `and.callThrough`, the spy will still track all calls to it but in addition it will delegate to the actual implementation.
         */

        // TODO object containing a function
        describe("A spy, when configured to call through", () =>
        {
            JsDictionary foo = new JsDictionary();
            foo["setBar"] = null;
            foo["getBar"] = null;
            string bar = null;
            string fetchedBar = null;
            Spy spy = null;

            beforeEach(() =>
            {
                foo["setBar"] = new Action<string>((value) =>
                {
                    bar = value;
                });
                foo["getBar"] = new Func<string>(() => bar);

                spy =spyOn(foo, "getBar").and.callThrough();

                ((Action<string>)foo["setBar"])("123");
                fetchedBar = ((Func<string>)foo["getBar"])();
            });

            it("tracks that the spy was called", () =>
            {
                expect(spy).toHaveBeenCalled();
            });

            it("should not effect other functions", () =>
            {
                expect(bar).toEqual("123");
            });

            it("when called returns the requested value", () =>
            {
                expect(fetchedBar).toEqual("123");
            });
        });


        /**
         ### Spies: `and.returnValue`

         By chaining the spy with `and.returnValue`, all calls to the function will return a specific value.
         */
        // TODO object containing a function
        describe("A spy, when faking a return value", () =>
        {
            JsDictionary foo = new JsDictionary();
            foo["setBar"] = null;
            foo["getBar"] = null;
            string bar = null;
            string fetchedBar = null;
            Spy spy = null;

            beforeEach(() =>
            {
                foo["setBar"] = new Action<string>((value) =>
                {
                    bar = value;
                });
                foo["getBar"] = new Func<string>(() => bar);

                spy = spyOn(foo, "getBar").and.returnValue("745");

                ((Action<string>)foo["setBar"])("123");
                fetchedBar = ((Func<string>)foo["getBar"])();
            });

            it("tracks that the spy was called", () =>
            {
                expect(spy).toHaveBeenCalled();
            });

            it("should not effect other functions", () =>
            {
                expect(bar).toEqual("123");
            });

            it("when called returns the requested value", () =>
            {
                expect(fetchedBar).toEqual("745");
            });
        });


        /**
         ### Spies: `and.callFake`

         By chaining the spy with `and.callFake`, all calls to the spy will delegate to the supplied function.
         */
        // TODO objects containing functions
        describe("A spy, when faking a function", () =>
        {
            JsDictionary foo = new JsDictionary();
            foo["setBar"] = null;
            foo["getBar"] = null;
            string bar = null;
            string fetchedBar = null;
            Spy spy = null;

            beforeEach(() =>
            {

                foo["setBar"] = new Action<string>((value) =>
                {
                    bar = value;
                });
                foo["getBar"] = new Func<string>(() => bar);

                spy = spyOn(foo, "getBar").and.callFake((Function)(new Func<string>(() => "1001")));

                ((Action<string>)foo["setBar"])("123");
                fetchedBar = ((Func<string>)foo["getBar"])();
            });

            it("tracks that the spy was called", () =>
            {
                expect(spy).toHaveBeenCalled();
            });

            it("should not effect other functions", () =>
            {
                expect(bar).toEqual("123");
            });

            it("when called returns the requested value", () =>
            {
                expect(fetchedBar).toEqual("1001");
            });
        });

        /**
        ### Spies: `and.throwError`
        By chaining the spy with `and.throwError`, all calls to the spy will `throw` the specified value as an error.
        */
        describe("A spy, when configured to throw an error", () =>
        {
            JsDictionary<string, Action<string>> foo = new JsDictionary<string, Action<string>>();
            foo["setBar"] = null;
            string bar = null;

            beforeEach(() =>
            {
                foo["setBar"] = (value) =>
                {
                    bar = value;
                };

                spyOn(foo, "setBar").and.throwError("quux");
            });

            it("throws the value", () =>
            {
                expect(new Action(() =>
                {
                    foo["setBar"]("123");
                })).toThrowError("quux");
            });
        });


        /**
        ### Spies: `and.stub`
        When a calling strategy is used for a spy, the original stubbing behavior can be returned at any time with `and.stub`.
        */
        describe("A spy", () =>
        {
            JsDictionary<string, Action<double?>> foo = new JsDictionary<string, Action<double?>>();
            foo["setBar"] = null;
            double? bar = null;
            Spy spy = null;

            beforeEach(() =>
            {
                foo["setBar"] = (value) =>
                {
                    bar = value;
                };

                spy = spyOn(foo, "setBar").and.callThrough();
            });

            it("can call through and then stub in the same spec", () =>
            {
                foo["setBar"](123);
                expect(bar).toEqual(123);

                spy.and.stub();
                bar = null;

                foo["setBar"](123);
                expect(bar).toBe(null);
            });
        });

        /**
        ### Other tracking properties

        Every call to a spy is tracked and exposed on the `calls` property.
        */
        describe("A spy", () =>
        {

            JsDictionary<string, Action<double?>> foo = new JsDictionary<string, Action<double?>>();
            foo["setBar"] = null;
            double? bar = null;
            Spy fooSetBar = null;

            beforeEach(() =>
            {
                foo["setBar"] = (value) =>
                {
                    bar = value;
                };

                fooSetBar = spyOn(foo, "setBar");
            });

            /**
             * `.calls.any()`: returns `false` if the spy has not been called at all, and then `true` once at least one call happens.
             */
            it("tracks if it was called at all", () =>
            {
                expect(fooSetBar.calls.any()).toEqual(false);

                foo["setBar"](0);

                expect(fooSetBar.calls.any()).toEqual(true);
            });

            /**
             * `.calls.count()`: returns the number of times the spy was called
             */
            it("tracks the number of times it was called", () =>
            {
                expect(fooSetBar.calls.count()).toEqual(0);

                foo["setBar"](0);
                foo["setBar"](0);

                expect(fooSetBar.calls.count()).toEqual(2);
            });

            /**
             * `.calls.argsFor(index)`: returns the arguments passed to call number `index`
             */
            it("tracks the arguments of each call", () =>
            {
                foo["setBar"](123);
                foo["setBar"](456);

                expect(fooSetBar.calls.argsFor(0)).toEqual(new[] { 123 });
                expect(fooSetBar.calls.argsFor(1)).toEqual(new[] { 456 });
            });

            /**
             * `.calls.allArgs()`: returns the arguments to all calls
             */
            it("tracks the arguments of all calls", () =>
            {
                foo["setBar"](123);
                foo["setBar"](456);

                expect(fooSetBar.calls.allArgs()).toEqual(new[] { new[] { 123 }, new[] { 456 } });
            });

            /**
             * `.calls.all()`: returns the context (the `this`) and arguments passed all calls
             */
            it("can provide the context and arguments to all calls", () =>
            {
                foo["setBar"](123);

                expect(fooSetBar.calls.all()).toEqual(new[] { new { @object = foo, args = new[] { 123 }, returnValue = Script.Undefined } });
            });

            /**
             * `.calls.mostRecent()`: returns the context (the `this`) and arguments for the most recent call
             */
            it("has a shortcut to the most recent call", () =>
            {
                foo["setBar"](123);
                foo["setBar"](456);

                expect(fooSetBar.calls.mostRecent()).toEqual(new { @object = foo, args = new[] { 456 }, returnValue = Script.Undefined });
            });

            /**
             * `.calls.first()`: returns the context (the `this`) and arguments for the first call
             */
            it("has a shortcut to the first call", () =>
            {
                foo["setBar"](123);
                foo["setBar"](456);

                expect(fooSetBar.calls.first()).toEqual(new { @object = foo, args = new[] { 123 }, returnValue = Script.Undefined });
            });

            /**
             * When inspecting the return from `all()`, `mostRecent()` and `first()`, the `object` property is set to the value of `this` when the spy was called.
             */
            it("tracks the context", () =>
            {
                Spy spy = createSpy("spy");

                JsDictionary<string, Spy> baz = new JsDictionary<string, Spy>();
                JsDictionary<string, Spy> quux = new JsDictionary<string, Spy>();

                baz["fn"] = spy;
                quux["fn"] = spy;
                baz["fn"].Call(123);
                quux["fn"].Call(456);

                expect(spy.calls.first().Object).toBe(baz);
                expect(spy.calls.mostRecent().Object).toBe(quux);
            });

            /**
             * `.calls.reset()`: clears all tracking for a spy
             */
            it("can be reset", () =>
            {
                foo["setBar"](123);
                foo["setBar"](456);

                expect(fooSetBar.calls.any()).toBe(true);

                fooSetBar.calls.reset();

                expect(fooSetBar.calls.any()).toBe(false);
            });
        });

        /**
         ### Spies: `createSpy`

         When there is not a function to spy on, `jasmine.createSpy` can create a "bare" spy. This spy acts as any other spy - tracking calls, arguments, etc. But there is no implementation behind it. Spies are JavaScript objects and can be used as such.

         */
        describe("A spy, when created manually", () =>
        {
            Spy whatAmI = null;

            beforeEach(() =>
            {
                whatAmI = createSpy("whatAmI");

                whatAmI.Call("I", "am", "a", "spy");
            });

            it("is named, which helps in error reporting", () =>
            {
                expect(whatAmI.and.identity()).toEqual("whatAmI");
            });

            it("tracks that the spy was called", () =>
            {
                expect(whatAmI).toHaveBeenCalled();
            });

            it("tracks its number of calls", () =>
            {
                expect(whatAmI.calls.count()).toEqual(1);
            });

            it("tracks all the arguments of its calls", () =>
            {
                expect(whatAmI).toHaveBeenCalledWith("I", "am", "a", "spy");
            });

            it("allows access to the most recent call", () =>
            {
                expect(whatAmI.calls.mostRecent().Args[0]).toEqual("I");
            });
        });

        /**
         ### Spies: `createSpyObj`

         In order to create a mock with multiple spies, use `jasmine.createSpyObj` and pass an array of strings. It returns an object that has a property for each string that is a spy.
         */
        describe("Multiple spies, when created manually", () =>
        {
            dynamic tape = null;

            beforeEach(() =>
            {
                tape = createSpyObj("tape", new string[] { "play", "pause", "stop", "rewind" });

                tape.play();
                tape.pause();
                tape.rewind(0);
            });

            it("creates spies for each requested function", () =>
            {
                expect((object)tape.play).toBeDefined();
                expect((object)tape.pause).toBeDefined();
                expect((object)tape.stop).toBeDefined();
                expect((object)tape.rewind).toBeDefined();
            });

            it("tracks that the spies were called", () =>
            {
                expect((object)tape.play).toHaveBeenCalled();
                expect((object)tape.pause).toHaveBeenCalled();
                expect((object)tape.rewind).toHaveBeenCalled();
                expect((object)tape.stop).not.toHaveBeenCalled();
            });

            it("tracks all the arguments of its calls", () =>
            {
                expect((object)tape.rewind).toHaveBeenCalledWith(0);
            });
        });

        /**
         ## Matching Anything with `jasmine.any`

         `jasmine.any` takes a constructor or "class" name as an expected value. It returns `true` if the constructor matches the constructor of the actual value.
         */

        // TODO any matcher
        describe("jasmine.any", () =>
        {
            it("matches any value", () =>
            {
                expect(null).toEqual(any(typeof(Object)));
                expect(12).toEqual(any(typeof(Double)));
            });

            describe("when used with a spy", () =>
            {
                it("is useful for comparing arguments", () =>
                {
                    Spy foo = createSpy("foo");
                    foo.Call(12, new Func<bool>(() => true));

                    expect(foo).toHaveBeenCalledWith(any(typeof(Double)), any(typeof(Function)));
                });
            });
        });

        /**
         ## Partial Matching with `jasmine.objectContaining`
         `jasmine.objectContaining` is for those times when an expectation only cares about certain key/value pairs in the actual.
         */

        describe("jasmine.objectContaining", () =>
        {
            JsDictionary foo = new JsDictionary();

            foo["a"] = 0;
            foo["b"] = 0;
            foo["bar"] = "";

            beforeEach(() =>
            {

                foo["a"] = 1;
                foo["b"] = 2;
                foo["bar"] = "baz";
            });

            it("matches objects with the expect key/value pairs", () =>
            {
                expect(foo).toEqual(objectContaining(new
                {
                    bar = "baz"
                }));
                expect(foo).not.toEqual(objectContaining(new
                {
                    c = 37
                }));
            });

            describe("when used with a spy", () =>
            {
                it("is useful for comparing arguments", () =>
                {
                    Spy callback = createSpy("callback");

                    callback.Call(new
                    {
                        bar = "baz"
                    });

                    expect(callback).toHaveBeenCalledWith(objectContaining(new
                    {
                        bar = "baz"
                    }));
                    expect(callback).not.toHaveBeenCalledWith(objectContaining(new
                    {
                        c = 37
                    }));
                });
            });
        });


        /**
         ## Mocking the JavaScript Clock

         The Jasmine Mock Clock is available for a test suites that need the ability to use `setTimeout` or `setInterval` callbacks. It makes the timer callbacks synchronous, thus making them easier to test.

         */
        // TODO clock
        describe("Manually ticking the Jasmine Mock Clock", () =>
        {
            Spy timerCallback = null;

            //
            // It is installed with a call to `jasmine.Clock.useMock` in a spec or suite that needs to call the timer functions.
            //
            beforeEach(() =>
            {
                timerCallback = createSpy("timerCallback");
                clock().install();
            });

            afterEach(() =>
            {
                timerCallback = createSpy("timerCallback");
                clock().uninstall();
            });

            //
            // Calls to any registered callback are triggered when the clock is ticked forward via the `jasmine.Clock.tick` function, which takes a number of milliseconds.
            //
            it("causes a timeout to be called synchronously", () =>
            {
                Window.SetTimeout(() =>
                {
                    timerCallback.Call();
                }, 100);



                expect(timerCallback).not.toHaveBeenCalled();

                clock().tick(101);

                expect(timerCallback).toHaveBeenCalled();
            });

            it("causes an interval to be called synchronously", () =>
            {
                Window.SetInterval(() =>
                {
                    timerCallback.Call();
                }, 100);

                expect(timerCallback).not.toHaveBeenCalled();

                clock().tick(101);
                expect(timerCallback.calls.count()).toEqual(1);

                clock().tick(50);
                expect(timerCallback.calls.count()).toEqual(1);

                clock().tick(50);
                expect(timerCallback.calls.count()).toEqual(2);
            });
        });


        /**
         ## Asynchronous Support
         __This syntax has changed for Jasmine 2.0.__
         Jasmine also has support for running specs that require testing asynchronous operations.
         */
        describe("Asynchronous specs", () =>
        {
            double value = 0;
            /**
             Calls to `beforeEach`, `it`, and `afterEach` can take an optional single argument that should be called when the async work is complete.
             */
            beforeEach((done) =>
            {
                Window.SetTimeout(() =>
                {
                    value = 0;
                    done();
                }, 1);
            });

            /**
             This spec will not start until the `done` function is called in the call to `beforeEach` above. And this spec will not complete until its `done` is called.
             */

            it("should support async execution of test preparation and expectations", (done) =>
            {
                value++;
                expect(value).toBeGreaterThan(0);


                Task.Delay(1).ContinueWith((T) =>
                {
                    value = 1;
                    expect(value).toBeGreaterThan(0);
                    done();
                });
            });

            /**
             By default jasmine will wait for 5 seconds for an asynchronous spec to finish before causing a timeout failure.
             If specific specs should fail faster or need more time this can be adjusted by setting `jasmine.DEFAULT_TIMEOUT_INTERVAL` around them.

             If the entire suite should have a different timeout, `jasmine.DEFAULT_TIMEOUT_INTERVAL` can be set globally, outside of any given `describe`.
             */
            describe("long asynchronous specs", () =>
            {
                double originalTimeout = 0;
                beforeEach(() =>
                {
                    originalTimeout = DEFAULT_TIMEOUT_INTERVAL;
                    DEFAULT_TIMEOUT_INTERVAL = 100;
                });

                it("takes a long time", (done) =>
                {
                    Window.SetTimeout(() =>
                    {
                        done();
                    }, 90);
                });

                afterEach(() =>
                {
                    DEFAULT_TIMEOUT_INTERVAL = originalTimeout;
                });
            });
        });


        /**
         *
         * Often a project will want to encapsulate custom matching code for use across multiple specs. Here is how to create a Jasmine-compatible custom matcher.
         *
         * A custom matcher at its root is a comparison function that takes an `actual` value and `expected` value. This factory is passed to Jasmine, ideally in a call to `beforeEach` and will be in scope and available for all of the specs inside a given call to `describe`. Custom matchers are torn down between specs. The name of the factory will be the name of the matcher exposed on the return value of the call to `expect`.
         *
         */

        /**
         * This object has a custom matcher named "toBeGoofy".
         */
        JsDictionary<string, Func<ICustomMatcherUtil, object, ICustomMatcher<string>>> customMatchers =
            new JsDictionary<string, Func<ICustomMatcherUtil, object, ICustomMatcher<string>>>();

        /**
        * ## Matcher Factories
        *
        * Custom matcher factories are passed two parameters: `util`, which has a set of utility functions for matchers to use (see: [`matchersUtil.js`][mu.js] for the current list) and `customEqualityTesters` which needs to be passed in if `util.equals` is ever called. These parameters are available for use when then matcher is called.
        *
        * [mu.js]: https://github.com/pivotal/jasmine/blob/master/src/core/matchers/matchersUtil.js
        */
        /**
        * The factory method should return an object with a `compare` function that will be called to check the expectation.
        */
        customMatchers["toBeGoofy"] = (util, customEqualityTesters) => new ToBeGoofy(util, customEqualityTesters);


        /**
        * ### Custom negative comparators
        *
        * If you need more control over the negative comparison (the `not` case) than the simple boolean inversion above, you can also have your matcher factory include another key, `negativeCompare` alongside `compare`, for which the value is a function to invoke when `.not` is used. This function/key is optional.
        */

        /**
         * ## Registration and Usage
         */
        describe("Custom matcher: 'toBeGoofy'", () =>
        {
            /**
             * Register the custom matchers with Jasmine. All properties on the object passed in will be available as custom matchers (e.g., in this case `toBeGoofy`).
             */
            beforeEach(() =>
            {
                addMatchers(customMatchers);
            });

            /**
             * Once a custom matcher is registered with Jasmine, it is available on any expectation.
             */
            it("is available on an expectation", () =>
            {
                expect(new
                {
                    hyuk = "gawrsh"
                }).toBeGoofy(); //extension method
            });

            it("can take an 'expected' parameter", () =>
            {
                expect(new
                {
                    hyuk = "gawrsh is fun"
                }).toBeGoofy(" is fun");
            });

            it("can be negated", () =>
            {
                expect(new
                {
                    hyuk = "this is fun"
                }).not.toBeGoofy();
            });
        });

        /**
        * ## Custom Equality Testers
        */
        describe("custom equality", () =>
        {
            /**
             * You can customize how jasmine determines if two objects are equal by defining your own custom equality testers.
             * A custom equality tester is a function that takes two arguments.
             */
            Func<string, string, bool> myCustomEquality = (first, second) =>
            {
                /**
                 * If the custom equality tester knows how to compare the two items, it should return either true or false
                 */

                if (Script.TypeOf(first) == "string" && Script.TypeOf(second) == "string")
                {
                    return first[0] == second[1];
                }

                return false;

                /**
                 * Otherwise, it should return undefined, to tell jasmine's equality tester that it can't compare the items
                 */
            };

            /**
             * Then you register your tester in a `beforeEach` so jasmine knows about it.
             */
            beforeEach(() =>
            {
                addCustomEqualityTester(myCustomEquality);
            });

            /**
             * Then when you do comparisons in a spec, custom equality testers will be checked first before the default equality logic.
             */
            it("should be custom equal", () =>
            {
                expect("abc").toEqual("aaa");
            });

            /**
             * If your custom tester returns false, no other equality checking will be done.
             */
            it("should be custom not equal", () =>
            {
                expect("abc").not.toEqual("abc");
            });
        });

        /**
         *
         * If you don't like the way the built-in jasmine reporters look, you can always write your own.
         *
         */

        /**
         * A jasmine reporter is just an object with the right functions available.
         * None of the functions here are required when creating a custom reporter, any that are not specified on your reporter will just be ignored.
         */
        JsApiReporter myReporter = new JsApiReporter()
        {
            /**
             * ### jasmineStarted
             *
             * `jasmineStarted` is called after all of the specs have been loaded, but just before execution starts.
             */
            jasmineStarted = (suiteInfo) =>
            {
                /**
                 * suiteInfo contains a property that tells how many specs have been defined
                 */
                Console.WriteLine("Running suite with " + suiteInfo.totalSpecsDefined);
            },
            /**
             * ### suiteStarted
             *
             * `suiteStarted` is invoked when a `describe` starts to run
             */
            suiteStarted = (result) =>
            {
                /**
                 * the result contains some meta data about the suite itself.
                 */
                Console.WriteLine("Suite started: " + result.description + " whose full description is: " + result.fullName);
            },
            /**
            * ### specStarted
            *
            * `specStarted` is invoked when an `it` starts to run (including associated `beforeEach` functions)
            */
            specStarted = (result) =>
            {
                /**
                    * the result contains some meta data about the spec itself.
                    */
                Console.WriteLine("Spec started: " + result.description + " whose full description is: " + result.fullName);
            },
            /**
            * ### specDone
            *
            * `specDone` is invoked when an `it` and its associated `beforeEach` and `afterEach` functions have been run.
            *
            * While jasmine doesn't require any specific functions, not defining a `specDone` will make it impossible for a reporter to know when a spec has failed.
            */
            specDone = (result) =>
            {
                /**
                    * The result here is the same object as in `specStarted` but with the addition of a status and a list of failedExpectations.
                    */
                Console.WriteLine("Spec: " + result.description + " was " + result.status);
                for (var i = 0; i < result.failedExpectations.Length; i++)
                {
                    /**
                    * Each `failedExpectation` has a message that describes the failure and a stack trace.
                    */
                    Console.WriteLine("Failure: " + result.failedExpectations[i].message);
                    Console.WriteLine(result.failedExpectations[i].stack);
                }
            },
            /**
            * ### suiteDone
            *
            * `suiteDone` is invoked when all of the child specs and suites for a given suite have been run
            *
            * While jasmine doesn"t require any specific functions, not defining a `suiteDone` will make it impossible for a reporter to know when a suite has failures in an `afterAll`.
            */
            suiteDone = (result) =>
            {
                /**
                * The result here is the same object as in `suiteStarted` but with the addition of a status and a list of failedExpectations.
                */
                Console.WriteLine("Suite: " + result.description + " was " + result.status);
                for (var i = 0; i < result.failedExpectations.Length; i++)
                {
                    /**
                    * Any `failedExpectation`s on the suite itself are the result of a failure in an `afterAll`.
                    * Each `failedExpectation` has a message that describes the failure and a stack trace.
                    */
                    Console.WriteLine("AfterAll " + result.failedExpectations[i].message);
                    Console.WriteLine(result.failedExpectations[i].stack);
                }
            },
            /**
            * ### jasmineDone
            *
            * When the entire suite has finished execution `jasmineDone` is called
            */
            jasmineDone = () =>
            {
                Console.WriteLine("Finished suite");
            }
        };

        /**
            * Register the reporter with jasmine
            */
        getEnv().addReporter(myReporter);

        /**
         * If you look at the console output for this page, you should see the output from this reporter
         */
        describe("Top Level suite", () =>
        {
            it("spec", () =>
            {
                expect(1).toBe(1);
            });

            describe("Nested suite", () =>
            {
                it("nested spec", () =>
                {
                    expect(true).toBe(true);
                });
            });
        });

        /**
         Focusing specs will make it so that they are the only specs that run.
         */

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

    public class ToBeGoofy : ICustomMatcher<string>
    {
        public static ICustomMatcherUtil Util;
        public static object CustomEqualityTesters;

        public ToBeGoofy(ICustomMatcherUtil util, object customEqualityTesters)
        {
            ToBeGoofy.Util = util;
            ToBeGoofy.CustomEqualityTesters = customEqualityTesters;
        }

        /**
        * ## A Function to `compare`
        *
        * The compare function receives the value passed to `expect()` as the first argument - the actual - and the value (if any) passed to the matcher itself as second argument.
        */
        public MatcherResult Compare(object actual, string expected)
        {

            /**
                * `toBeGoofy` takes an optional `expected` argument, so define it here if not passed in.
                */
            if (expected == (string)Script.Undefined)
            {
                expected = "";
            }

            /**
            * ### Result
            *
            * The `compare` function must return a result object with a `pass` property that is a boolean result of the matcher. The `pass` property tells the expectation whether the matcher was successful (`true`) or unsuccessful (`false`). If the expectation is called/chained with `.not`, the expectation will negate this to determine whether the expectation is met.
            */
            bool resultPass = false;
            string resultMessage = "";
            /**
            * `toBeGoofy` tests for equality of the actual's `hyuk` property to see if it matches the expectation.
            */
            resultPass = ToBeGoofy.Util.equals(((JsDictionary)actual)["hyuk"], "gawrsh" + expected, ToBeGoofy.CustomEqualityTesters);

            /**
            * ### Failure Messages
            *
            * If left `undefined`, the expectation will attempt to craft a failure message for the matcher. However, if the return value has a `message` property it will be used for a  failed expectation.
            */
            if (resultPass)
            {
                /**
                * The matcher succeeded, so the custom failure message should be present in the case of a negative expectation - when the expectation is used with `.not`.
                */
                resultMessage = "Expected " + actual + " not to be quite so goofy";
            }
            else
            {
                /**
                * The matcher failed, so the custom failure message should be present in the case of a positive expectation
                */
                resultMessage = "Expected " + actual + " to be goofy, but it was not very goofy";
            }

            /**
            * Return the result of the comparison.
            */
            return new MatcherResult(resultPass, resultMessage);
        }
    }
}

public static class MatcherExtensions
{
    [InstanceMethodOnFirstArgument]
    public static bool toBeGoofy(this Matchers matcher)
    {
        return false;
    }

    [InstanceMethodOnFirstArgument]
    public static bool toBeGoofy(this Matchers matcher, string expected)
    {
        return false;
    }
}