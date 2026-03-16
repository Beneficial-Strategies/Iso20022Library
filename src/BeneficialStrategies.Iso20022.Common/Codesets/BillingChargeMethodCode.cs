// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how the billing charge is calculated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6VBJ4JqlEeGSON8vddiWzQ_185173983")]
[Description(@"Defines how the billing charge is calculated.")]
[Derivations(typeof(BillingChargeMethod1Code))]
public enum BillingChargeMethodCode
{
    /// <summary>
    /// Charge is calculated as the product of volume times unit price. This is the default value.
    /// Encoded/decoded by serializers as &quot;UPRC&quot;.
    /// </summary>
    [EnumMember(Value = "UPRC")]
    [IsoId("_6VBJ4ZqlEeGSON8vddiWzQ_-1196517721")]
    [Description(
        @"Charge is calculated as the product of volume times unit price. This is the default value."
    )]
    UnitPriced,

    /// <summary>
    /// Service is specifically identified as a stamp duty for accounting purposes. The charge is calculated as the product of volume times unit price.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_6VBJ4pqlEeGSON8vddiWzQ_1035261093")]
    [Description(
        @"Service is specifically identified as a stamp duty for accounting purposes. The charge is calculated as the product of volume times unit price."
    )]
    StampDuty,

    /// <summary>
    /// Fee charged in addition to the volume times unit price when one or more units of the service are provided.
    /// Encoded/decoded by serializers as &quot;BCHG&quot;.
    /// </summary>
    [EnumMember(Value = "BCHG")]
    [IsoId("_6VBJ45qlEeGSON8vddiWzQ_1132466804")]
    [Description(
        @"Fee charged in addition to the volume times unit price when one or more units of the service are provided."
    )]
    BaseCharge,

    /// <summary>
    /// Charge is calculated using a price which is lower than the quoted bank price.
    /// Encoded/decoded by serializers as &quot;DPRC&quot;.
    /// </summary>
    [EnumMember(Value = "DPRC")]
    [IsoId("_6VBJ5JqlEeGSON8vddiWzQ_537070255")]
    [Description(@"Charge is calculated using a price which is lower than the quoted bank price.")]
    DiscountPrice,

    /// <summary>
    /// Fixed charge not tied to volume or unit price. Flat Charge fees do not require a volume or Unit Price.
    /// Encoded/decoded by serializers as &quot;FCHG&quot;.
    /// </summary>
    [EnumMember(Value = "FCHG")]
    [IsoId("_6VBJ5ZqlEeGSON8vddiWzQ_715188927")]
    [Description(
        @"Fixed charge not tied to volume or unit price. Flat Charge fees do not require a volume or Unit Price."
    )]
    FlatCharge,

    /// <summary>
    /// A single service where the volume, original charge and balance required are the totals of two or more pricing tiers.
    /// Encoded/decoded by serializers as &quot;LPRC&quot;.
    /// </summary>
    [EnumMember(Value = "LPRC")]
    [IsoId("_6VBJ5pqlEeGSON8vddiWzQ_423231189")]
    [Description(
        @"A single service where the volume, original charge and balance required are the totals of two or more pricing tiers."
    )]
    ListPrice,

    /// <summary>
    /// Lowest charge possible for the service.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_6VBJ55qlEeGSON8vddiWzQ_475633421")]
    [Description(@"Lowest charge possible for the service.")]
    MinimumCharge,

    /// <summary>
    /// Maximum charge possible for the service even though volume times unit price exceeds the maximum reduction value.
    /// Encoded/decoded by serializers as &quot;MXRD&quot;.
    /// </summary>
    [EnumMember(Value = "MXRD")]
    [IsoId("_6VBJ6JqlEeGSON8vddiWzQ_653752093")]
    [Description(
        @"Maximum charge possible for the service even though volume times unit price exceeds the maximum reduction value."
    )]
    MaximumReduction,

    /// <summary>
    /// Line item represents a charge for tier 1 in a multi tier, volume discount charging structure. Designates the tier 1 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR1&quot;.
    /// </summary>
    [EnumMember(Value = "TIR1")]
    [IsoId("_6VBJ6ZqlEeGSON8vddiWzQ_361794355")]
    [Description(
        @"Line item represents a charge for tier 1 in a multi tier, volume discount charging structure. Designates the tier 1 used to charge out the volume that falls in that tier."
    )]
    Tier1,

    /// <summary>
    /// Line item represents a charge for tier 2 in a multi tier, volume discount charging structure. Designates the tier 2 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR2&quot;.
    /// </summary>
    [EnumMember(Value = "TIR2")]
    [IsoId("_6VK64JqlEeGSON8vddiWzQ_1285378004")]
    [Description(
        @"Line item represents a charge for tier 2 in a multi tier, volume discount charging structure. Designates the tier 2 used to charge out the volume that falls in that tier."
    )]
    Tier2,

