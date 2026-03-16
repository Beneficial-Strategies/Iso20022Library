// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount price type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_begot9p-Ed-ak6NoX_4Aeg_150966910")]
[Description(@"Specifies the amount price type.")]
[DerivedFrom(typeof(AmountPriceTypeCode))]
public enum AmountPriceType1Code
{
    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_begouNp-Ed-ak6NoX_4Aeg_150966940")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount = AmountPriceTypeCode.ActualAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a discount amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_beqZsNp-Ed-ak6NoX_4Aeg_150966971")]
    [Description(@"Price expressed as a discount amount.")]
    Discount = AmountPriceTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as an amount of money per lot.
    /// Encoded/decoded by serializers as &quot;PLOT&quot;.
    /// </summary>
    [EnumMember(Value = "PLOT")]
    [IsoId("_beqZsdp-Ed-ak6NoX_4Aeg_150966972")]
    [Description(@"Price expressed as an amount of money per lot.")]
    Lot = AmountPriceTypeCode.Lot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a premium.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_beqZstp-Ed-ak6NoX_4Aeg_150966973")]
    [Description(@"Price expressed as a premium.")]
    Premium = AmountPriceTypeCode.Premium, // same ordinal as derivation source for type conversions
}
