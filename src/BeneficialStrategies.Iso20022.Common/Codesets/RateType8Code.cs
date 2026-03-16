// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZmKp9p-Ed-ak6NoX_4Aeg_-516051900")]
[Description(@"Specifies the type of tax rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType8Code
{
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_ZZvUkNp-Ed-ak6NoX_4Aeg_-440320575")]
    [Description(
        @"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible."
    )]
    WithholdingOfLocalTax = RateTypeCode.WithholdingOfLocalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_ZZvUkdp-Ed-ak6NoX_4Aeg_-71837844")]
    [Description(
        @"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible."
    )]
    WithholdingOfForeignTax = RateTypeCode.WithholdingOfForeignTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// Encoded/decoded by serializers as &quot;LIDT&quot;.
    /// </summary>
    [EnumMember(Value = "LIDT")]
    [IsoId("_ZZvUktp-Ed-ak6NoX_4Aeg_-98555748")]
    [Description(
        @"Interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool)."
    )]
    LocalTax = RateTypeCode.LocalTax, // same ordinal as derivation source for type conversions
}
