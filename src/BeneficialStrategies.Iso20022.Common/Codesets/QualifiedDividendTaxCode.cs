// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the dividend as a whole or in part qualifies for lower/favourable tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1mSwEDL3EeKU9IrkkToqcw_1943389310")]
[Description(@"Indicates whether the dividend as a whole or in part qualifies for lower/favourable tax rate.")]
[Derivations(typeof(QualifiedDividendTax1Code))]
public enum QualifiedDividendTaxCode
{
    /// <summary>
    /// Dividend income is potentially qualified (for instance common or preferred stock dividends, income distribution by mutual funds).
    /// Encoded/decoded by serializers as &quot;FQUD&quot;.
    /// </summary>
    [EnumMember(Value = "FQUD")]
    [IsoId("_1mSwETL3EeKU9IrkkToqcw_1853317281")]
    [Description(@"Dividend income is potentially qualified (for instance common or preferred stock dividends, income distribution by mutual funds).")]
    FullyQualified,
    
    /// <summary>
    /// Part of dividend income is potentially qualified (for instance income form a mutual fund which holds both stocks and bonds).
    /// Encoded/decoded by serializers as &quot;PQUD&quot;.
    /// </summary>
    [EnumMember(Value = "PQUD")]
    [IsoId("_1mSwEjL3EeKU9IrkkToqcw_1614159460")]
    [Description(@"Part of dividend income is potentially qualified (for instance income form a mutual fund which holds both stocks and bonds).")]
    PartlyQualified,
    
    /// <summary>
    /// Dividend is not qualified (for instance UIT dividends, REIT dividends).
    /// Encoded/decoded by serializers as &quot;NQUD&quot;.
    /// </summary>
    [EnumMember(Value = "NQUD")]
    [IsoId("_1mSwEzL3EeKU9IrkkToqcw_-531915581")]
    [Description(@"Dividend is not qualified (for instance UIT dividends, REIT dividends).")]
    NotQualified,
    
    /// <summary>
    /// Qualified dividend tax status is unknown (for instance if dividend tax status information is unavailable at the time of the dividend update, it will be provided when new information is received).
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_1mSwFDL3EeKU9IrkkToqcw_-1414874880")]
    [Description(@"Qualified dividend tax status is unknown (for instance if dividend tax status information is unavailable at the time of the dividend update, it will be provided when new information is received).")]
    Unknown,
    
}
