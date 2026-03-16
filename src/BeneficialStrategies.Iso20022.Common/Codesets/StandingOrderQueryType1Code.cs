// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8N7QVqMgEeCJ6YNENx4h-w_-234356258")]
[Description(
    @"Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query."
)]
[DerivedFrom(typeof(StandingOrderQueryTypeCode))]
public enum StandingOrderQueryType1Code
{
    /// <summary>
    /// Used to query the list of liquidity transfer standing orders defined in the system.
    /// Encoded/decoded by serializers as &quot;SLST&quot;.
    /// </summary>
    [EnumMember(Value = "SLST")]
    [IsoId("_8N7QV6MgEeCJ6YNENx4h-w_-544859245")]
    [Description(
        @"Used to query the list of liquidity transfer standing orders defined in the system."
    )]
    StandingOrderList = StandingOrderQueryTypeCode.StandingOrderList, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used to query a specific liquidity transfer standing order based on a set of search criteria.
    /// Encoded/decoded by serializers as &quot;SDTL&quot;.
    /// </summary>
    [EnumMember(Value = "SDTL")]
    [IsoId("_8N7QWKMgEeCJ6YNENx4h-w_1890972049")]
    [Description(
        @"Used to query a specific liquidity transfer standing order based on a set of search criteria."
    )]
    StandingOrderDetails = StandingOrderQueryTypeCode.StandingOrderDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used to query the total amounts of predefined and user defined liquidity transfer standing orders for both defined and not yet executed orders.
    /// Encoded/decoded by serializers as &quot;TAPS&quot;.
    /// </summary>
    [EnumMember(Value = "TAPS")]
    [IsoId("_8OFBUKMgEeCJ6YNENx4h-w_501190329")]
    [Description(
        @"Used to query the total amounts of predefined and user defined liquidity transfer standing orders for both defined and not yet executed orders."
    )]
    TotalAmountPerStandingOrder = StandingOrderQueryTypeCode.TotalAmountPerStandingOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used to query the list of liquidity transfer standing orders defined in a specific link set of sequenced standing orders. The link set is a collection of standing order defined in a specific sequence.
    /// Encoded/decoded by serializers as &quot;SLSL&quot;.
    /// </summary>
    [EnumMember(Value = "SLSL")]
    [IsoId("_8OFBUaMgEeCJ6YNENx4h-w_-1508766529")]
    [Description(
        @"Used to query the list of liquidity transfer standing orders defined in a specific link set of sequenced standing orders. The link set is a collection of standing order defined in a specific sequence."
    )]
    StandingOrderLinkSetList = StandingOrderQueryTypeCode.StandingOrderLinkSetList, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used to query a specific standing order within a link set of sequenced liquidity transfer standing orders. The link set is a collection of standing order defined in a specific sequence.
    /// Encoded/decoded by serializers as &quot;SWLS&quot;.
    /// </summary>
    [EnumMember(Value = "SWLS")]
    [IsoId("_8OFBUqMgEeCJ6YNENx4h-w_-105628684")]
    [Description(
        @"Used to query a specific standing order within a link set of sequenced liquidity transfer standing orders. The link set is a collection of standing order defined in a specific sequence."
    )]
    StandingOrderDetailsWithinLinkSet =
        StandingOrderQueryTypeCode.StandingOrderDetailsWithinLinkSet, // same ordinal as derivation source for type conversions
}
