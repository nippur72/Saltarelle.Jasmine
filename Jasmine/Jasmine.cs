using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

[assembly: PreserveMemberCase]

#pragma warning disable 1591   // disables missing XML documentation warning
namespace Jasmine
{
    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public sealed class Matchers
    {
        [Obsolete("Removed as of Jasmine 2.x")]
        public Matchers(Env env, object actual, Env spec, bool isNot = false) { }

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
    }

    public delegate IMatcherResult CustomMatcherComparer(
        CustomMatcherUtil util, object customEqualityTesters, object actual, object expected);

    [Imported]
    public interface IMatcherResult
    {
        // To return custom matcher results, you need to implement a class such as the one below and use it as the return type of the compare method in the matcher
        //[PreserveMemberCase(false)]
        //public sealed class MatcherResult : IMatcherResult
        //{
        //    public bool Pass;
        //    public string Message;

        //    public MatcherResult(bool pass, string message)
        //    {
        //        Pass = pass;
        //        Message = message;
        //    }
        //}
    }

    [Imported]
    public sealed class CustomMatcherUtil
    {
        // This class isn't actually present on the 'jasmine' object, so we prevent attempts to construct or extend it
        private CustomMatcherUtil() { }


        public string buildFailureMessage()
        {
            return null;
        }

        public bool contains(object haystack, object needle, object customTesters)
        {
            return false;
        }

        public bool equals(object a, object b, object customTesters)
        {
            return false;
        }
    }

    [Imported]
    public sealed class Spy
    {
        [InlineCode("jasmine.createSpy({name}, {originalFunction})")]
        public Spy(string name, Delegate originalFunction) { }

        [InlineCode("jasmine.createSpy({name})")]
        public Spy(string name) { }

        [InlineCode("jasmine.createSpy()")]
        public Spy() { }

        public string identity;
        public CallTracker calls;
        public SpyStrategy and;
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

        [InlineCode("it({desc})")]
        public static void it(string desc) { }

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

        [InlineCode("iit({desc},{func})")]
        [Obsolete("Removed as of Jasmine 2.1")]
        public static void iit(string desc, Action func) { }

        [InlineCode("iit({desc},{func})")]
        [Obsolete("Removed as of Jasmine 2.1")]
        public static void iit(string desc, Action<Action> func) { }

