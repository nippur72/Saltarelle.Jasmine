using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Threading.Tasks;

[assembly: PreserveMemberCase]

#pragma warning disable 1591   // disables missing XML documentation warning

namespace Jasmine
{
    [Imported]
    public class Matcher
    {
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
        public SpyCall[] calls;
        public Spy andCallThrough() { return null; }
        public Spy andReturn(object o) { return null; }
        public Spy andCallFake<T>(Func<T> function) { return null; }
        [InlineCode("{this}({*args})")]
        public void Call(params object[] args) { }

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

        [InlineCode("jasmine.addMatchers({matcher})")]
        public static void addMatcher(object matcher) { } //TODO: create a Matcher interface that is a function that return an object that has a compar node, which returns a result object 

        // clock mock

        // async support
        [InlineCode("runs({func})")]
        public static void runs(Action func) { }

        [InlineCode("waitsFor({func},{failure_message},{timeout})")]
        public static void waitsFor(Func<bool> func, string failure_message, int timeout) { }

        [InlineCode("waitsFor({func},'',{timeout})")]
        public static void waitsFor(Func<bool> func, int timeout) { }

        [InlineCode("waitsFor({func})")]
        public static void waitsFor(Func<bool> func) { }
    }

    public class Clock
    {
        [InlineCode("install()")]
        public void install() { }

        [InlineCode("uninstall()")]
        public void uninstall() { }

        [InlineCode("tick({ms})")]
        public void tick(int ms) { }
    }
    public interface IAny
    {
        bool jasmineMatches(object other);
        string jasmineToString();
    }

    public interface IObjectContaining
    {
        bool jasmineMatches(object other, object[] mismatchKeys, object[] mismatchValues);
        string jasmineToString();
    }
}

public static class jasmine
{
    [InlineCode("jasmine.clock()")]
    public static Jasmine.Clock clock()
    {
        return null;
    }

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

    public static dynamic createSpyObj(string baseName, string[] methodNames)
    {
        return null;
    }

    [InlineCode("jasmine.createSpyObj({baseName}, {methodNames})")]
    public static T createSpyObj<T>(string baseName, string[] methodNames)
    {
        return default(T);
    }

