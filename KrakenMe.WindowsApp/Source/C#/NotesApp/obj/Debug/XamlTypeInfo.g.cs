﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace KrakenMe.WindowsApp
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.String fullName)
        {
            if(_provider == null)
            {
                _provider = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace NotesApp.KrakenMe_WindowsApp_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            string standardName;
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (global::System.String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (global::System.String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType> _xamlTypes = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();
        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember> _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();
        global::System.Collections.Generic.Dictionary<global::System.Type, string> _xamlTypeToStandardName = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

        private void AddToMapOfTypeToStandardName(global::System.Type t, global::System.String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_LayoutAwarePage() { return new global::KrakenMe.WindowsApp.Common.LayoutAwarePage(); }

        private object Activate_1_CalenderPage() { return new global::KrakenMe.WindowsApp.CalenderPage(); }

        private object Activate_2_HubPage() { return new global::KrakenMe.WindowsApp.HubPage(); }

        private object Activate_3_Login() { return new global::KrakenMe.WindowsApp.Login(); }

        private object Activate_4_OverduePage() { return new global::KrakenMe.WindowsApp.OverduePage(); }

        private object Activate_5_AboutUs() { return new global::KrakenMe.WindowsApp.SettingsFlyouts.AboutUs(); }

        private object Activate_6_ContactUs() { return new global::KrakenMe.WindowsApp.SettingsFlyouts.ContactUs(); }

        private object Activate_7_PrivacyPolicy() { return new global::KrakenMe.WindowsApp.SettingsFlyouts.PrivacyPolicy(); }

        private object Activate_8_TermsAndConditions() { return new global::KrakenMe.WindowsApp.SettingsFlyouts.TermsAndConditions(); }

        private object Activate_9_TaskPage() { return new global::KrakenMe.WindowsApp.TaskPage(); }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(string typeName)
        {
            global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType userType;

            switch (typeName)
            {
            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Page));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.UserControl));
                break;

            case "KrakenMe.WindowsApp.Common.LayoutAwarePage":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.Common.LayoutAwarePage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_LayoutAwarePage;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.CalenderPage":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.CalenderPage), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_1_CalenderPage;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.HubPage":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.HubPage), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_2_HubPage;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.Login":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.Login), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_3_Login;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.OverduePage":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.OverduePage), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_4_OverduePage;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.SettingsFlyouts.AboutUs":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.SettingsFlyouts.AboutUs), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_5_AboutUs;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.SettingsFlyouts.ContactUs":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.SettingsFlyouts.ContactUs), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_6_ContactUs;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.SettingsFlyouts.PrivacyPolicy":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.SettingsFlyouts.PrivacyPolicy), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_7_PrivacyPolicy;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.SettingsFlyouts.TermsAndConditions":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.SettingsFlyouts.TermsAndConditions), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_8_TermsAndConditions;
                xamlType = userType;
                break;

            case "KrakenMe.WindowsApp.TaskPage":
                userType = new global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::KrakenMe.WindowsApp.TaskPage), GetXamlTypeByName("KrakenMe.WindowsApp.Common.LayoutAwarePage"));
                userType.Activator = Activate_9_TaskPage;
                xamlType = userType;
                break;

            }
            return xamlType;
        }



        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlMember xamlMember = null;
            // No Local Properties
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(global::System.String input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlSystemBaseType
    {
        global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public global::System.Object CreateFromString(global::System.String input)
        {
            if (_enumValues != null)
            {
                global::System.Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    global::System.Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( global::System.String.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::NotesApp.KrakenMe_WindowsApp_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(global::System.String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


