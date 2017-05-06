// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "SaleJson.json"
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
using __SaleJson__ = global::Muhammad.SaleJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __SaSchema__ = global::Muhammad.SaleJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __SaleJson1__ = global::Muhammad.SaleJson.JsonByExample;
using __SaleJson2__ = global::Muhammad.SaleJson.Input;
using __SaHtml__ = global::Muhammad.SaleJson.Input.Html;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class SaleJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SaSchema__ DefaultTemplate = new __SaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SaleJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SaleJson(__SaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SaSchema__ Template { get { return (__SaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__SaleJson__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Muhammad/SaleJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__SaleJson__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__SaleJson__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Address = Add<__TObject__>("Address$");
                Address.SetCustomAccessors((_p_) => { return ((__SaleJson__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__SaleJson__)_p_).__bf__Address__ = (__Json__)_v_; }, false);
                Transaction = Add<__TObject__>("Transaction$");
                Transaction.SetCustomAccessors((_p_) => { return ((__SaleJson__)_p_).__bf__Transaction__; }, (_p_, _v_) => { ((__SaleJson__)_p_).__bf__Transaction__ = (__Json__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __SaleJson__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TObject__ Address;
            public __TObject__ Transaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "SaleJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "SaleJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ Address {
    #line 3 "SaleJson.json"
        get {
        #line hidden
            return (__Json__)Template.Address.Getter(this); }
        #line 3 "SaleJson.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__Transaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ Transaction {
    #line 4 "SaleJson.json"
        get {
        #line hidden
            return (__Json__)Template.Transaction.Getter(this); }
        #line 4 "SaleJson.json"
        set {
        #line hidden
            Template.Transaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__SaleJson__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class SaleJson_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
