// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "TransactionJson.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Muhammad {
using __Transact2__ = global::Muhammad.TransactionJson.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __TrCommissi__ = global::Muhammad.TransactionJson.Input.Commission;
using __TrSalesPri__ = global::Muhammad.TransactionJson.Input.SalesPrice;
using __TrDate__ = global::Muhammad.TransactionJson.Input.Date;
using __TrHtml__ = global::Muhammad.TransactionJson.Input.Html;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __TrSchema__ = global::Muhammad.TransactionJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Transact__ = global::Muhammad.TransactionJson;
using __Transact1__ = global::Muhammad.TransactionJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TransactionJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class TransactionJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __TrSchema__ DefaultTemplate = new __TrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TransactionJson(__TrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __TrSchema__ Template { get { return (__TrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Transact__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Muhammad/TransactionJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Date = Add<__TString__>("Date$");
                Date.DefaultValue = "";
                Date.Editable = true;
                Date.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                SalesPrice = Add<__TString__>("SalesPrice$");
                SalesPrice.DefaultValue = "";
                SalesPrice.Editable = true;
                SalesPrice.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__SalesPrice__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__SalesPrice__ = (System.String)_v_; }, false);
                Commission = Add<__TString__>("Commission$");
                Commission.DefaultValue = "";
                Commission.Editable = true;
                Commission.SetCustomAccessors((_p_) => { return ((__Transact__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Transact__)_p_).__bf__Commission__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Transact__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Date;
            public __TString__ SalesPrice;
            public __TString__ Commission;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "TransactionJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "TransactionJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Date__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Date {
    #line 3 "TransactionJson.json"
        get {
        #line hidden
            return Template.Date.Getter(this); }
        #line 3 "TransactionJson.json"
        set {
        #line hidden
            Template.Date.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SalesPrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SalesPrice {
    #line 4 "TransactionJson.json"
        get {
        #line hidden
            return Template.SalesPrice.Getter(this); }
        #line 4 "TransactionJson.json"
        set {
        #line hidden
            Template.SalesPrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Commission {
    #line 5 "TransactionJson.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 5 "TransactionJson.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Date : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalesPrice : Input<__Transact__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Transact__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
