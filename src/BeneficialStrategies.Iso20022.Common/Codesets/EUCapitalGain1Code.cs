// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkUiMdp-Ed-ak6NoX_4Aeg_-990874327")]
[Description(
    @"Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc."
)]
[DerivedFrom(typeof(EUCapitalGainCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EUCapitalGain1Code>))]
#endif
public enum EUCapitalGain1Code
{
    /// <summary>
    /// Capital gain is in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSI&quot;.
    /// </summary>
    [EnumMember(Value = "EUSI")]
    [IsoId("_VkUiMtp-Ed-ak6NoX_4Aeg_-834797746")]
    [Description(@"Capital gain is in the scope of the directive.")]
    CapitalGainInScope = EUCapitalGainCode.CapitalGainInScope, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Capital gain is out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSO&quot;.
    /// </summary>
    [EnumMember(Value = "EUSO")]
    [IsoId("_VkUiM9p-Ed-ak6NoX_4Aeg_-834797728")]
    [Description(@"Capital gain is out of the scope of the directive.")]
    CapitalGainOutScope = EUCapitalGainCode.CapitalGainOutScope, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown whether capital gain is in or out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_VkUiNNp-Ed-ak6NoX_4Aeg_-834797727")]
    [Description(@"Unknown whether capital gain is in or out of the scope of the directive.")]
    CapitalGainUnknown = EUCapitalGainCode.CapitalGainUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of EU capital gain.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkUiNdp-Ed-ak6NoX_4Aeg_-1526082672")]
    [Description(@"Another type of EU capital gain.")]
    Other = EUCapitalGainCode.Other, // same ordinal as derivation source for type conversions
}
