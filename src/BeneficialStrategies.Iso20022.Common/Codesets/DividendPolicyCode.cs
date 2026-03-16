// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the dividend policy of the financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axET4dp-Ed-ak6NoX_4Aeg_800833900")]
[Description(@"Specifies the dividend policy of the financial instrument.")]
[Derivations(typeof(DividendPolicy1Code))]
public enum DividendPolicyCode
{
    /// <summary>
    /// Dividend is paid daily and can be accrued.
    /// Encoded/decoded by serializers as &quot;DACR&quot;.
    /// </summary>
    [EnumMember(Value = "DACR")]
    [IsoId("_axET4tp-Ed-ak6NoX_4Aeg_1318003656")]
    [Description(@"Dividend is paid daily and can be accrued.")]
    DailyAccruingDividend,

    /// <summary>
    /// Dividend is paid in cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_axET49p-Ed-ak6NoX_4Aeg_2079909550")]
    [Description(@"Dividend is paid in cash.")]
    Cash,

    /// <summary>
    /// Dividend is paid in units.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_axET5Np-Ed-ak6NoX_4Aeg_2145480783")]
    [Description(@"Dividend is paid in units.")]
    Units,

    /// <summary>
    /// Dividend is paid in both Cash and Units.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_axET5dp-Ed-ak6NoX_4Aeg_-385543747")]
    [Description(@"Dividend is paid in both Cash and Units.")]
    Both,
}
