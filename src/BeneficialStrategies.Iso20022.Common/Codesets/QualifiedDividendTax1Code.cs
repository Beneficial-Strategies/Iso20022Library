// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the dividend as whole or in part qualifies for lower/ favourable tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10Jl4TL3EeKU9IrkkToqcw_1483431063")]
[Description(@"Indicates whether the dividend as whole or in part qualifies for lower/ favourable tax rate.")]
[DerivedFrom(typeof(QualifiedDividendTaxCode))]
public enum QualifiedDividendTax1Code
{
    /// <summary>
    /// Dividend income is potentially qualified (for instance common or preferred stock dividends, income distribution by mutual funds).
    /// Encoded/decoded by serializers as &quot;FQUD&quot;.
    /// </summary>
    [EnumMember(Value = "FQUD")]
    [IsoId("_10Jl4jL3EeKU9IrkkToqcw_-2047470535")]
    [Description(@"Dividend income is potentially qualified (for instance common or preferred stock dividends, income distribution by mutual funds).")]
    FullyQualified = QualifiedDividendTaxCode.FullyQualified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Part of dividend income is potentially qualified (for instance income form a mutual fund which holds both stocks and bonds).
    /// Encoded/decoded by serializers as &quot;PQUD&quot;.
    /// </summary>
    [EnumMember(Value = "PQUD")]
    [IsoId("_10Jl4zL3EeKU9IrkkToqcw_-1448298646")]
    [Description(@"Part of dividend income is potentially qualified (for instance income form a mutual fund which holds both stocks and bonds).")]
    PartlyQualified = QualifiedDividendTaxCode.PartlyQualified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend is not qualified (for instance UIT dividends, REIT dividends).
    /// Encoded/decoded by serializers as &quot;NQUD&quot;.
    /// </summary>
    [EnumMember(Value = "NQUD")]
    [IsoId("_10Jl5DL3EeKU9IrkkToqcw_1154488453")]
    [Description(@"Dividend is not qualified (for instance UIT dividends, REIT dividends).")]
    NotQualified = QualifiedDividendTaxCode.NotQualified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Qualified dividend tax status is unknown (for instance if dividend tax status information is unavailable at the time of the dividend update, it will be provided when new information is received).
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_10Jl5TL3EeKU9IrkkToqcw_1143389676")]
    [Description(@"Qualified dividend tax status is unknown (for instance if dividend tax status information is unavailable at the time of the dividend update, it will be provided when new information is received).")]
    Unknown = QualifiedDividendTaxCode.Unknown, // same ordinal as derivation source for type conversions
    
}
