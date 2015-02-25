using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

[assembly: PreserveMemberCase]

#pragma warning disable 1591   // disables missing XML documentation warning

namespace Jasmine
{
    [Imported]
    public class Matchers
    {
        private Matchers(Env env, object actual, Env spec, bool isNot = false) { }

        public Env env;
        public object actual;
        public Env spec;
        public bool isNot = false;
        public object message()
        {
            return null;
        }

        public bool toBe(object expected) { return false; }
        public bool toEqual(object expected) { return false; }
        public bool toMatch(string expected) { return false; }
        public bool toBeDefined() { return false; }
        public bool toBeUndefined() { return false; }
        public bool toBeNull() { return false; }
        public bool toBeNaN() { return false; }
        public bool toBeTruthy() { return false; }
        public bool toBeFalsy() { return false; }
        public bool toHaveBeenCalled() { return false; }
        [ExpandParams]
        public bool toHaveBeenCalledWith(params object[] par) { return false; }
        public bool toContain(object expected) { return false; }
        public bool toBeLessThan(object expected) { return false; }
        public bool toBeGreaterThan(object expected) { return false; }
        public bool toBeCloseTo(object expected, int precision) { return false; }
        public bool toThrow() { return false; }
        public bool toThrowError() { return false; }
        public bool toThrowError(object expected) { return false; }

        [IntrinsicProperty]
        public Matchers not { get { return null; } }

        // any matcher
        public IAny Any;

        // typeof matcher?
    }
    
    public interface ICustomMatcher<in T>
    {
        MatcherResult Compare(object actual, T expect);
    }

    [PreserveMemberCase(false)]
    public class MatcherResult
    {
        public bool Pass;
        public string Message;

        public MatcherResult(bool pass, string message)
        {
            Pass = pass;
            Message = message;
        }
    }

    
    public interface ICustomMatcherUtil
    {
        [PreserveName]
        string buildFailureMessage();
        [PreserveName]
        bool contains(object haystack, object needle, object customTesters);
        [PreserveName]
        bool equals(object a, object b, object customTesters);
    }

    [Imported]
    public class Spy
    {
        public string identity;
        public ICalls calls;
        public ISpyAnd and;
        [InlineCode("{this}({*args})")]
        public void Call(params object[] args) { }

        [ScriptSkip]
        public static implicit operator Function(Spy spy)
        {
            return new Function();
        }
    }

    [IgnoreNamespace]
    [Imported]
    [ScriptName("Object")]
    public class JasmineSuite
    {
        [InlineCode("{}")]
        public JasmineSuite() { }

        [InlineCode("describe({description},{specDefinitions})")]
        public static void describe(string description, Action specDefinitions) { }

        [InlineCode("fdescribe({description},{specDefinitions})")]
        public static void fdescribe(string description, Action specDefinitions) { }

        [InlineCode("xdescribe({description},{specDefinitions})")]
        public static void xdescribe(string description, Action specDefinitions) { }

        [InlineCode("it({desc},{func})")]
        public static void it(string desc, Action func) { }

        [InlineCode("it({desc},{func})")]
        public static void it(string desc, Action<Action> func) { }

