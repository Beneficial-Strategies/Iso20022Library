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
    [KnownType(typeof(References22Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References22Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References22Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References22Choice.IntraPositionMovementIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References22Choice.OtherTransactionIdentification),nameof(References22Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References22Choice.SecuritiesFinancingTransactionIdentification),nameof(References22Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References22Choice.SecuritiesSettlementTransactionIdentification),nameof(References22Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References22Choice.IntraPositionMovementIdentification),nameof(References22Choice.IntraPositionMovementIdentification))]
    #endif
    [IsoId("_H4smNk-2EeCKyoyCaiI0rw")]
    [DisplayName("References 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References22Choice_
    #else
    public abstract partial class References22Choice_
    #endif
    {
    }
}
