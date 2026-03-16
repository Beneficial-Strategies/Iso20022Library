// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tax basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSljs9p-Ed-ak6NoX_4Aeg_618293605")]
[Description(@"Specifies the tax basis.")]
[Derivations(
    typeof(TaxationBasis2Code),
    typeof(TaxationBasis4Code),
    typeof(TaxationBasis3Code),
    typeof(TaxationBasis5Code)
)]
public enum TaxationBasisCode
{
    /// <summary>
    /// Charge/tax basis is a lump sum.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_ZSljtNp-Ed-ak6NoX_4Aeg_-1127639624")]
    [Description(@"Charge/tax basis is a lump sum.")]
    Flat,

    /// <summary>
    /// Charges/tax basis is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("_ZSljtdp-Ed-ak6NoX_4Aeg_-1117483051")]
    [Description(@"Charges/tax basis is per unit of financial instrument.")]
    PerUnit,

    /// <summary>
    /// Charge/tax basis is a percentage.
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_ZSljttp-Ed-ak6NoX_4Aeg_-2105967926")]
    [Description(@"Charge/tax basis is a percentage.")]
    Percentage,

    /// <summary>
    /// Charge/tax basis is a percentage which depends on the tax brackets.
    /// Encoded/decoded by serializers as &quot;BRAC&quot;.
    /// </summary>
    [EnumMember(Value = "BRAC")]
    [IsoId("_ZSljt9p-Ed-ak6NoX_4Aeg_-1649673719")]
    [Description(@"Charge/tax basis is a percentage which depends on the tax brackets.")]
    RatePerBrackets,

    /// <summary>
    /// Rate with a minimum amount.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_ZSljuNp-Ed-ak6NoX_4Aeg_-1349528343")]
    [Description(@"Rate with a minimum amount.")]
    RateWithMinimumAmount,

    /// <summary>
    /// Rate with a maximum amount.
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_ZSvUsNp-Ed-ak6NoX_4Aeg_-1292270181")]
    [Description(@"Rate with a maximum amount.")]
    RateWithMaximumAmount,

    /// <summary>
    /// Another type of taxation basis.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZSvUsdp-Ed-ak6NoX_4Aeg_110864883")]
    [Description(@"Another type of taxation basis.")]
    Other,

    /// <summary>
    /// Charge/Commission/tax basis is based on the gross amount.
    /// Encoded/decoded by serializers as &quot;GRAM&quot;.
    /// </summary>
    [EnumMember(Value = "GRAM")]
    [IsoId("_ZSvUstp-Ed-ak6NoX_4Aeg_-1911567579")]
    [Description(@"Charge/Commission/tax basis is based on the gross amount.")]
    GrossAmount,

    /// <summary>
    /// Charge/commission/tax basis is based on the net amount.
    /// Encoded/decoded by serializers as &quot;NEAM&quot;.
    /// </summary>
    [EnumMember(Value = "NEAM")]
    [IsoId("_ZSvUs9p-Ed-ak6NoX_4Aeg_-1911567501")]
    [Description(@"Charge/commission/tax basis is based on the net amount.")]
    NetAmount,

    /// <summary>
    /// Charge/tax basis is the price.
    /// Encoded/decoded by serializers as &quot;NAVP&quot;.
    /// </summary>
    [EnumMember(Value = "NAVP")]
    [IsoId("_-FMowEdkEeaBWtcfqEyXyw")]
    [Description(@"Charge/tax basis is the price.")]
    NetAssetValuePrice,
}
