// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of requested input.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jBTTwN6nEeiwsev40qZGEQ")]
[Description(@"Type of requested input.")]
[Derivations(typeof(InputCommand1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InputCommandCode>))]
#endif
public enum InputCommandCode
{
    /// <summary>
    /// Wait for a key pressed on the Terminal, to be able to read the message displayed on the Terminal.
    /// Encoded/decoded by serializers as &quot;GAKY&quot;.
    /// </summary>
    [EnumMember(Value = "GAKY")]
    [IsoId("_mrXKsN6nEeiwsev40qZGEQ")]
    [Description(
        @"Wait for a key pressed on the Terminal, to be able to read the message displayed on the Terminal."
    )]
    GetAnyKey,

    /// <summary>
    /// Wait for a confirmation Yes (Y) or No (N) on the Sale System. Wait for a confirmation (Valid or Cancel button) on the POI Terminal. The result of the command is a Boolean: True or False.
    /// Encoded/decoded by serializers as &quot;GCNF&quot;.
    /// </summary>
    [EnumMember(Value = "GCNF")]
    [IsoId("_pVzXsN6nEeiwsev40qZGEQ")]
    [Description(
        @"Wait for a confirmation Yes (Y) or No (N) on the Sale System. Wait for a confirmation (Valid or Cancel button) on the POI Terminal. The result of the command is a Boolean: True or False."
    )]
    GetConfirmation,

    /// <summary>
    /// Wait for a confirmation Yes (Y) or No (N) of the Site Manager on the Sale System.
    /// Encoded/decoded by serializers as &quot;SITE&quot;.
    /// </summary>
    [EnumMember(Value = "SITE")]
    [IsoId("_s944sN6nEeiwsev40qZGEQ")]
    [Description(
        @"Wait for a confirmation Yes (Y) or No (N) of the Site Manager on the Sale System."
    )]
    SiteManager,

    /// <summary>
    /// Wait for a string of alphanumeric characters.
    /// Encoded/decoded by serializers as &quot;TXSG&quot;.
    /// </summary>
    [EnumMember(Value = "TXSG")]
    [IsoId("_vvbMMN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a string of alphanumeric characters.")]
    TextString,

    /// <summary>
    /// Wait for a string of digit characters.
    /// Encoded/decoded by serializers as &quot;DGSG&quot;.
    /// </summary>
    [EnumMember(Value = "DGSG")]
    [IsoId("_x6DQsN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a string of digit characters.")]
    DigitString,

    /// <summary>
    /// Wait for a string of digit characters with a decimal point, the length range could be specified.
    /// Encoded/decoded by serializers as &quot;DCSG&quot;.
    /// </summary>
    [EnumMember(Value = "DCSG")]
    [IsoId("_0N_CMN6nEeiwsev40qZGEQ")]
    [Description(
        @"Wait for a string of digit characters with a decimal point, the length range could be specified."
    )]
    DecimalString,

    /// <summary>
    /// Wait for a function key pressed on the Terminal: From POI, Valid, Clear, Correct, Generic Function key number. From Sale, Generic Function key.
    /// Encoded/decoded by serializers as &quot;GFKY&quot;.
    /// </summary>
    [EnumMember(Value = "GFKY")]
    [IsoId("_288i0N6nEeiwsev40qZGEQ")]
    [Description(
        @"Wait for a function key pressed on the Terminal: From POI, Valid, Clear, Correct, Generic Function key number. From Sale, Generic Function key."
    )]
    GetFunctionKey,

    /// <summary>
    /// To choose an entry among a list of entries (all of them are not necessary selectable). The OutputFormat has to be MenuEntry.
    /// Encoded/decoded by serializers as &quot;GMNE&quot;.
    /// </summary>
    [EnumMember(Value = "GMNE")]
    [IsoId("_6XNDMN6nEeiwsev40qZGEQ")]
    [Description(
        @"To choose an entry among a list of entries (all of them are not necessary selectable). The OutputFormat has to be MenuEntry."
    )]
    GetMenuEntry,

    /// <summary>
    /// Request to enter a password with masked characters while typing the password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_9Gc3sN6nEeiwsev40qZGEQ")]
    [Description(@"Request to enter a password with masked characters while typing the password.")]
    Password,

    /// <summary>
    /// Wait for a XHTML data.
    /// Encoded/decoded by serializers as &quot;HTML&quot;.
    /// </summary>
    [EnumMember(Value = "HTML")]
    [IsoId("__gt6sN6nEeiwsev40qZGEQ")]
    [Description(@"Wait for a XHTML data.")]
    XHTMLText,

    /// <summary>
    /// Request to wait for signature.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_jDqpoO2tEei-V5h0ja04AA")]
    [Description(@"Request to wait for signature.")]
    Signature,
}
