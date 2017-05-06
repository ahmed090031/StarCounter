// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "AgencyJson.json"
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
using __TArray__ = global::Starcounter.Templates.TArray<CompanyJson>;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __AgAddNewCo__ = global::Muhammad.AgencyJson.Input.AddNewCompanyTrigger;
using __AgSaveTrig__ = global::Muhammad.AgencyJson.Input.SaveTrigger;
using __AgName__ = global::Muhammad.AgencyJson.Input.Name;
using __AgHtml__ = global::Muhammad.AgencyJson.Input.Html;
using __AgencyJs2__ = global::Muhammad.AgencyJson.Input;
using __Arr__ = global::Starcounter.Arr<CompanyJson>;
using __AgencyJs1__ = global::Muhammad.AgencyJson.JsonByExample;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __CoSchema__ = CompanyJson.JsonByExample.Schema;
using __CompanyJ__ = CompanyJson;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __AgSchema__ = global::Muhammad.AgencyJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __AgencyJs__ = global::Muhammad.AgencyJson;
using __CompanyJ1__ = CompanyJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class AgencyJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class AgencyJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __AgSchema__ DefaultTemplate = new __AgSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AgencyJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AgencyJson(__AgSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __AgSchema__ Template { get { return (__AgSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__AgencyJs__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Muhammad/AgencyJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__AgencyJs__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__AgencyJs__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__AgencyJs__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__AgencyJs__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__AgencyJs__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__AgencyJs__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (AgencyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((AgencyJson)pup).Handle((Input.SaveTrigger)input); });
                Companies = Add<__TArray__>("Companies");
                Companies.SetCustomGetElementType((arr) => { return __CompanyJ__.DefaultTemplate;});
                Companies.SetCustomAccessors((_p_) => { return ((__AgencyJs__)_p_).__bf__Companies__; }, (_p_, _v_) => { ((__AgencyJs__)_p_).__bf__Companies__ = (__Arr__)_v_; }, false);
                AddNewCompanyTrigger = Add<__TLong__>("AddNewCompanyTrigger$");
                AddNewCompanyTrigger.DefaultValue = 0L;
                AddNewCompanyTrigger.Editable = true;
                AddNewCompanyTrigger.SetCustomAccessors((_p_) => { return ((__AgencyJs__)_p_).__bf__AddNewCompanyTrigger__; }, (_p_, _v_) => { ((__AgencyJs__)_p_).__bf__AddNewCompanyTrigger__ = (System.Int64)_v_; }, false);
                AddNewCompanyTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddNewCompanyTrigger() { App = (AgencyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((AgencyJson)pup).Handle((Input.AddNewCompanyTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __AgencyJs__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ SaveTrigger;
            public __TArray__ Companies;
            public __TLong__ AddNewCompanyTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "AgencyJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "AgencyJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "AgencyJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "AgencyJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 4 "AgencyJson.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 4 "AgencyJson.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Companies__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Companies {
    #line 5 "AgencyJson.json"
        get {
        #line hidden
            return Template.Companies.Getter(this); }
        #line 5 "AgencyJson.json"
        set {
        #line hidden
            Template.Companies.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddNewCompanyTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddNewCompanyTrigger {
    #line 6 "AgencyJson.json"
        get {
        #line hidden
            return Template.AddNewCompanyTrigger.Getter(this); }
        #line 6 "AgencyJson.json"
        set {
        #line hidden
            Template.AddNewCompanyTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__AgencyJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__AgencyJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__AgencyJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddNewCompanyTrigger : Input<__AgencyJs__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
