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
    [KnownType(typeof(References44Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References44Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References44Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References44Choice.IntraPositionMovementIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References44Choice.OtherTransactionIdentification),nameof(References44Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References44Choice.SecuritiesFinancingTransactionIdentification),nameof(References44Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References44Choice.SecuritiesSettlementTransactionIdentification),nameof(References44Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References44Choice.IntraPositionMovementIdentification),nameof(References44Choice.IntraPositionMovementIdentification))]
    #endif
    [IsoId("_Hoo5QTqoEeWyoP0PbocV1Q")]
    [DisplayName("References 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References44Choice_
    #else
    public abstract partial class References44Choice_
    #endif
    {
    }
}
