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
    [KnownType(typeof(References47Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References47Choice.PoolIdentification))]
    [KnownType(typeof(References47Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References47Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References47Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References47Choice.SecuritiesSettlementTransactionIdentification),nameof(References47Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References47Choice.PoolIdentification),nameof(References47Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References47Choice.IntraPositionMovementIdentification),nameof(References47Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References47Choice.AccountServicerTransactionIdentification),nameof(References47Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References47Choice.OtherTransactionIdentification),nameof(References47Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_JqlFATzbEeWeNtT0s2RbkQ")]
    [DisplayName("References 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References47Choice_
    #else
    public abstract partial class References47Choice_
    #endif
    {
    }
}
