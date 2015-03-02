# Saltarelle.Jasmine

Saltarelle.Jasmine is the metadata library required to use the [Jasmine](http://pivotal.github.io/jasmine/) BDD testing 
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


## History <a id="history"></a>

* March 2, 2015: updated to Jasmine v2.1.3 (thanks to [Bruddles](https://github.com/Bruddles)) 
* (around 2013): implemented Jasmine v1
