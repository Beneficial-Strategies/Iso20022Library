// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIFoVdp-Ed-ak6NoX_4Aeg_-943074065")]
[Description(@"Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc.")]
[DerivedFrom(typeof(PreferenceToIncomeCode))]
public enum PreferenceToIncome1Code
{
    /// <summary>
    /// Indicates an ordinary/common preference to income.
    /// Encoded/decoded by serializers as &quot;ORDN&quot;.
    /// </summary>
    [EnumMember(Value = "ORDN")]
    [IsoId("_aIFoVtp-Ed-ak6NoX_4Aeg_-943073945")]
    [Description(@"Indicates an ordinary/common preference to income.")]
    Ordinary = PreferenceToIncomeCode.Ordinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a preferred claim upon income and assets.
    /// Encoded/decoded by serializers as &quot;PFRD&quot;.
    /// </summary>
    [EnumMember(Value = "PFRD")]
    [IsoId("_aIFoV9p-Ed-ak6NoX_4Aeg_-943073928")]
    [Description(@"Indicates a preferred claim upon income and assets.")]
    Preferred = PreferenceToIncomeCode.Preferred, // same ordinal as derivation source for type conversions
    
}
