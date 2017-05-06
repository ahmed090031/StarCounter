// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CompanyJson.json"
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
using __TArray__ = global::Starcounter.Templates.TArray<SaleJson>;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoNewSaleT__ = global::Muhammad.CompanyJson.Input.NewSaleTrigger;
using __CoName__ = global::Muhammad.CompanyJson.Input.Name;
using __CoHtml__ = global::Muhammad.CompanyJson.Input.Html;
using __CompanyJ2__ = global::Muhammad.CompanyJson.Input;
using __Arr__ = global::Starcounter.Arr<SaleJson>;
using __CompanyJ1__ = global::Muhammad.CompanyJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __SaleJson1__ = SaleJson.JsonByExample;
using __SaSchema__ = SaleJson.JsonByExample.Schema;
using __SaleJson__ = SaleJson;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Muhammad.CompanyJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __CompanyJ__ = global::Muhammad.CompanyJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CompanyJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CompanyJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CompanyJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CompanyJson(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__CompanyJ__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Muhammad/CompanyJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Address = Add<__TObject__>("Address$");
                Address.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__Address__ = (__Json__)_v_; }, false);
                Sales = Add<__TArray__>("Sales$");
                Sales.Editable = true;
                Sales.SetCustomGetElementType((arr) => { return __SaleJson__.DefaultTemplate;});
                Sales.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__Sales__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__Sales__ = (__Arr__)_v_; }, false);
                NewSaleTrigger = Add<__TLong__>("NewSaleTrigger$");
                NewSaleTrigger.DefaultValue = 0L;
                NewSaleTrigger.Editable = true;
                NewSaleTrigger.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__NewSaleTrigger__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__NewSaleTrigger__ = (System.Int64)_v_; }, false);
                NewSaleTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.NewSaleTrigger() { App = (CompanyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CompanyJson)pup).Handle((Input.NewSaleTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __CompanyJ__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TObject__ Address;
            public __TArray__ Sales;
            public __TLong__ NewSaleTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CompanyJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CompanyJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "CompanyJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "CompanyJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ Address {
    #line 4 "CompanyJson.json"
        get {
        #line hidden
            return (__Json__)Template.Address.Getter(this); }
        #line 4 "CompanyJson.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Sales__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Sales {
    #line 5 "CompanyJson.json"
        get {
        #line hidden
            return Template.Sales.Getter(this); }
        #line 5 "CompanyJson.json"
        set {
        #line hidden
            Template.Sales.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewSaleTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewSaleTrigger {
    #line 6 "CompanyJson.json"
        get {
        #line hidden
            return Template.NewSaleTrigger.Getter(this); }
        #line 6 "CompanyJson.json"
        set {
        #line hidden
            Template.NewSaleTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewSaleTrigger : Input<__CompanyJ__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