        [InlineCode("iit({desc}, ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        [Obsolete("Removed as of Jasmine 2.1")]
        public static void iit(string desc, Func<Task> func) { }

        [InlineCode("xit({desc},{func})")]
        public static void xit(string desc, Action func) { }

        [InlineCode("xit({desc},{func})")]
        public static void xit(string desc, Action<Action> func) { }

        [InlineCode("xit({desc}, ss.mkdel(this, function(done) {{ {func}().continueWith(done); }}))")]
        public static void xit(string desc, Func<Task> func) { }

        [InlineCode("pending()")]
        public static void pending() { }

        [InlineCode("pending({reason})")]
        public static void pending(string reason) { }

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
        public static Spy createSpy(string name)
        {
            return null;
        }
        public static Spy createSpy(string name, Delegate originalFunction)
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
        public static Any any(object any)
        {
            return null;
        }

        [InlineCode("jasmine.objectContaining({sample})")]
        public static ObjectContaining objectContaining(object sample)
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

        [InlineCode("(function(){{var $m={matchers}; jasmine.addMatchers(Object.keys($m).reduce(function($acc,$key){{ $acc[$key]=function($u, $c) {{ return {{ compare: function($a, $e) {{ return $m[$key]($u, $c, $a, $e); }} }}; }}; return $acc; }}, {{}}));}})()")]
        public static void addMatchers(JsDictionary<string, CustomMatcherComparer> matchers) { }

        [InlineCode("(function(){{var $n={name}, $m={matcher}, $o={}; $o[$n]=function($u, $c) {{ return {{ compare: function($a, $e) {{ return $m($u, $c, $a, $e); }} }}; }}; jasmine.addMatchers($o);}})()")]
        public static void addMatcher(string name, CustomMatcherComparer matcher) { }

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

        public static double DEFAULT_TIMEOUT_INTERVAL
        {
            [InlineCode("jasmine.DEFAULT_TIMEOUT_INTERVAL")]
            get { return 5000; }
            [InlineCode("jasmine.DEFAULT_TIMEOUT_INTERVAL = {value}")]
            set { }
        }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class Clock
    {
        public Clock(object global, object delayedFunctionScheduler, Clock mockDate) { }

        public void install() { }

        public void uninstall() { }

        public void tick(int ms) { }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class Any
    {
        public Any(object expectedObject) { }

        public bool jasmineMatches(object other)
        {
            return false;
        }

        public string jasmineToString()
        {
            return null;
        }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class ObjectContaining
    {
        public ObjectContaining(object sample) { }

        public bool jasmineMatches(object other, object[] mismatchKeys, object[] mismatchValues)
        {
            return false;
        }

        public string jasmineToString()
        {
            return null;
        }
    }

    [Imported]
    public interface IBlock
    {
        void execute(Action onComplete);
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class Env
    {
        public Env(object options) { }

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
        public void addReporter(IJsApiReporter reporter) { }
        public void execute() { }
        public Suite describe(string description, Action specDefinitions)
        {
            return null;
        }
        public void beforeEach(Action beforeEachFunction) { }
        public void beforeAll(Action beforeAllFunction) { }
        public Runner currentRunner()
        {
            return null;
        }
        public void afterEach(Action afterEachFunction) { }
        public void afterAll(Action afterAllFunction) { }
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
    [ScriptNamespaceAttribute("jasmine")]
    public sealed class FakeTimer
    {
        public int nowMillis;
        public JsDictionary scheduledFunctions;
        public int timeoutsMade;

        [Obsolete("Removed as of Jasmine 2.x")]
        public FakeTimer()
        {

        }

        public int setInterval(Function funcToCall, int millis)
        {
            return 0;
        }

        public void clearInterval(int intervalKey) { }

        public int setTimeout(Function funcToCall, int millis)
        {
            return 0;
        }

        public void clearTimeout(int timeoutKey) { }

        public Action reset()
        {
            return null;
        }

        public Action tick(int millis)
        {
            return null;
        }

        public Action runFunctionsWithinRange(int oldMillis, int nowMillis)
        {
            return null;
        }

        public Action scheduleFunction(object timeoutKey, Action funcToCall, int millis, bool recurring)
        {
            return null;
        }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public sealed class HtmlReporter
    {
        public HtmlReporter(object options) { }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public sealed class HtmlSpecFilter
    {
        public HtmlSpecFilter(object options) { }
    }

    [Imported]
    public abstract class Result
    {
        protected Result() { }
        public string type;
    }

    [Imported]
    public sealed class NestedResults : Result
    {
        private NestedResults() { }

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
    public sealed class MessageResult : Result
    {
        private MessageResult() { }

        public object values;
        public Trace trace;
    }

    [Imported]
    public sealed class ExpectationResult : Result
    {
        private ExpectationResult() { }

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
    public sealed class Trace
    {
        private Trace() { }
        public string name;
        public string message;
        public object stack;
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public sealed class Queue
    {
        [Obsolete("Removed as of Jasmine 2.x")]
        public Queue(Env env) { }

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

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public sealed class Runner
    {
        [Obsolete("Removed as of Jasmine 2.x")]
        public Runner(Env env)
        {
        }

        public void execute() { }

        public void beforeEach(SpecFunction beforeEachFunction) { }
        public void afterEach(SpecFunction afterEachFunction) { }
        public void beforeAll(SpecFunction beforeAllFunction) { }
        public void afterAll(SpecFunction afterAllFunction) { }
        public void finishCallback() { }
        public void addSuite(Suite suite) { }
        public void add(IBlock block) { }
        public Spec[] specs()
        {
            return null;
        }

        public Suite[] suites()
        {
            return null;
        }

        public Suite[] topLevelSuites()
        {
            return null;
        }

        public NestedResults results()
        {
            return null;
        }
    }

    public delegate void SpecFunction(Spec spec = null);

    [Imported]
    public abstract class SuiteOrSpec
    {
        public int id;
        public string description;
        [Obsolete("Removed as of Jasmine 2.x")]
        public Queue queue;
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class Spec : SuiteOrSpec
    {
        [Obsolete("Removed as of Jasmine 2.x")]
        public Spec(Env env, Suite suite, string description) { }

        public Spec(object attrs) { }

        public Suite suite;

        [Obsolete("Removed as of Jasmine 2.x")]
        public Env env;

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
        [Obsolete("Removed as of Jasmine 2.x")]
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
        [Obsolete("Removed as of Jasmine 2.x")]
        public Spec waits(int timeout)
        {
            return null;
        }
        [Obsolete("Removed as of Jasmine 2.x")]
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
    public sealed class XSpec
    {
        private XSpec() { }

        public int id;
        public void runs() { }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class Suite : SuiteOrSpec
    {
        [Obsolete("Removed as of Jasmine 2.x")]
        public Suite(Env env, string description, Action specDefinitions, Suite parentSuite) { }

        public Suite(object attrs) { }

        public Suite parentSuite;
        public Env env;

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
    public sealed class XSuite
    {
        private XSuite()
        {
        }

        public void execute() { }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class SpyStrategy
    {
        public SpyStrategy(object options) { }

        public string identity() { return null; }
        public Spy callThrough() { return null; }
        public Spy returnValue(object val) { return null; }
        [ExpandParams]
        public Spy returnValues(params object[] values) { return null; }
        public Spy callFake(Function fn) { return null; }
        public void throwError(string msg) { }
        public Spy stub() { return null; }
        public object exec() { return null; }
    }

    [Imported]
    [ScriptNamespaceAttribute("jasmine")]
    public class CallTracker
    {
        public CallTracker() { }

        public bool any()
        {
            return false;
        }

        public int count()
        {
            return 0;
        }

        public object[] argsFor(int index)
        {
            return null;
        }

        public object[][] allArgs()
        {
            return null;
        }

        public SpyCall[] all()
        {
            return null;
        }

        public SpyCall mostRecent()
        {
            return null;
        }

        public SpyCall first()
        {
            return null;
        }
        public void reset() { }
    }

    [Imported]
    [PreserveMemberCase(false)]
    public sealed class SpyCall
    {
        // This is not an actual jasmine class, so we prevent instantiation and extension
        private SpyCall() { }

        public object[] Args;
        public object Object;
    }

    [Imported]
    public interface IJsApiReporter
    {
        void jasmineStarted(ReporterSuiteInfo suiteInfo);
        void jasmineDone();
        void suiteStarted(ReporterResult result);
        void suiteDone(ReporterResult result);
        void specDone(ReporterResult result);
    }
    
    [Imported]
    public sealed class ReporterSuiteInfo
    {
        // This is not an actual jasmine class, so we prevent instantiation and extension
        private ReporterSuiteInfo() { }
        public int totalSpecsDefined;
    }

    [Imported]
    public sealed class ReporterResult
    {
        // This is not an actual jasmine class, so we prevent instantiation and extension
        private ReporterResult() { }
        public int id;
        public string fullName;
        public string description;
        public string status;
        public ReporterError[] failedExpectations;
    }

    [Imported]
    public sealed class ReporterError
    {
        // This is not an actual jasmine class, so we prevent instantiation and extension
        private ReporterError() { }
        public int id;
        public string stack;
        public string message;
    }
}