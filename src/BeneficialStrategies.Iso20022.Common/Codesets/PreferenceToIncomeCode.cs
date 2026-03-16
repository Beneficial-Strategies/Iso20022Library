// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIOyQNp-Ed-ak6NoX_4Aeg_-2084548748")]
[Description(
    @"Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc."
)]
[Derivations(typeof(PreferenceToIncome1Code))]
public enum PreferenceToIncomeCode
{
    /// <summary>
    /// Indicates an ordinary/common preference to income.
    /// Encoded/decoded by serializers as &quot;ORDN&quot;.
    /// </summary>
    [EnumMember(Value = "ORDN")]
    [IsoId("_aIOyQdp-Ed-ak6NoX_4Aeg_-1713290906")]
    [Description(@"Indicates an ordinary/common preference to income.")]
    Ordinary,

    /// <summary>
    /// Indicates a preferred claim upon income and assets.
    /// Encoded/decoded by serializers as &quot;PFRD&quot;.
    /// </summary>
    [EnumMember(Value = "PFRD")]
    [IsoId("_aIOyQtp-Ed-ak6NoX_4Aeg_-1713290503")]
    [Description(@"Indicates a preferred claim upon income and assets.")]
    Preferred,
}
