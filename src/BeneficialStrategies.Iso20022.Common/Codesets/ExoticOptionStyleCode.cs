// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the option style.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WkTlYcRxEeOg-a7zWL_U0A")]
[Description(@"Specifies the option style.")]
[Derivations(typeof(ExoticOptionStyle1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExoticOptionStyleCode>))]
#endif
public enum ExoticOptionStyleCode
{
    /// <summary>
    /// Agreement under which a fixed amount is paid out if a specific condition is met at any time during the exercise period. The expiration style is European or American. The binary option has only &quot;payment triggers&quot;.
    /// Encoded/decoded by serializers as &quot;BINA&quot;.
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_jbyOIMRxEeOg-a7zWL_U0A")]
    [Description(
        @"Agreement under which a fixed amount is paid out if a specific condition is met at any time during the exercise period. The expiration style is European or American. The binary option has only ""payment triggers""."
    )]
    BinaryOption,

    /// <summary>
    /// Agreement under which a fixed amount is paid out if a specific condition is met on expiration date. The digital option has only &quot;payment triggers&quot; which may be single or double trigger level.
    /// Encoded/decoded by serializers as &quot;DIGI&quot;.
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_rZfrkMRxEeOg-a7zWL_U0A")]
    [Description(
        @"Agreement under which a fixed amount is paid out if a specific condition is met on expiration date. The digital option has only ""payment triggers"" which may be single or double trigger level."
    )]
    DigitalOption,

    /// <summary>
    /// Agreement under which a fixed amount is paid unless a specific condition is met. The notouch option has only &quot;no payment triggers&quot; which may be single or double trigger levels.
    /// Encoded/decoded by serializers as &quot;NOTO&quot;.
    /// </summary>
    [EnumMember(Value = "NOTO")]
    [IsoId("_wW1IQMRxEeOg-a7zWL_U0A")]
    [Description(
        @"Agreement under which a fixed amount is paid unless a specific condition is met. The notouch option has only ""no payment triggers"" which may be single or double trigger levels."
    )]
    NoTouchOption,

    /// <summary>
    /// Contract that provides the buyer the right but not the obligation to buy or sell the underlying currency at a predetermined rate with expiration determined by the expiration style. The expiration style is European, American, Asian or Bermudan.
    /// Encoded/decoded by serializers as &quot;VANI&quot;.
    /// </summary>
    [EnumMember(Value = "VANI")]
    [IsoId("_1MblQMRxEeOg-a7zWL_U0A")]
    [Description(
        @"Contract that provides the buyer the right but not the obligation to buy or sell the underlying currency at a predetermined rate with expiration determined by the expiration style. The expiration style is European, American, Asian or Bermudan."
    )]
    VanillaOption,
}
