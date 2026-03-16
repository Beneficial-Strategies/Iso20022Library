// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how the billing charge is calculated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Ukd9pqlEeGSON8vddiWzQ_1265216021")]
[Description(@"Defines how the billing charge is calculated.")]
[DerivedFrom(typeof(BillingChargeMethodCode))]
public enum BillingChargeMethod1Code
{
    /// <summary>
    /// Charge is calculated as the product of volume times unit price. This is the default value.
    /// Encoded/decoded by serializers as &quot;UPRC&quot;.
    /// </summary>
    [EnumMember(Value = "UPRC")]
    [IsoId("_6Ukd95qlEeGSON8vddiWzQ_-840350178")]
    [Description(
        @"Charge is calculated as the product of volume times unit price. This is the default value."
    )]
    UnitPriced = BillingChargeMethodCode.UnitPriced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service is specifically identified as a stamp duty for accounting purposes. The charge is calculated as the product of volume times unit price.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_6Ukd-JqlEeGSON8vddiWzQ_1610748129")]
    [Description(
        @"Service is specifically identified as a stamp duty for accounting purposes. The charge is calculated as the product of volume times unit price."
    )]
    StampDuty = BillingChargeMethodCode.StampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee charged in addition to the volume times unit price when one or more units of the service are provided.
    /// Encoded/decoded by serializers as &quot;BCHG&quot;.
    /// </summary>
    [EnumMember(Value = "BCHG")]
    [IsoId("_6UuO8JqlEeGSON8vddiWzQ_-1217070404")]
    [Description(
        @"Fee charged in addition to the volume times unit price when one or more units of the service are provided."
    )]
    BaseCharge = BillingChargeMethodCode.BaseCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is calculated using a price which is lower than the quoted bank price.
    /// Encoded/decoded by serializers as &quot;DPRC&quot;.
    /// </summary>
    [EnumMember(Value = "DPRC")]
    [IsoId("_6UuO8ZqlEeGSON8vddiWzQ_2064835398")]
    [Description(@"Charge is calculated using a price which is lower than the quoted bank price.")]
    DiscountPrice = BillingChargeMethodCode.DiscountPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fixed charge not tied to volume or unit price. Flat Charge fees do not require a volume or Unit Price.
    /// Encoded/decoded by serializers as &quot;FCHG&quot;.
    /// </summary>
    [EnumMember(Value = "FCHG")]
    [IsoId("_6UuO8pqlEeGSON8vddiWzQ_2053736621")]
    [Description(
        @"Fixed charge not tied to volume or unit price. Flat Charge fees do not require a volume or Unit Price."
    )]
    FlatCharge = BillingChargeMethodCode.FlatCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A single service where the volume, original charge and balance required are the totals of two or more pricing tiers.
    /// Encoded/decoded by serializers as &quot;LPRC&quot;.
    /// </summary>
    [EnumMember(Value = "LPRC")]
    [IsoId("_6UuO85qlEeGSON8vddiWzQ_361556424")]
    [Description(
        @"A single service where the volume, original charge and balance required are the totals of two or more pricing tiers."
    )]
    ListPrice = BillingChargeMethodCode.ListPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lowest charge possible for the service.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_6UuO9JqlEeGSON8vddiWzQ_1828705187")]
    [Description(@"Lowest charge possible for the service.")]
    MinimumCharge = BillingChargeMethodCode.MinimumCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum charge possible for the service even though volume times unit price exceeds the maximum reduction value.
    /// Encoded/decoded by serializers as &quot;MXRD&quot;.
    /// </summary>
    [EnumMember(Value = "MXRD")]
    [IsoId("_6UuO9ZqlEeGSON8vddiWzQ_815643693")]
    [Description(
        @"Maximum charge possible for the service even though volume times unit price exceeds the maximum reduction value."
    )]
    MaximumReduction = BillingChargeMethodCode.MaximumReduction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 1 in a multi tier, volume discount charging structure. Designates the tier 1 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR1&quot;.
    /// </summary>
    [EnumMember(Value = "TIR1")]
    [IsoId("_6UuO9pqlEeGSON8vddiWzQ_804544916")]
    [Description(
        @"Line item represents a charge for tier 1 in a multi tier, volume discount charging structure. Designates the tier 1 used to charge out the volume that falls in that tier."
    )]
    Tier1 = BillingChargeMethodCode.Tier1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 2 in a multi tier, volume discount charging structure. Designates the tier 2 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR2&quot;.
    /// </summary>
    [EnumMember(Value = "TIR2")]
    [IsoId("_6UuO95qlEeGSON8vddiWzQ_-766551424")]
    [Description(
        @"Line item represents a charge for tier 2 in a multi tier, volume discount charging structure. Designates the tier 2 used to charge out the volume that falls in that tier."
    )]
    Tier2 = BillingChargeMethodCode.Tier2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 3 in a multi tier, volume discount charging structure. Designates the tier 3 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR3&quot;.
    /// </summary>
    [EnumMember(Value = "TIR3")]
    [IsoId("_6UuO-JqlEeGSON8vddiWzQ_1601332259")]
    [Description(
        @"Line item represents a charge for tier 3 in a multi tier, volume discount charging structure. Designates the tier 3 used to charge out the volume that falls in that tier."
    )]
    Tier3 = BillingChargeMethodCode.Tier3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 4 in a multi tier, volume discount charging structure. Designates the tier 4 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR4&quot;.
    /// </summary>
    [EnumMember(Value = "TIR4")]
    [IsoId("_6U3Y4JqlEeGSON8vddiWzQ_337586552")]
    [Description(
        @"Line item represents a charge for tier 4 in a multi tier, volume discount charging structure. Designates the tier 4 used to charge out the volume that falls in that tier."
    )]
    Tier4 = BillingChargeMethodCode.Tier4, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 5 in a multi tier, volume discount charging structure. Designates the tier 5 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR5&quot;.
    /// </summary>
    [EnumMember(Value = "TIR5")]
    [IsoId("_6U3Y4ZqlEeGSON8vddiWzQ_446377247")]
    [Description(
        @"Line item represents a charge for tier 5 in a multi tier, volume discount charging structure. Designates the tier 5 used to charge out the volume that falls in that tier."
    )]
    Tier5 = BillingChargeMethodCode.Tier5, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 6 in a multi tier, volume discount charging structure. Designates the tier 6 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR6&quot;.
    /// </summary>
    [EnumMember(Value = "TIR6")]
    [IsoId("_6U3Y4pqlEeGSON8vddiWzQ_-1049352499")]
    [Description(
        @"Line item represents a charge for tier 6 in a multi tier, volume discount charging structure. Designates the tier 6 used to charge out the volume that falls in that tier."
    )]
    Tier6 = BillingChargeMethodCode.Tier6, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 7 in a multi tier, volume discount charging structure. Designates the tier 7 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR7&quot;.
    /// </summary>
    [EnumMember(Value = "TIR7")]
    [IsoId("_6U3Y45qlEeGSON8vddiWzQ_-654755907")]
    [Description(
        @"Line item represents a charge for tier 7 in a multi tier, volume discount charging structure. Designates the tier 7 used to charge out the volume that falls in that tier."
    )]
    Tier7 = BillingChargeMethodCode.Tier7, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 8 in a multi tier, volume discount charging structure. Designates the tier 8 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR8&quot;.
    /// </summary>
    [EnumMember(Value = "TIR8")]
    [IsoId("_6U3Y5JqlEeGSON8vddiWzQ_897527195")]
    [Description(
        @"Line item represents a charge for tier 8 in a multi tier, volume discount charging structure. Designates the tier 8 used to charge out the volume that falls in that tier."
    )]
    Tier8 = BillingChargeMethodCode.Tier8, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line item represents a charge for tier 9 in a multi tier, volume discount charging structure. Designates the tier 9 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR9&quot;.
    /// </summary>
    [EnumMember(Value = "TIR9")]
    [IsoId("_6U3Y5ZqlEeGSON8vddiWzQ_1233780089")]
    [Description(
        @"Line item represents a charge for tier 9 in a multi tier, volume discount charging structure. Designates the tier 9 used to charge out the volume that falls in that tier."
    )]
    Tier9 = BillingChargeMethodCode.Tier9, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit price is determined by the total volume.
    /// Encoded/decoded by serializers as &quot;TPRC&quot;.
    /// </summary>
    [EnumMember(Value = "TPRC")]
    [IsoId("_6U3Y5pqlEeGSON8vddiWzQ_1855677988")]
    [Description(@"Unit price is determined by the total volume.")]
    ThresholdPrice = BillingChargeMethodCode.ThresholdPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates different prices for the same service. Typically used in a relationship summary statement where the same service has a different price for different accounts in the relationship.
    /// Encoded/decoded by serializers as &quot;ZPRC&quot;.
    /// </summary>
    [EnumMember(Value = "ZPRC")]
    [IsoId("_6U3Y55qlEeGSON8vddiWzQ_-972140545")]
    [Description(
        @"Indicates different prices for the same service. Typically used in a relationship summary statement where the same service has a different price for different accounts in the relationship."
    )]
    ZonePrice = BillingChargeMethodCode.ZonePrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge is calculated as a balance times a per-annum rate multiplied by a time factor.
    /// Encoded/decoded by serializers as &quot;BBSE&quot;.
    /// </summary>
    [EnumMember(Value = "BBSE")]
    [IsoId("_6U3Y6JqlEeGSON8vddiWzQ_11808999")]
    [Description(
        @"Charge is calculated as a balance times a per-annum rate multiplied by a time factor."
    )]
    BalanceBased = BillingChargeMethodCode.BalanceBased, // same ordinal as derivation source for type conversions
}
