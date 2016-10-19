# Saltarelle.Jasmine

Saltarelle.Jasmine is the metadata library required to use the [Jasmine](https://jasmine.github.io/) BDD testing 
framework with the [C# Saltarelle compiler](http://www.saltarelle-compiler.com/).

Currently the v2.1.3 of Jasmine is supported.


## Contents

* [How to setup the C# project](#setupcs)
* [How to set up the spec runner page](#setuphtml)
* [How to write tests](#writetests)
* [How to run tests](#runtests)
* [History](#history)


## How to setup the C# project <a id="setupcs"></a>

You can install `Saltarelle.Jasmine` in your C# project via `nuget` package manager.

From `nuget` console prompt, choose the destination C# project and type:

`install-package saltarelle.jasmine.cs`

This will download the latest `Saltarelle.Jasmine.dll` and add a reference to it in your project. 


## How to set up the spec runner page <a id="setuphtml"></a>

In Jasmine, there is a dedicated web page (called `SpecRunner.html`) that runs all the tests interactively.

In order to make it work with Saltarelle, you have to customize it slightly. 

Locate the `SpecRunner.html` contained in this repo and modify to your needs. Include the required script files (e.g. `mscorlib`) and the JavaScript code to run the tests. 

For example:
```HTML 
<script type="text/javascript" src="../Scripts/mscorlib.min.js"></script>   <!-- include mscorlib -->
<script type="text/javascript" src="../Scripts/example.js"></script>        <!-- compiled tests -->
<script>     
    new JasmineTests().SpecRunner(); // run tests contained in the class JasmineTests, SpecRunner() method
</script>
```

please note that while in Javascript code and tests are usually on separate files, in Saltarelle there is only
one big script file containing both (unless of course you have separate projects for code and for testing).


## How to write tests <a id="writetests"></a>

First of all, reference this package in your source code with: 
 
```C#
using Jasmine;
```

In Jasmine terminology, tests are grouped under a test suite. To create a test suite, derive a class from `JasmineSuite` and implement
a method containing your suite. For example:

```C#
public class JasmineTests : JasmineSuite
{
   public void SpecRunner1()
   {
   }
}
```

deriving from `JasmineSuite` lets you use methods like `describe()` or `it()` in a natural manner, identical to what's is done in Javascript. 
The only difference is that functions are C# lambda expressions and, of course, code is C# instead of Javascript.

For example:

```C#
public class JasmineTests : JasmineSuite
{
	public void SpecRunner1()
	{
		describe("A suite", ()=> {
			it("contains spec with an expectation", ()=> {
				expect(true).toBe(true);
			});
		});
	}
}
```


## Running the tests <a id="runtests"></a>

Build your solution and browse to the runner page (`SpecRunner.html`), Jasmine will do the rest.

## Creating custom matchers

There are two methods available for registering custom matchers - `JasmineSuite.addMatcher(string name, CustomMatcherComparer matcher)` and 
`JasmineSuite.addMatchers(JsDictionary<string, CustomMatcherComparer> matchers)`.  As in Javascript, these methods should be called in a
 `beforeEach` block to register your matcher(s) before each test is run, though the signatures of these methods differ significantly
from the corresponding Javascript method.

Defining and registering a `CustomMatcherComparer` looks something like this:

```C#
public class JasmineTests : JasmineSuite
{
    // Basic implementation of IMatcherResult
    public class MatcherResult: IMatcherResult {
        public bool Pass;
        public string Message;

        public MatcherResult(bool pass, string message)
        {
            Pass = pass;
            Message = message;
        }
    }

    public class CustomMatchers {
        public static CustomMatcherComparer ToBeEven = (utils, customEqualityTesters, actual, expected) => {
            var result = new MatcherResult(false, "Expected number to be even");

            // ...implement matcher logic here as you would in Javascript, utilising utils and customEqualityTesters as required.

            return result;
        };
    }
    
	public void SpecRunner1()
	{
		beforEach(() => {
            addMatcher("toBeEven", CustomMatchers.ToBeEven);
        });
        
        // ...the rest of your tests that make use of the custom matcher(s)
	}
}
```

You will also need to define an extension method on the `Jasmine.Matchers` type to allow usage of your custom matchers from C# code, for example:

```C#
public static class MatcherExtensions
{
    [InstanceMethodOnFirstArgument]
	public static bool ToBeEven(this Matchers matcher, int expected)
	{
		return false;
	}
}
```


## History <a id="history"></a>

* March 4, 2015: support for explicit timeout parameter in async (Jasmine v2.2) 
* March 2, 2015: updated to Jasmine v2.1.3 (thanks to [Bruddles](https://github.com/Bruddles)) 
* (around 2013): implemented Jasmine v1
