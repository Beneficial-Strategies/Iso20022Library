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
    [KnownType(typeof(References58Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References58Choice.PoolIdentification))]
    [KnownType(typeof(References58Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References58Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References58Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References58Choice.SecuritiesSettlementTransactionIdentification),nameof(References58Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References58Choice.PoolIdentification),nameof(References58Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References58Choice.IntraPositionMovementIdentification),nameof(References58Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References58Choice.AccountServicerTransactionIdentification),nameof(References58Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References58Choice.OtherTransactionIdentification),nameof(References58Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_61RR85NLEeWGlc8L7oPDIg")]
    [DisplayName("References 58 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References58Choice_
    #else
    public abstract partial class References58Choice_
    #endif
    {
    }
}
