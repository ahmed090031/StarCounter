// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "AddressJson.json"
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
using __AdHtml__ = global::Muhammad.AddressJson.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __AdCountry__ = global::Muhammad.AddressJson.Input.Country;
using __AdCity__ = global::Muhammad.AddressJson.Input.City;
using __AdZip__ = global::Muhammad.AddressJson.Input.Zip;
using __AdNumber__ = global::Muhammad.AddressJson.Input.Number;
using __AdStreet__ = global::Muhammad.AddressJson.Input.Street;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __AddressJ1__ = global::Muhammad.AddressJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __AdSchema__ = global::Muhammad.AddressJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __AddressJ__ = global::Muhammad.AddressJson;
using __AddressJ2__ = global::Muhammad.AddressJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class AddressJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class AddressJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __AdSchema__ DefaultTemplate = new __AdSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AddressJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AddressJson(__AdSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __AdSchema__ Template { get { return (__AdSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__AddressJ__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Muhammad/AddressJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__AddressJ__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__AddressJ__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__AddressJ__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__AddressJ__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TString__>("Number$");
                Number.DefaultValue = "";
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__AddressJ__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__AddressJ__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                Zip = Add<__TString__>("Zip$");
                Zip.DefaultValue = "";
                Zip.Editable = true;
                Zip.SetCustomAccessors((_p_) => { return ((__AddressJ__)_p_).__bf__Zip__; }, (_p_, _v_) => { ((__AddressJ__)_p_).__bf__Zip__ = (System.String)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__AddressJ__)_p_).__bf__City__; }, (_p_, _v_) => { ((__AddressJ__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__AddressJ__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__AddressJ__)_p_).__bf__Country__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __AddressJ__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Street;
            public __TString__ Number;
            public __TString__ Zip;
            public __TString__ City;
            public __TString__ Country;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "AddressJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "AddressJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 3 "AddressJson.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 3 "AddressJson.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Number {
    #line 4 "AddressJson.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 4 "AddressJson.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Zip__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Zip {
    #line 5 "AddressJson.json"
        get {
        #line hidden
            return Template.Zip.Getter(this); }
        #line 5 "AddressJson.json"
        set {
        #line hidden
            Template.Zip.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 6 "AddressJson.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 6 "AddressJson.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 7 "AddressJson.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 7 "AddressJson.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__AddressJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__AddressJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__AddressJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Zip : Input<__AddressJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class City : Input<__AddressJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__AddressJ__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
