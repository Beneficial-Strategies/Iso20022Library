// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTVTcNp-Ed-ak6NoX_4Aeg_-1786544875")]
[Description(
    @"Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS)."
)]
[DerivedFrom(typeof(CorporateActionTaxableIncomePerShareCalculatedCode))]
public enum CorporateActionTaxableIncomePerShareCalculated1Code
{
    /// <summary>
    /// Fund is calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as &quot;TDIY&quot;.
    /// </summary>
    [EnumMember(Value = "TDIY")]
    [IsoId("_bTVTcdp-Ed-ak6NoX_4Aeg_-1786544873")]
    [Description(@"Fund is calculating the taxable income per dividend/taxable income per share.")]
    Calculated = CorporateActionTaxableIncomePerShareCalculatedCode.Calculated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fund is not calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as &quot;TDIN&quot;.
    /// </summary>
    [EnumMember(Value = "TDIN")]
    [IsoId("_bTVTctp-Ed-ak6NoX_4Aeg_-1786544858")]
    [Description(
        @"Fund is not calculating the taxable income per dividend/taxable income per share."
    )]
    NotCalculated = CorporateActionTaxableIncomePerShareCalculatedCode.NotCalculated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown whether the fund is calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_bTVTc9p-Ed-ak6NoX_4Aeg_-1786544857")]
    [Description(
        @"Unknown whether the fund is calculating the taxable income per dividend/taxable income per share."
    )]
    Unknown = CorporateActionTaxableIncomePerShareCalculatedCode.Unknown, // same ordinal as derivation source for type conversions
}
