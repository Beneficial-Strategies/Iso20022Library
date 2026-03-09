// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the option style.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IuoZkMRyEeOg-a7zWL_U0A")]
[Description(@"Specifies the option style.")]
[DerivedFrom(typeof(ExoticOptionStyleCode))]
public enum ExoticOptionStyle1Code
{
    /// <summary>
    /// Agreement under which a fixed amount is paid out if a specific condition is met at any time during the exercise period. The expiration style is European or American. The binary option has only &quot;payment triggers&quot;.
    /// Encoded/decoded by serializers as &quot;BINA&quot;.
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_KdV-IcRyEeOg-a7zWL_U0A")]
    [Description(@"Agreement under which a fixed amount is paid out if a specific condition is met at any time during the exercise period. The expiration style is European or American. The binary option has only ""payment triggers"".")]
    BinaryOption = ExoticOptionStyleCode.BinaryOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agreement under which a fixed amount is paid out if a specific condition is met on expiration date. The digital option has only &quot;payment triggers&quot; which may be single or double trigger level.
    /// Encoded/decoded by serializers as &quot;DIGI&quot;.
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_Kl5dMcRyEeOg-a7zWL_U0A")]
    [Description(@"Agreement under which a fixed amount is paid out if a specific condition is met on expiration date. The digital option has only ""payment triggers"" which may be single or double trigger level.")]
    DigitalOption = ExoticOptionStyleCode.DigitalOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agreement under which a fixed amount is paid unless a specific condition is met. The notouch option has only &quot;no payment triggers&quot; which may be single or double trigger levels.
    /// Encoded/decoded by serializers as &quot;NOTO&quot;.
    /// </summary>
    [EnumMember(Value = "NOTO")]
    [IsoId("_KojvocRyEeOg-a7zWL_U0A")]
    [Description(@"Agreement under which a fixed amount is paid unless a specific condition is met. The notouch option has only ""no payment triggers"" which may be single or double trigger levels.")]
    NoTouchOption = ExoticOptionStyleCode.NoTouchOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract that provides the buyer the right but not the obligation to buy or sell the underlying currency at a predetermined rate with expiration determined by the expiration style. The expiration style is European, American, Asian or Bermudan.
    /// Encoded/decoded by serializers as &quot;VANI&quot;.
    /// </summary>
    [EnumMember(Value = "VANI")]
    [IsoId("_KrfH0cRyEeOg-a7zWL_U0A")]
    [Description(@"Contract that provides the buyer the right but not the obligation to buy or sell the underlying currency at a predetermined rate with expiration determined by the expiration style. The expiration style is European, American, Asian or Bermudan.")]
    VanillaOption = ExoticOptionStyleCode.VanillaOption, // same ordinal as derivation source for type conversions
    
}
