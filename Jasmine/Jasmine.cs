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
    public class Matcher
    {
        private Matcher(Env env, object actual, Env spec, bool isNot = false) { }

        public Env env;
        public object actual;
        public Env spec;
        public bool isNot = false;
        public object message() { }

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
        public bool toThrow(object expected) { return false; }

        [IntrinsicProperty]
        public Matcher not { get { return null; } }

        // any matcher
        public IAny Any;

        // typeof matcher?
    }

    [Imported]
    public class SpyCall
    {
        public object[] args;
    }

    [Imported]
    public class Spy
    {
        public string identity;
        public SpyCall mostRecentCall;
        public Calls calls;
        public Spy andCallThrough() { return null; }
        public Spy andReturn(object o) { return null; }
        public Spy andCallFake<T>(Func<T> function) { return null; }
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
        public void pending() { }

        [InlineCode("expect({o})")]
        public Matcher expect(object o) { return null; }

        [InlineCode("expect({d})")]
        public Matcher expect(Delegate d) { return null; }

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
        public Spy createSpy(string name) { return null; }

        [InlineCode("jasmine.createSpyObj({name},{args})")]
        public Spy createSpyObj(string name, string[] args) { return null; }

        // clock mock

        // async support
        [InlineCode("runs({func})")]
        public static void runs(Action func) { }

        [InlineCode("waitsFor({func},{failure_message},{timeout})")]
        public static void waitsFor(Func<bool> func, string failureMessage, int timeout) { }

        [InlineCode("waitsFor({func},'',{timeout})")]
        public static void waitsFor(Func<bool> func, int timeout) { }

        [InlineCode("waitsFor({func})")]
        public static void waitsFor(Func<bool> func) { }
    }

    [Imported]
    public class Clock
    {
        [InlineCode("install()")]
        public void install() { }

        [InlineCode("uninstall()")]
        public void uninstall() { }

        [InlineCode("tick({ms})")]
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
    public interface Block
    {
        object Block(Env env, SpecFunction func, Spec spec);

        void execute(Action onComplete);
    }

    [Imported]
    public interface WaitsBlock : Block
    {
        object WaitsBlock(Env env, int timeout, Spec spec);
    }

    [Imported]
    public interface WaitsForBlock : Block
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

        public Matcher matchersClass;

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
        public Runner currentRunner()
        {
            return null;
        }
        public void afterEach(Action afterEachFunction){}
        public void afterAll(Action afterAllFunction){}
        public XSuite xdescribe(string desc, Action specDefinitions)
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
    public interface FakeTimer
    {
        object FakeTimer();

        Action reset();
        Action tick(int millis);
        Action runFunctionsWithinRange(int oldMillis, int nowMillis);
        Action scheduleFunction(object timeoutKey, Action funcToCall, int millis, bool recurring);
    }

    [Imported]
    public interface HtmlReporter
    {
        object HtmlReporter();
    }

    [Imported]
    public interface HtmlSpecFilter
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
    public interface PrettyPrinter
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
    public interface StringPrettyPrinter : PrettyPrinter
    {
    }

    [Imported]
    public class Queue
    {

        private Queue(object env){ }

        public Env env;
        public bool[] ensured;
        public Block[] blocks;
        public bool running;
        public int index;
        public int offset;
        public bool abort;

        public void addBefore(Block block, bool ensure = false) { }
        public void add(object block, bool ensure = false) { }
        public void insertNext(object block, bool ensure = false) { }
        public void start(Action onComplete = null) { }
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
        public void reportRunnerStarting(Runner runner) { }
        public void reportRunnerResults(Runner runner) { }
        public void reportSuiteResults(Suite suite) { }
        public void reportSpecStarting(Spec spec) { }
        public void reportSpecResults(Spec spec) { }
        public void log(string str) { }
    }

    public class MultiReporter : Reporter
    {
        public void addReporter(Reporter reporter) { }
    }

    public interface Runner
    {
        object Runner(Env env);

        void execute();
        void beforeEach(SpecFunction beforeEachFunction);
        void afterEach(SpecFunction afterEachFunction);
        void beforeAll(SpecFunction beforeAllFunction);
        void afterAll(SpecFunction afterAllFunction);
        void finishCallback();
        void addSuite(Suite suite);
        void add(Block block);
        Spec[] specs();
        Suite[] suites();
        Suite[] topLevelSuites();
        NestedResults results();
    }

    public delegate void SpecFunction(Spec spec = null);

    public class SuiteOrSpec
    {
        public int id;
        public Env env;
        public string description;
        public Queue queue;
    }

    public class Spec : SuiteOrSpec
    {

        private Spec(Env env, Suite suite, string description) { }

        public Suite suite;

        public SpecFunction[] afterCallbacks;
        public Spy[] spies_;

        public NestedResults results_;
        public Matcher matchersClass;

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
        public void addToQueue(Block block) { }
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
        public void fail(object e = null) { }
        public Matcher getMatchersClass_()
        {
            return null;
        }
        public void addMatchers(object matchersPrototype) { }
        public void finishCallback() { }
        public void finish(Action onComplete = null) { }
        public void after(SpecFunction doAfter) { }
        public object execute(Action onComplete = null)
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

    public class XSpec
    {
        private XSpec() { }

        public int id;
        public void runs() { }
    }

    public class Suite : SuiteOrSpec
    {

        private Suite(Env env, string description, Action specDefinitions, Suite parentSuite) { }

        public Suite parentSuite;

        public string getFullName()
        {
            return null;
        }
        public void finish(Action onComplete = null) { }
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
        public void execute(Action onComplete = null) { }
    }

    public interface XSuite
    {
        void execute();
    }

    public interface SpyAnd
    {
        Spy callThrough();
        void returnValue(object val);
        Spy callFake(Function fn);
        void throwError(string msg);
        Spy stub();
    }

    public interface Calls
    {
        bool any();
        int count();
        object[] argsFor(int index);
        object[] allArgs();
        object all();
        object mostRecent();
        object first();
        void reset();
    }

    public interface IUtil
    {
        object inherit(Function childClass, Function parentClass);
        object formatException(object e);
        string htmlEscape(string str);
        object argsToArray(object args);
        object extend(object destination, object source);
    }
    
    public class JsApiReporter : Reporter
    {

        public bool started;
        public bool finished;
        public object result;
        public object messages;

        private JsApiReporter() { }

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
}

public static class jasmine
{
    [InlineCode("jasmine.clock()")]
    public static Jasmine.Clock clock()
    {
        return null;
    }

    [InlineCode("jasmine.Spec()")]
    public static Jasmine.Spec Spec()
    {
        return null;
    }
    
    public static Jasmine.IUtil util;

    [InlineCode("jasmine.any({any})")]
    public static Jasmine.IAny any(object any)
    {
        return null;
    }

    [InlineCode("jasmine.objectContaining({sample})")]
    public static Jasmine.IObjectContaining objectContaining(object sample)
    {
        return null;
    }

    [InlineCode("jasmine.createSpy({name}, {originalFunction})")]
    public static Jasmine.Spy createSpy(string name, Delegate originalFunction = null)
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

    [InlineCode("jasmine.pp({value})")]
    public static string pp(object value)
    {
        return null;
    }

    [InlineCode("jasmine.getEnv()")]
    public static Jasmine.Env getEnv()
    {
        return null;
    }

    [InlineCode("jasmine.addMatchers({matcher})")]
    public static void addMatcher(object matcher) { } //TODO: create a Matcher interface that is a function that return an object that has a compar node, which returns a result object 


    /*
    TODO:    
    
    interface Jasmine
    {
        Spec: Spec;
        clock: Clock;
        util: IUtil;
    }

    export var HtmlReporter: HtmlReporter;
    export var HtmlSpecFilter: HtmlSpecFilter;
    export var DEFAULT_TIMEOUT_INTERVAL: number;
    */
}