// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VlEJE9p-Ed-ak6NoX_4Aeg_1966959880")]
[Description(@"Specifies whether the fund calculates a taxable interest per share (TIS).")]
[DerivedFrom(typeof(TaxableIncomePerShareCalculatedCode))]
public enum TaxableIncomePerShareCalculated1Code
{
    /// <summary>
    /// Fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;TSIY&quot;.
    /// </summary>
    [EnumMember(Value = "TSIY")]
    [IsoId("_VlEJFNp-Ed-ak6NoX_4Aeg_-1901338896")]
    [Description(@"Fund is calculating the taxable interest per share with the NAV.")]
    FundCalculates = TaxableIncomePerShareCalculatedCode.FundCalculates, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fund is not calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;TSIN&quot;.
    /// </summary>
    [EnumMember(Value = "TSIN")]
    [IsoId("_VlEJFdp-Ed-ak6NoX_4Aeg_-1901338871")]
    [Description(@"Fund is not calculating the taxable interest per share with the NAV.")]
    FundDoesNotCalculate = TaxableIncomePerShareCalculatedCode.FundDoesNotCalculate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown whether the fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_VlEJFtp-Ed-ak6NoX_4Aeg_-1901338854")]
    [Description(
        @"Unknown whether the fund is calculating the taxable interest per share with the NAV."
    )]
    FundCalculatesUnknown = TaxableIncomePerShareCalculatedCode.FundCalculatesUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of taxable income per share.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VlEJF9p-Ed-ak6NoX_4Aeg_-721697044")]
    [Description(@"Another type of taxable income per share.")]
    Other = TaxableIncomePerShareCalculatedCode.Other, // same ordinal as derivation source for type conversions
}