        [InlineCode("it({desc}, ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void it(string desc, Func<Task> func) { }

        [InlineCode("fit({desc},{func})")]
        public static void fit(string desc, Action func) { }

        [InlineCode("fit({desc},{func})")]
        public static void fit(string desc, Action<Action> func) { }

        [InlineCode("fit({desc}, ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void fit(string desc, Func<Task> func) { }

        [InlineCode("xit({desc},{func})")]
        public static void xit(string desc, Action func) { }

        [InlineCode("xit({desc},{func})")]
        public static void xit(string desc, Action<Action> func) { }

        [InlineCode("xit({desc}, ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void xit(string desc, Func<Task> func) { }

        [InlineCode("pending()")]
        public static void pending() { }

        [InlineCode("expect({o})")]
        public static Matchers expect(object o) { return null; }

        [InlineCode("expect({d})")]
        public static Matchers expect(Delegate d) { return null; }

        [InlineCode("beforeEach({func})")]
        public static void beforeEach(Action func) { }

        [InlineCode("beforeEach({func})")]
        public static void beforeEach(Action<Action> func) { }

        [InlineCode("beforeEach(ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void beforeEach(Func<Task> func) { }

        [InlineCode("afterEach({func})")]
        public static void afterEach(Action func) { }

        [InlineCode("afterEach({func})")]
        public static void afterEach(Action<Action> func) { }

        [InlineCode("afterEach(ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void afterEach(Func<Task> func) { }

        [InlineCode("beforeAll({func})")]
        public static void beforeAll(Action func) { }

        [InlineCode("beforeAll({func})")]
        public static void beforeAll(Action<Action> func) { }

        [InlineCode("beforeAll(ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void beforeAll(Func<Task> func) { }

        [InlineCode("afterAll({func})")]
        public static void afterAll(Action func) { }

        [InlineCode("afterAll({func})")]
        public static void afterAll(Action<Action> func) { }

        [InlineCode("afterAll(ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void afterAll(Func<Task> func) { }

        [InlineCode("spyOn({o},{methodname})")]
        public static Spy spyOn(object o, string methodname) { return null; }

        [InlineCode("jasmine.createSpy({name})")]
        public static Jasmine.Spy createSpy(string name)
        {
            return null;
        }
        public static Jasmine.Spy createSpy(string name, Delegate originalFunction)
        {
            return null;
        }

        [InlineCode("jasmine.createSpyObj({baseName}, {methodNames})")]
        public static dynamic createSpyObj(string baseName, string[] methodNames)
        {
            return null;
        }

        [InlineCode("jasmine.createSpyObj({baseName}, {methodNames})")]
        public static T createSpyObj<T>(string baseName, string[] methodNames)
        {
            return default(T);
        }

        // clock mock

        // async support
        [InlineCode("runs({func})")]
        public static void runs(Action func) { }

        [InlineCode("waitsFor({func},{failureMessage},{timeout})")]
        public static void waitsFor(Func<bool> func, string failureMessage, int timeout) { }

        [InlineCode("waitsFor({func},'',{timeout})")]
        public static void waitsFor(Func<bool> func, int timeout) { }

        [InlineCode("waitsFor({func})")]
        public static void waitsFor(Func<bool> func) { }

        [InlineCode("jasmine.clock()")]
        public static Clock clock()
        {
            return null;
        }

        [InlineCode("jasmine.Spec()")]
        public static Spec Spec()
        {
            return null;
        }
        
        [InlineCode("jasmine.any({any})")]
        public static IAny any(object any)
        {
            return null;
        }

        [InlineCode("jasmine.objectContaining({sample})")]
        public static IObjectContaining objectContaining(object sample)
        {
            return null;
        }

        [InlineCode("jasmine.pp({value})")]
        public static string pp(object value)
        {
            return null;
        }

        [InlineCode("jasmine.getEnv()")]
        public static Env getEnv()
        {
            return null;
        }

        [InlineCode("jasmine.addMatchers({matcher})")]
        public static void addMatchers(JsDictionary<string, Func<ICustomMatcherUtil, object, ICustomMatcher<string>>> matcher) { }

        [InlineCode("jasmine.addCustomEqualityTester({customEquality})")]
        public static void addCustomEqualityTester(object customEquality) { }
        
        [Imported]
        public static class Util
        {

            public static object argsToArray(object args)
            {
                return null;
            }
            public static bool arrayContains(Array array, object contains)
            {
                return false;
            }
            public static object clone(object obj)
            {
                return null;
            }
            public static string htmlEscape(string str)
            {
                return null;
            }
            public static object inherit(Function childClass, Function parentClass)
            {
                return null;
            }
            public static bool isUndefined(object obj)
            {
                return false;
            }
        }
        
        public static double DEFAULT_TIMEOUT_INTERVAL {
            [InlineCode("jasmine.DEFAULT_TIMEOUT_INTERVAL")]
            get { return 5000; }
            [InlineCode("jasmine.DEFAULT_TIMEOUT_INTERVAL = {value}")]
            set {}}

        }

    [Imported]
    public class Clock
    {
        public void install() { }
        
        public void uninstall() { }
        
        public void tick(int ms) { }
    }
    [Imported]
    public interface IAny
    {
        object IAny(object exportedClass);

        bool jasmineMatches(object other);
        string jasmineToString();
    }

    [Imported]
    public interface IObjectContaining
    {
        object IObjectContaining(object sample);

        bool jasmineMatches(object other, object[] mismatchKeys, object[] mismatchValues);
        string jasmineToString();
    }

    [Imported]
    public interface IBlock
    {
        object Block(Env env, SpecFunction func, Spec spec);

        void execute(Action onComplete);
    }

    [Imported]
    public interface IWaitsBlock : IBlock
    {
        object WaitsBlock(Env env, int timeout, Spec spec);
    }

    [Imported]
    public interface IWaitsForBlock : IBlock
    {
        object WaitsBlock(Env env, int timeout, SpecFunction latchFunction, string message, Spec spec);
    }

    [Imported]
    public sealed class Env
    {
        private Env() { }

        public Func<Function, int, int> setTimeout;
        public Action<int> clearTimeout;
        public object setInterval;
        public Action<int> clearInterval;
        public int updateInterval;

        public Spec currentSpec;

        public Matchers matchersClass;

        public object version()
        {
            return null;
        }

        public string versionString()
        {
            return null;
        }
        public int nextSpecId()
        {
            return 0;
        }
        public void addReporter(Reporter reporter) { }
        public void execute() { }
        public Suite describe(string description, Action specDefinitions)
        {
            return null;
        }
        public void beforeEach(Action beforeEachFunction){}
        public void beforeAll(Action beforeAllFunction){}
        public IRunner currentRunner()
        {
            return null;
        }
        public void afterEach(Action afterEachFunction){}
        public void afterAll(Action afterAllFunction){}
        public IXSuite xdescribe(string desc, Action specDefinitions)
        {
            return null;
        }
        public Spec it(string description, Action func)
        {
            return null;
        }
        public XSpec xit(string desc, Action func)
        {
            return null;
        }
        public bool compareRegExps_(Regex a, Regex b, string[] mismatchKeys, string[] mismatchValues)
        {
            return false;
        }
        public bool compareObjects_(object a, object b, string[] mismatchKeys, string[] mismatchValues)
        {
            return false;
        }
        public bool equals_(object a, object b, string[] mismatchKeys, string[] mismatchValues)
        {
            return false;
        }
        public bool contains_(object haystack, object needle)
        {
            return false;
        }
        public void addEqualityTester(Func<object, object, Env, string[], string[], bool> equalityTester) { }
        public bool specFilter(Spec spec)
        {
            return false;
        }
    }

    [Imported]
    public interface IFakeTimer
    {
        object FakeTimer();

        Action reset();
        Action tick(int millis);
        Action runFunctionsWithinRange(int oldMillis, int nowMillis);
        Action scheduleFunction(object timeoutKey, Action funcToCall, int millis, bool recurring);
    }

    [Imported]
    public interface IHtmlReporter
    {
        object HtmlReporter();
    }

    [Imported]
    public interface IHtmlSpecFilter
    {
        object HtmlSpecFilter();
    }

    [Imported]
    public class Result
    {
        protected Result() {}
        public string type;
    }

    [Imported]
    public class NestedResults : Result
    {
        string description;

        public int totalCount;
        public int passedCount;
        public int failedCount;

        public bool skipped;

        public void rollupCounts(NestedResults result) { }
        public void log(object values) { }
        public Result[] getItems()
        {
            return null;
        }
        public void addResult(Result result) { }

        public bool passed()
        {
            return false;
        }
    }

    [Imported]
    public class MessageResult : Result
    {
        public object values;
        public Trace trace;
    }

    [Imported]
    public class ExpectationResult : Result
    {
        public string matcherName;

        public bool passed()
        {
            return false;
        }
        public object expected;
        public object actual;
        public string message;
        public Trace trace;
    }

    [Imported]
    public class Trace
    {
        public string name;
        public string message;
        public object stack;
    }

    [Imported]
    public interface IPrettyPrinter
    {
        object PrettyPrinter();

        void format(object value);
        void iterateObject(object obj, Action<string, bool> fn);
        void emitScalar(object value);
        void emitString(string value);
        void emitArray(object[] array);
        void emitObject(object obj);
        void append(object value);
    }

    [Imported]
    public interface IStringPrettyPrinter : IPrettyPrinter
    {
    }

    [Imported]
    public class Queue
    {
        private Queue(object env){ }

        public Env env;
        public bool[] ensured;
        public IBlock[] blocks;
        public bool running;
        public int index;
        public int offset;
        public bool abort;

        public void addBefore(IBlock block) { }
        public void addBefore(IBlock block, bool ensure) { }
        public void add(object block) { }
        public void add(object block, bool ensure) { }
        public void insertNext(object block) { }
        public void insertNext(object block, bool ensure) { }
        public void start() { }
        public void start(Action onComplete) { }
        public bool isRunning()
        {
            return false;
        }
        public void next_() { }

        public NestedResults results()
        {
            return null;
        }
    }
    
    public class Reporter
    {
        public void reportRunnerStarting(IRunner runner) { }
        public void reportRunnerResults(IRunner runner) { }
        public void reportSuiteResults(Suite suite) { }
        public void reportSpecStarting(Spec spec) { }
        public void reportSpecResults(Spec spec) { }
        public void log(string str) { }
    }

    [Imported]
    public class MultiReporter : Reporter
    {
        public void addReporter(Reporter reporter) { }
    }

    [Imported]
    public interface IRunner
    {
        object Runner(Env env);

        void execute();
        void beforeEach(SpecFunction beforeEachFunction);
        void afterEach(SpecFunction afterEachFunction);
        void beforeAll(SpecFunction beforeAllFunction);
        void afterAll(SpecFunction afterAllFunction);
        void finishCallback();
        void addSuite(Suite suite);
        void add(IBlock block);
        Spec[] specs();
        Suite[] suites();
        Suite[] topLevelSuites();
        NestedResults results();
    }
    
    public delegate void SpecFunction(Spec spec = null); //TODO overload?

    [Imported]
    public class SuiteOrSpec
    {
        public int id;
        public Env env;
        public string description;
        public Queue queue;
    }

    [Imported]
    public class Spec : SuiteOrSpec
    {

        private Spec(Env env, Suite suite, string description) { }

        public Suite suite;

        public SpecFunction[] afterCallbacks;
        public Spy[] spies_;

        public NestedResults results_;
        public Matchers matchersClass;

        public string getFullName()
        {
            return null;
        }
        public NestedResults results()
        {
            return null;
        }
        public object log(object arguments)
        {
            return null;
        }
        public Spec runs(SpecFunction func)
        {
            return null;
        }
        public void addToQueue(IBlock block) { }
        public void addMatcherResult(Result result) { }
        public object expect(object actual)
        {
            return null;
        }
        public Spec waits(int timeout)
        {
            return null;
        }
        public Spec waitsFor(SpecFunction latchFunction, string timeoutMessage = null, int timeout = 0)
        {
            return null;
        }
        public void fail() { }
        public void fail(object e) { }
        public Matchers getMatchersClass_()
        {
            return null;
        }
        public void addMatchers(object matchersPrototype) { }
        public void finishCallback() { }
        public void finish() { }
        public void finish(Action onComplete) { }
        public void after(SpecFunction doAfter) { }
        public object execute()
        {
            return null;
        }
        public object execute(Action onComplete)
        {
            return null;
        }
        public void addBeforesAndAftersToQueue() { }
        public void explodes() { }
        public Spy spyOn(object obj, string methodName, bool ignoreMethodDoesntExist)
        {
            return null;
        }
        public void removeAllSpies() { }
    }

    [Imported]
    public class XSpec
    {
        private XSpec() { }

        public int id;
        public void runs() { }
    }

    [Imported]
    public class Suite : SuiteOrSpec
    {

        private Suite(Env env, string description, Action specDefinitions, Suite parentSuite) { }

        public Suite parentSuite;

        public string getFullName()
        {
            return null;
        }
        public void finish() { }
        public void finish(Action onComplete) { }
        public void beforeEach(SpecFunction beforeEachFunction) { }
        public void afterEach(SpecFunction afterEachFunction) { }
        public void beforeAll(SpecFunction beforeAllFunction) { }
        public void afterAll(SpecFunction afterAllFunction) { }
        public NestedResults results()
        {
            return null;
        }
        public void add(SuiteOrSpec suiteOrSpec) { }
        public Spec[] specs()
        {
            return null;
        }
        public Suite[] suites()
        {
            return null;
        }
        public object[] children()
        {
            return null;
        }
        public void execute() { }
        public void execute(Action onComplete) { }
    }

    [Imported]
    public interface IXSuite
    {
        void execute();
    }

    [Imported]
    public interface ISpyAnd
    {
        string identity();
        Spy callThrough();
        Spy returnValue(object val);
        Spy callFake(Function fn);
        void throwError(string msg);
        Spy stub();
    }

    [Imported]
    public interface ICalls
    {
        bool any();
        int count();
        object[] argsFor(int index);
        object[][] allArgs();
        SpyCall[] all();
        SpyCall mostRecent();
        SpyCall first();
        void reset();
    }

    [Imported]
    [PreserveMemberCase(false)]
    public sealed class SpyCall
    {
        private SpyCall() { }

        public object[] Args;
        public object Object;
    }
    
    public class JsApiReporter : Reporter
    {

        public bool started;
        public bool finished;
        public object result;
        public object messages;

        public Action<IReporterSuiteInfo> jasmineStarted;
        public Action jasmineDone;
        public Action<IReporterResult> suiteStarted;
        public Action<IReporterResult> suiteDone;
        public Action<IReporterResult> specStarted;
        public Action<IReporterResult> specDone;

        public JsApiReporter() { }

        public Suite[] suites()
        {
            return null;
        }
        public object summarize_(SuiteOrSpec suiteOrSpec)
        {
            return null;
        }
        public object results()
        {
            return null;
        }
        public object resultsForSpec(object specId)
        {
            return null;
        }
        public object log(object str)
        {
            return null;
        }
        public object resultsForSpecs(object specIds)
        {
            return null;
        }
        public object summarizeResult_(object result)
        {
            return null;
        }
    }

    [PreserveMemberCase]
    public class IReporterSuiteInfo
    {
        public int totalSpecsDefined;
    }

    [PreserveMemberCase]
    public class IReporterResult
    {
        public int id;
        public string fullName;
        public string description;
        public string status;
        public IReporterError[] failedExpectations;
    }

    [PreserveMemberCase]
    public class IReporterError
    {
        public int id;
        public string stack;
        public string message;
    }
}