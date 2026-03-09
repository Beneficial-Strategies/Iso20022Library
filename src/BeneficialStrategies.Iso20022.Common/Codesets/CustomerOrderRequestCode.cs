// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer orders that must be sent in response message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ETkWwN6JEeiwsev40qZGEQ")]
[Description(@"Type of customer orders that must be sent in response message.")]
[Derivations(typeof(CustomerOrderRequest1Code))]
public enum CustomerOrderRequestCode
{
    /// <summary>
    /// Customer order not completed.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_J3KiMN6JEeiwsev40qZGEQ")]
    [Description(@"Customer order not completed.")]
    Open,
    
    /// <summary>
    /// Completed customer orders.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_J5EmsN6JEeiwsev40qZGEQ")]
    [Description(@"Completed customer orders.")]
    Closed,
    
    /// <summary>
    /// All types of CustomerOrder should be listed, some are open others closed.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_J-B_MN6JEeiwsev40qZGEQ")]
    [Description(@"All types of CustomerOrder should be listed, some are open others closed.")]
    Both,
    
}
