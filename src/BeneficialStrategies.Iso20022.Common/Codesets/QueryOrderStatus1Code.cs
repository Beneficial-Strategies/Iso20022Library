// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the inquiry status of order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RgF9EA2NEeSwB74WgTbh4Q")]
[Description(@"Specifies the inquiry status of order.")]
[DerivedFrom(typeof(QueryOrderStatusCode))]
public enum QueryOrderStatus1Code
{
    /// <summary>
    /// Query for orders which are not confirmed by a party.
    /// Encoded/decoded by serializers as &quot;QUCO&quot;.
    /// </summary>
    [EnumMember(Value = "QUCO")]
    [IsoId("_TUJ7sQ2NEeSwB74WgTbh4Q")]
    [Description(@"Query for orders which are not confirmed by a party.")]
    QueryUnconfirmedOrder = QueryOrderStatusCode.QueryUnconfirmedOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for all orders for a party.
    /// Encoded/decoded by serializers as &quot;QOFP&quot;.
    /// </summary>
    [EnumMember(Value = "QOFP")]
    [IsoId("_ThlTsQ2NEeSwB74WgTbh4Q")]
    [Description(@"Query for all orders for a party.")]
    QueryOrdersForTheParty = QueryOrderStatusCode.QueryOrdersForTheParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for orders have been completely executed.
    /// Encoded/decoded by serializers as &quot;QFEO&quot;.
    /// </summary>
    [EnumMember(Value = "QFEO")]
    [IsoId("_HaAlAQ4pEeSvVsudrRLaVg")]
    [Description(@"Query for orders have been completely executed.")]
    QueryFullyExecutedOrder = QueryOrderStatusCode.QueryFullyExecutedOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for orders have been partially executed.
    /// Encoded/decoded by serializers as &quot;QPEO&quot;.
    /// </summary>
    [EnumMember(Value = "QPEO")]
    [IsoId("_HcB-QQ4pEeSvVsudrRLaVg")]
    [Description(@"Query for orders have been partially executed.")]
    QueryPartiallyExecutedOrder = QueryOrderStatusCode.QueryPartiallyExecutedOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for all orders.
    /// Encoded/decoded by serializers as &quot;QUAO&quot;.
    /// </summary>
    [EnumMember(Value = "QUAO")]
    [IsoId("_V2KK8YA3EeSUJZYcWGKkkw")]
    [Description(@"Query for all orders.|")]
    QueryAllOrders = QueryOrderStatusCode.QueryAllOrders, // same ordinal as derivation source for type conversions
    
}
