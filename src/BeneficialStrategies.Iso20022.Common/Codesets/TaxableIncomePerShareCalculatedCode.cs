// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSSoyNp-Ed-ak6NoX_4Aeg_1980815659")]
[Description(@"Specifies whether the fund calculates a taxable interest per share (TIS).")]
[Derivations(
    typeof(TaxableIncomePerShareCalculated1Code),
    typeof(TaxableIncomePerShareCalculated2Code)
)]
public enum TaxableIncomePerShareCalculatedCode
{
    /// <summary>
    /// Fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;TSIY&quot;.
    /// </summary>
    [EnumMember(Value = "TSIY")]
    [IsoId("_ZScZwNp-Ed-ak6NoX_4Aeg_2020526873")]
    [Description(@"Fund is calculating the taxable interest per share with the NAV.")]
    FundCalculates,

    /// <summary>
    /// Fund is not calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;TSIN&quot;.
    /// </summary>
    [EnumMember(Value = "TSIN")]
    [IsoId("_ZScZwdp-Ed-ak6NoX_4Aeg_-2002003074")]
    [Description(@"Fund is not calculating the taxable interest per share with the NAV.")]
    FundDoesNotCalculate,

    /// <summary>
    /// Unknown whether the fund is calculating the taxable interest per share with the NAV.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZScZwtp-Ed-ak6NoX_4Aeg_-1971525361")]
    [Description(
        @"Unknown whether the fund is calculating the taxable interest per share with the NAV."
    )]
    FundCalculatesUnknown,

    /// <summary>
    /// Another type of taxable income per share.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZScZw9p-Ed-ak6NoX_4Aeg_-779877625")]
    [Description(@"Another type of taxable income per share.")]
    Other,
}