    /*
    TODO:
    function pp(value: any): string;
    function getEnv(): Env;
    function addMatchers(matchers: any): Any;

    interface Block {

        new (env: Env, func: SpecFunction, spec: Spec): any;

        execute(onComplete: () => void): void;
    }

    interface WaitsBlock extends Block {
        new (env: Env, timeout: number, spec: Spec): any;
    }

    interface WaitsForBlock extends Block {
        new (env: Env, timeout: number, latchFunction: SpecFunction, message: string, spec: Spec): any;
    }

    interface Env
    {
        setTimeout: any;
            clearTimeout: void;
            setInterval: any;
            clearInterval: void;
            updateInterval: number;

            currentSpec: Spec;

            matchersClass: Matchers;

            version(): any;
            versionString(): string;
            nextSpecId(): number;
            addReporter(reporter: Reporter): void;
            execute(): void;
            describe(description: string, specDefinitions: () => void): Suite;
            // ddescribe(description: string, specDefinitions: () => void): Suite; Not a part of jasmine. Angular team adds these
            beforeEach(beforeEachFunction: () => void): void;
            beforeAll(beforeAllFunction: () => void): void;
            currentRunner(): Runner;
            afterEach(afterEachFunction: () => void): void;
            afterAll(afterAllFunction: () => void): void;
            xdescribe(desc: string, specDefinitions: () => void): XSuite;
            it(description: string, func: () => void): Spec;
            // iit(description: string, func: () => void): Spec; Not a part of jasmine. Angular team adds these
            xit(desc: string, func: () => void): XSpec;
            compareRegExps_(a: RegExp, b: RegExp, mismatchKeys: string[], mismatchValues: string[]): boolean;
            compareObjects_(a: any, b: any, mismatchKeys: string[], mismatchValues: string[]): boolean;
            equals_(a: any, b: any, mismatchKeys: string[], mismatchValues: string[]): boolean;
            contains_(haystack: any, needle: any): boolean;
            addEqualityTester(equalityTester: (a: any, b: any, env: Env, mismatchKeys: string[], mismatchValues: string[]) => boolean): void;
            specFilter(spec: Spec): boolean;
        }

    interface FakeTimer
    {

        new (): any;

            reset(): void;
            tick(millis: number): void;
            runFunctionsWithinRange(oldMillis: number, nowMillis: number): void;
            scheduleFunction(timeoutKey: any, funcToCall: () => void, millis: number, recurring: boolean): void;
        }

    interface HtmlReporter
    {
        new (): any;
        }

    interface HtmlSpecFilter
    {
        new (): any;
        }

    interface Result
    {
        type: string;
        }

    interface NestedResults extends Result
    {
        description: string;

        totalCount: number;
        passedCount: number;
        failedCount: number;

        skipped: boolean;

        rollupCounts(result: NestedResults): void;
        log(values: any): void;
        getItems(): Result[];
        addResult(result: Result): void;
        passed(): boolean;
    }

    interface MessageResult extends Result
    {
        values: any;
        trace: Trace;
    }

    interface ExpectationResult extends Result
    {
        matcherName: string;
        passed(): boolean;
        expected: any;
        actual: any;
        message: string;
        trace: Trace;
    }

    interface Trace
    {
        name: string;
            message: string;
            stack: any;
        }

    interface PrettyPrinter
    {

        new (): any;

            format(value: any): void;
            iterateObject(obj: any, fn: (property: string, isGetter: boolean) => void): void;
            emitScalar(value: any): void;
            emitString(value: string): void;
            emitArray(array: any[]): void;
            emitObject(obj: any): void;
            append(value: any): void;
        }

    interface StringPrettyPrinter extends PrettyPrinter
    {
    }

    interface Queue
    {

        new (env: any): any;

            env: Env;
            ensured: boolean[];
            blocks: Block[];
            running: boolean;
            index: number;
            offset: number;
            abort: boolean;

            addBefore(block: Block, ensure?: boolean): void;
            add(block: any, ensure?: boolean): void;
            insertNext(block: any, ensure?: boolean): void;
            start(onComplete?: () => void): void;
            isRunning(): boolean;
            next_(): void;
            results(): NestedResults;
        }

    interface Matchers
    {

        new (env: Env, actual: any, spec: Env, isNot?: boolean): any;

            env: Env;
            actual: any;
            spec: Env;
            isNot?: boolean;
            message(): any;

            toBe(expected: any): boolean;
            toEqual(expected: any): boolean;
            toMatch(expected: any): boolean;
            toBeDefined(): boolean;
            toBeUndefined(): boolean;
            toBeNull(): boolean;
            toBeNaN(): boolean;
            toBeTruthy(): boolean;
            toBeFalsy(): boolean;
            toHaveBeenCalled(): boolean;
            toHaveBeenCalledWith(...params: any[]): boolean;
            toContain(expected: any): boolean;
            toBeLessThan(expected: any): boolean;
            toBeGreaterThan(expected: any): boolean;
            toBeCloseTo(expected: any, precision: any): boolean;
            toContainHtml(expected: string): boolean;
            toContainText(expected: string): boolean;
            toThrow(expected?: any): boolean;
            toThrowError(expected?: any): boolean;
            not: Matchers;

            Any: Any;
        }

    interface Reporter
    {
            reportRunnerStarting(runner: Runner): void;
            reportRunnerResults(runner: Runner): void;
            reportSuiteResults(suite: Suite): void;
            reportSpecStarting(spec: Spec): void;
            reportSpecResults(spec: Spec): void;
            log(str: string): void;
        }

    interface MultiReporter extends Reporter
    {
        addReporter(reporter: Reporter): void;
    }

    interface Runner
    {

        new (env: Env): any;

            execute(): void;
            beforeEach(beforeEachFunction: SpecFunction): void;
            afterEach(afterEachFunction: SpecFunction): void;
            beforeAll(beforeAllFunction: SpecFunction): void;
            afterAll(afterAllFunction: SpecFunction): void;
            finishCallback(): void;
            addSuite(suite: Suite): void;
            add(block: Block): void;
            specs(): Spec[];
            suites(): Suite[];
            topLevelSuites(): Suite[];
            results(): NestedResults;
        }

    interface SpecFunction
    {
            (spec?: Spec): void;
        }

    interface SuiteOrSpec
    {
        id: number;
            env: Env;
            description: string;
            queue: Queue;
        }

    interface Spec extends SuiteOrSpec
    {

        new (env: Env, suite: Suite, description: string): any;

        suite: Suite;

        afterCallbacks: SpecFunction[];
        spies_: Spy[];

        results_: NestedResults;
        matchersClass: Matchers;

        getFullName(): string;
        results(): NestedResults;
        log(arguments: any): any;
        runs(func: SpecFunction): Spec;
        addToQueue(block: Block): void;
        addMatcherResult(result: Result): void;
        expect(actual: any): any;
        waits(timeout: number): Spec;
        waitsFor(latchFunction: SpecFunction, timeoutMessage?: string, timeout?: number): Spec;
        fail(e?: any): void;
        getMatchersClass_(): Matchers;
        addMatchers(matchersPrototype: any): void;
        finishCallback(): void;
        finish(onComplete?: () => void): void;
        after(doAfter: SpecFunction): void;
        execute(onComplete?: () => void): any;
        addBeforesAndAftersToQueue(): void;
        explodes(): void;
        spyOn(obj: any, methodName: string, ignoreMethodDoesntExist: boolean): Spy;
        removeAllSpies(): void;
    }

    interface XSpec
    {
        id: number;
            runs(): void;
        }

    interface Suite extends SuiteOrSpec
    {

        new (env: Env, description: string, specDefinitions: () => void, parentSuite: Suite): any;

        parentSuite: Suite;

        getFullName(): string;
        finish(onComplete?: () => void): void;
        beforeEach(beforeEachFunction: SpecFunction): void;
        afterEach(afterEachFunction: SpecFunction): void;
        beforeAll(beforeAllFunction: SpecFunction): void;
        afterAll(afterAllFunction: SpecFunction): void;
        results(): NestedResults;
        add(suiteOrSpec: SuiteOrSpec): void;
        specs(): Spec[];
        suites(): Suite[];
        children(): any[];
        execute(onComplete?: () => void): void;
    }

    interface XSuite
    {
            execute(): void;
        }

    interface Spy
    {
        (...params: any[]): any;

        identity: string;
        and: SpyAnd;
        calls: Calls;
        mostRecentCall: { args: any[]; };
        argsForCall: any[];
        wasCalled: boolean;
        callCount: number;
    }

        interface SpyAnd
    {
        callThrough(): Spy;
        returnValue(val: any): void;
        callFake(fn: Function): Spy;
        throwError(msg: string): void;
        stub(): Spy;
    }

    interface Calls
    {
        any(): boolean;
        count(): number;
        argsFor(index: number): any[];
        allArgs(): any[];
        all(): any;
        mostRecent(): any;
        first(): any;
        reset(): void;
    }

    interface Util
    {
        inherit(childClass: Function, parentClass: Function): any;
        formatException(e: any): any;
        htmlEscape(str: string): string;
        argsToArray(args: any): any;
        extend(destination: any, source: any): any;
    }

    interface JsApiReporter extends Reporter
    {

        started: boolean;
        finished: boolean;
        result: any;
        messages: any;

        new (): any;

        suites(): Suite[];
        summarize_(suiteOrSpec: SuiteOrSpec): any;
        results(): any;
        resultsForSpec(specId: any): any;
        log(str: any): any;
        resultsForSpecs(specIds: any): any;
        summarizeResult_(result: any): any;
    }

    interface Jasmine
    {
        Spec: Spec;
        clock: Clock;
        util: Util;
    }

    export var HtmlReporter: HtmlReporter;
    export var HtmlSpecFilter: HtmlSpecFilter;
    export var DEFAULT_TIMEOUT_INTERVAL: number;
    */
}




