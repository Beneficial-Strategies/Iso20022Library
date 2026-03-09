// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the inquiry status of order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BfWdUA2NEeSwB74WgTbh4Q")]
[Description(@"Specifies the inquiry status of order.")]
[Derivations(typeof(QueryOrderStatus1Code))]
public enum QueryOrderStatusCode
{
    /// <summary>
    /// Query for orders which are not confirmed by a party.
    /// Encoded/decoded by serializers as &quot;QUCO&quot;.
    /// </summary>
    [EnumMember(Value = "QUCO")]
    [IsoId("_HiymcA2NEeSwB74WgTbh4Q")]
    [Description(@"Query for orders which are not confirmed by a party.")]
    QueryUnconfirmedOrder,
    
    /// <summary>
    /// Query for all orders.
    /// Encoded/decoded by serializers as &quot;QUAO&quot;.
    /// </summary>
    [EnumMember(Value = "QUAO")]
    [IsoId("_KJzE8A2NEeSwB74WgTbh4Q")]
    [Description(@"Query for all orders.|")]
    QueryAllOrders,
    
    /// <summary>
    /// Query for orders have been partially executed.
    /// Encoded/decoded by serializers as &quot;QPEO&quot;.
    /// </summary>
    [EnumMember(Value = "QPEO")]
    [IsoId("_nTiX0A4oEeSvVsudrRLaVg")]
    [Description(@"Query for orders have been partially executed.")]
    QueryPartiallyExecutedOrder,
    
    /// <summary>
    /// Query for orders have been completely executed.
    /// Encoded/decoded by serializers as &quot;QFEO&quot;.
    /// </summary>
    [EnumMember(Value = "QFEO")]
    [IsoId("_B0iKQA4pEeSvVsudrRLaVg")]
    [Description(@"Query for orders have been completely executed.")]
    QueryFullyExecutedOrder,
    
    /// <summary>
    /// Query for all orders for a party.
    /// Encoded/decoded by serializers as &quot;QOFP&quot;.
    /// </summary>
    [EnumMember(Value = "QOFP")]
    [IsoId("_7Rxz0B0OEeStecMDdGBmFg")]
    [Description(@"Query for all orders for a party.")]
    QueryOrdersForTheParty,
    
}
