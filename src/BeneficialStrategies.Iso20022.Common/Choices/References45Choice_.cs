// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References45Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References45Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References45Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References45Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References45Choice.SecuritiesSettlementTransactionIdentification),nameof(References45Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References45Choice.SecuritiesFinancingTransactionIdentification),nameof(References45Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References45Choice.IntraPositionMovementIdentification),nameof(References45Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References45Choice.OtherTransactionIdentification),nameof(References45Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_RbgB0ztpEeWHYdqXF6YZmg")]
    [DisplayName("References 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References45Choice_
    #else
    public abstract partial class References45Choice_
    #endif
    {
    }
}
