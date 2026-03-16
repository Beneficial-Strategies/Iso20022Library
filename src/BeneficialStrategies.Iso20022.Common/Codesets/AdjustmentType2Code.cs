// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnKOZtp-Ed-ak6NoX_4Aeg_-1989744459")]
[Description(@"Specifies the type of adjustment.")]
[DerivedFrom(typeof(AdjustmentTypeCode))]
public enum AdjustmentType2Code
{
    /// <summary>
    /// Adjustment is a rebate.
    /// Encoded/decoded by serializers as &quot;REBA&quot;.
    /// </summary>
    [EnumMember(Value = "REBA")]
    [IsoId("_bnKOZ9p-Ed-ak6NoX_4Aeg_-1989744440")]
    [Description(@"Adjustment is a rebate.")]
    Rebate = AdjustmentTypeCode.Rebate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment is a discount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_bnTYUNp-Ed-ak6NoX_4Aeg_-1989744416")]
    [Description(@"Adjustment is a discount.")]
    Discount = AdjustmentTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment is a credit note.
    /// Encoded/decoded by serializers as &quot;CREN&quot;.
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_bnTYUdp-Ed-ak6NoX_4Aeg_-1989744399")]
    [Description(@"Adjustment is a credit note.")]
    CreditNote = AdjustmentTypeCode.CreditNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment is a surcharge.
    /// Encoded/decoded by serializers as &quot;SURC&quot;.
    /// </summary>
    [EnumMember(Value = "SURC")]
    [IsoId("_bnTYUtp-Ed-ak6NoX_4Aeg_-1488271597")]
    [Description(@"Adjustment is a surcharge.")]
    Surcharge = AdjustmentTypeCode.Surcharge, // same ordinal as derivation source for type conversions
}
