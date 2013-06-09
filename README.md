# Saltarelle.Jasmine

Saltarelle.Jasmine is the metadata library required to use the [Jasmine](http://pivotal.github.io/jasmine/) BDD testing 
framework with the C# Saltarelle compiler.

# Setting up the C# project

To be able to write tests with Saltarelle.Jasmine, in your C# project you need to add a reference 
to Saltarelle.Jasmine.dll contained in this repo. 

Then, in your .cs files add the following:

```C#
using Jasmine;
```

# Set up the runner page

The easiest way to run a Javascript testing framework is to have a specific web page (called runner) that runs all your tests. 

In this repo, the `Jasmine` folder under `Website` already contains the standard Jasmine runner page `SpecRunner.html` 
that you can modify to your needs. All you have to do is to include the required script files (don't forget `mscorlib`)
and the command to run the tests. For example:

```HTML 
<script type="text/javascript" src="../Scripts/mscorlib.min.js"></script>
<script type="text/javascript" src="../Scripts/example.js"></script>
<script>     
    new JasmineTests().SpecRunner(); // run tests contained in the class JasmineTests, SpecRunner() method
</script>
```HTML

please note that while in Javascript code and tests are on separate files, in Saltarelle there is only
one script file containing both code and tests (in the above: `example.js`).

# How to write tests

In Jasmine terminology tests are grouped under a test suite. To create a test suite, derive a class from `JasmineSuite` and implement
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

# Running the tests

Simply run your application and browse to your runner page (SpecRunner.html), Jasmine will do the rest.

