using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;

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
      [ExpandParams] public bool toHaveBeenCalledWith(params object[] par) { return false; }      
      public bool toContain(object expected) { return false; }
      public bool toBeLessThan(object expected) { return false; }
      public bool toBeGreaterThan(object expected) { return false; }
      public bool toBeCloseTo(object expected, int precision) { return false; }
      public bool toThrow() { return false; }
      public bool toThrow(object expected) { return false; }

      [IntrinsicProperty]
      public Matcher not { get { return null;} }

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
      public void Call(params object[] args) {}
   }

   [IgnoreNamespace]
   [Imported]
   [ScriptName("Object")]     
   public class JasmineSuite
   {
      [InlineCode("{}")] public JasmineSuite() { }

      [InlineCode("describe({description},{specDefinitions})")]
      public static void describe(string description, Action specDefinitions) {}

      [InlineCode("xdescribe({description},{specDefinitions})")]
      public static void xdescribe(string description, Action specDefinitions) {}

      [InlineCode("it({desc},{func})")]
      public static void it(string desc, Action func) {}

      [InlineCode("xit({desc},{func})")]
      public static void xit(string desc, Action func) {}   

      [InlineCode("expect({o})")]
      public Matcher expect(object o) { return null; }

      [InlineCode("beforeEach({func})")]
      public static void beforeEach(Action func) { }

      [InlineCode("afterEach({func})")]
      public static void afterEach(Action func) { }

      [InlineCode("spyOn({o},{methodname})")]
      public static Spy spyOn(object o, string methodname) { return null; }

      [InlineCode("jasmine.createSpy({name})")]
      public Spy createSpy(string name) { return null; }
      
      [InlineCode("jasmine.createSpyObj({name},{args})")]
      public Spy createSpyObj(string name, string[] args) { return null; }

      // clock mock

      // async support: runs, waits, waitsFor
   }
}




