// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTVTdNp-Ed-ak6NoX_4Aeg_1953385002")]
[Description(
    @"Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS)."
)]
[Derivations(typeof(CorporateActionTaxableIncomePerShareCalculated1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionTaxableIncomePerShareCalculatedCode>))]
#endif
public enum CorporateActionTaxableIncomePerShareCalculatedCode
{
    /// <summary>
    /// Fund is calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as &quot;TDIY&quot;.
    /// </summary>
    [EnumMember(Value = "TDIY")]
    [IsoId("_bTVTddp-Ed-ak6NoX_4Aeg_1953385011")]
    [Description(@"Fund is calculating the taxable income per dividend/taxable income per share.")]
    Calculated,

    /// <summary>
    /// Fund is not calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as &quot;TDIN&quot;.
    /// </summary>
    [EnumMember(Value = "TDIN")]
    [IsoId("_bTfEcNp-Ed-ak6NoX_4Aeg_1953385027")]
    [Description(
        @"Fund is not calculating the taxable income per dividend/taxable income per share."
    )]
    NotCalculated,

    /// <summary>
    /// Unknown whether the fund is calculating the taxable income per dividend/taxable income per share.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_bTfEcdp-Ed-ak6NoX_4Aeg_1953385028")]
    [Description(
        @"Unknown whether the fund is calculating the taxable income per dividend/taxable income per share."
    )]
    Unknown,
}