    /// <summary>
    /// Line item represents a charge for tier 3 in a multi tier, volume discount charging structure. Designates the tier 3 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR3&quot;.
    /// </summary>
    [EnumMember(Value = "TIR3")]
    [IsoId("_6VK64ZqlEeGSON8vddiWzQ_1053365389")]
    [Description(
        @"Line item represents a charge for tier 3 in a multi tier, volume discount charging structure. Designates the tier 3 used to charge out the volume that falls in that tier."
    )]
    Tier3,

    /// <summary>
    /// Line item represents a charge for tier 4 in a multi tier, volume discount charging structure. Designates the tier 4 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR4&quot;.
    /// </summary>
    [EnumMember(Value = "TIR4")]
    [IsoId("_6VK64pqlEeGSON8vddiWzQ_1426652454")]
    [Description(
        @"Line item represents a charge for tier 4 in a multi tier, volume discount charging structure. Designates the tier 4 used to charge out the volume that falls in that tier."
    )]
    Tier4,

    /// <summary>
    /// Line item represents a charge for tier 5 in a multi tier, volume discount charging structure. Designates the tier 5 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR5&quot;.
    /// </summary>
    [EnumMember(Value = "TIR5")]
    [IsoId("_6VK645qlEeGSON8vddiWzQ_741206649")]
    [Description(
        @"Line item represents a charge for tier 5 in a multi tier, volume discount charging structure. Designates the tier 5 used to charge out the volume that falls in that tier."
    )]
    Tier5,

    /// <summary>
    /// Line item represents a charge for tier 6 in a multi tier, volume discount charging structure. Designates the tier 6 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR6&quot;.
    /// </summary>
    [EnumMember(Value = "TIR6")]
    [IsoId("_6VK65JqlEeGSON8vddiWzQ_267764495")]
    [Description(
        @"Line item represents a charge for tier 6 in a multi tier, volume discount charging structure. Designates the tier 6 used to charge out the volume that falls in that tier."
    )]
    Tier6,

    /// <summary>
    /// Line item represents a charge for tier 7 in a multi tier, volume discount charging structure. Designates the tier 7 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR7&quot;.
    /// </summary>
    [EnumMember(Value = "TIR7")]
    [IsoId("_6VK65ZqlEeGSON8vddiWzQ_269866028")]
    [Description(
        @"Line item represents a charge for tier 7 in a multi tier, volume discount charging structure. Designates the tier 7 used to charge out the volume that falls in that tier."
    )]
    Tier7,

    /// <summary>
    /// Line item represents a charge for tier 8 in a multi tier, volume discount charging structure. Designates the tier 8 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR8&quot;.
    /// </summary>
    [EnumMember(Value = "TIR8")]
    [IsoId("_6VK65pqlEeGSON8vddiWzQ_-1498225982")]
    [Description(
        @"Line item represents a charge for tier 8 in a multi tier, volume discount charging structure. Designates the tier 8 used to charge out the volume that falls in that tier."
    )]
    Tier8,

    /// <summary>
    /// Line item represents a charge for tier 9 in a multi tier, volume discount charging structure. Designates the tier 9 used to charge out the volume that falls in that tier.
    /// Encoded/decoded by serializers as &quot;TIR9&quot;.
    /// </summary>
    [EnumMember(Value = "TIR9")]
    [IsoId("_6VK655qlEeGSON8vddiWzQ_-1744460427")]
    [Description(
        @"Line item represents a charge for tier 9 in a multi tier, volume discount charging structure. Designates the tier 9 used to charge out the volume that falls in that tier."
    )]
    Tier9,

    /// <summary>
    /// Unit price is determined by the total volume.
    /// Encoded/decoded by serializers as &quot;TPRC&quot;.
    /// </summary>
    [EnumMember(Value = "TPRC")]
    [IsoId("_6VK66JqlEeGSON8vddiWzQ_280237528")]
    [Description(@"Unit price is determined by the total volume.")]
    ThresholdPrice,

    /// <summary>
    /// Indicates different prices for the same service. Typically used in a relationship summary statement where the same service has a different price for different accounts in the relationship.
    /// Encoded/decoded by serializers as &quot;ZPRC&quot;.
    /// </summary>
    [EnumMember(Value = "ZPRC")]
    [IsoId("_6VUE0JqlEeGSON8vddiWzQ_458356200")]
    [Description(
        @"Indicates different prices for the same service. Typically used in a relationship summary statement where the same service has a different price for different accounts in the relationship."
    )]
    ZonePrice,

    /// <summary>
    /// Charge is calculated as a balance times a per-annum rate multiplied by a time factor.
    /// Encoded/decoded by serializers as &quot;BBSE&quot;.
    /// </summary>
    [EnumMember(Value = "BBSE")]
    [IsoId("_6VUE0ZqlEeGSON8vddiWzQ_166398462")]
    [Description(
        @"Charge is calculated as a balance times a per-annum rate multiplied by a time factor."
    )]
    BalanceBased,
}
