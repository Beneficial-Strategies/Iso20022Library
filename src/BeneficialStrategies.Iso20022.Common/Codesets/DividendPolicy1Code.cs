// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the dividend policy of the financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aw6i5dp-Ed-ak6NoX_4Aeg_59914652")]
[Description(@"Specifies the dividend policy of the financial instrument.")]
[DerivedFrom(typeof(DividendPolicyCode))]
public enum DividendPolicy1Code
{
    /// <summary>
    /// Dividend is paid in cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aw6i5tp-Ed-ak6NoX_4Aeg_119018465")]
    [Description(@"Dividend is paid in cash.")]
    Cash = DividendPolicyCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend is paid in units.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_aw6i59p-Ed-ak6NoX_4Aeg_119018743")]
    [Description(@"Dividend is paid in units.")]
    Units = DividendPolicyCode.Units, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend is paid in both Cash and Units.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_axET4Np-Ed-ak6NoX_4Aeg_119018774")]
    [Description(@"Dividend is paid in both Cash and Units.")]
    Both = DividendPolicyCode.Both, // same ordinal as derivation source for type conversions
}
