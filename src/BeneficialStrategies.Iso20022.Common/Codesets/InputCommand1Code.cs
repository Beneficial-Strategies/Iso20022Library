// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of requested input
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DmePIN6oEeiwsev40qZGEQ")]
[Description(@"Type of requested input")]
[DerivedFrom(typeof(InputCommandCode))]
public enum InputCommand1Code
{
    /// <summary>
    /// Wait for a string of digit characters with a decimal point, the length range could be specified.
    /// Encoded/decoded by serializers as &quot;DCSG&quot;.
    /// </summary>
    [EnumMember(Value = "DCSG")]
    [IsoId("_ezGMUO2tEei-V5h0ja04AA")]
    [Description(@"Wait for a string of digit characters with a decimal point, the length range could be specified.")]
    DecimalString = InputCommandCode.DecimalString, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wait for a string of digit characters.
    /// Encoded/decoded by serializers as &quot;DGSG&quot;.
    /// </summary>
    [EnumMember(Value = "DGSG")]
    [IsoId("_e4fCoe2tEei-V5h0ja04AA")]
    [Description(@"Wait for a string of digit characters.")]
    DigitString = InputCommandCode.DigitString, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wait for a key pressed on the Terminal, to be able to read the message displayed on the Terminal.
    /// Encoded/decoded by serializers as &quot;GAKY&quot;.
    /// </summary>
    [EnumMember(Value = "GAKY")]
    [IsoId("_e-ztEe2tEei-V5h0ja04AA")]
    [Description(@"Wait for a key pressed on the Terminal, to be able to read the message displayed on the Terminal.")]
    GetAnyKey = InputCommandCode.GetAnyKey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wait for a confirmation Yes (Y) or No (N) on the Sale System. Wait for a confirmation (Valid or Cancel button) on the POI Terminal. The result of the command is a Boolean: True or False.
    /// Encoded/decoded by serializers as &quot;GCNF&quot;.
    /// </summary>
    [EnumMember(Value = "GCNF")]
    [IsoId("_fFTWoe2tEei-V5h0ja04AA")]
    [Description(@"Wait for a confirmation Yes (Y) or No (N) on the Sale System. Wait for a confirmation (Valid or Cancel button) on the POI Terminal. The result of the command is a Boolean: True or False.")]
    GetConfirmation = InputCommandCode.GetConfirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wait for a function key pressed on the Terminal: From POI, Valid, Clear, Correct, Generic Function key number. From Sale, Generic Function key.
    /// Encoded/decoded by serializers as &quot;GFKY&quot;.
    /// </summary>
    [EnumMember(Value = "GFKY")]
    [IsoId("_fL8xMe2tEei-V5h0ja04AA")]
    [Description(@"Wait for a function key pressed on the Terminal: From POI, Valid, Clear, Correct, Generic Function key number. From Sale, Generic Function key.")]
    GetFunctionKey = InputCommandCode.GetFunctionKey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To choose an entry among a list of entries (all of them are not necessary selectable). The OutputFormat has to be MenuEntry.
    /// Encoded/decoded by serializers as &quot;GMNE&quot;.
    /// </summary>
    [EnumMember(Value = "GMNE")]
    [IsoId("_fQxm0e2tEei-V5h0ja04AA")]
    [Description(@"To choose an entry among a list of entries (all of them are not necessary selectable). The OutputFormat has to be MenuEntry.")]
    GetMenuEntry = InputCommandCode.GetMenuEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to enter a password with masked characters while typing the password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_fV1tAe2tEei-V5h0ja04AA")]
    [Description(@"Request to enter a password with masked characters while typing the password.")]
    Password = InputCommandCode.Password, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wait for a confirmation Yes (Y) or No (N) of the Site Manager on the Sale System.
    /// Encoded/decoded by serializers as &quot;SITE&quot;.
    /// </summary>
    [EnumMember(Value = "SITE")]
    [IsoId("_faotce2tEei-V5h0ja04AA")]
    [Description(@"Wait for a confirmation Yes (Y) or No (N) of the Site Manager on the Sale System.")]
    SiteManager = InputCommandCode.SiteManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wait for a string of alphanumeric characters.
    /// Encoded/decoded by serializers as &quot;TXSG&quot;.
    /// </summary>
    [EnumMember(Value = "TXSG")]
    [IsoId("_ffbG0e2tEei-V5h0ja04AA")]
    [Description(@"Wait for a string of alphanumeric characters.")]
    TextString = InputCommandCode.TextString, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wait for a XHTML data.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("_fkPVYO2tEei-V5h0ja04AA")]
    [Description(@"Wait for a XHTML data.")]
    XHTMLText = InputCommandCode.XHTMLText, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to wait for signature.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_v0ROUe2tEei-V5h0ja04AA")]
    [Description(@"Request to wait for signature.")]
    Signature = InputCommandCode.Signature, // same ordinal as derivation source for type conversions
    
}
