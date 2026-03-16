// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSSoxNp-Ed-ak6NoX_4Aeg_162652014")]
[Description(@"Specifies whether the fund calculates a taxable interest per share (TIS).")]
[DerivedFrom(typeof(TaxableIncomePerShareCalculatedCode))]
public enum TaxableIncomePerShareCalculated2Code
{
    /// <summary>
    /// Fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;TSIY&quot;.
    /// </summary>
    [EnumMember(Value = "TSIY")]
    [IsoId("_ZSSoxdp-Ed-ak6NoX_4Aeg_206054111")]
    [Description(@"Fund is calculating the taxable interest per share with the NAV.")]
    FundCalculates = TaxableIncomePerShareCalculatedCode.FundCalculates, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fund is not calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;TSIN&quot;.
    /// </summary>
    [EnumMember(Value = "TSIN")]
    [IsoId("_ZSSoxtp-Ed-ak6NoX_4Aeg_206055154")]
    [Description(@"Fund is not calculating the taxable interest per share with the NAV.")]
    FundDoesNotCalculate = TaxableIncomePerShareCalculatedCode.FundDoesNotCalculate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown whether the fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZSSox9p-Ed-ak6NoX_4Aeg_206055214")]
    [Description(
        @"Unknown whether the fund is calculating the taxable interest per share with the NAV."
    )]
    FundCalculatesUnknown = TaxableIncomePerShareCalculatedCode.FundCalculatesUnknown, // same ordinal as derivation source for type conversions
}
