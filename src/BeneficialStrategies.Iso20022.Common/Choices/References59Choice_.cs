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
    [KnownType(typeof(References59Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References59Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References59Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References59Choice.IntraPositionMovementIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References59Choice.OtherTransactionIdentification),nameof(References59Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References59Choice.SecuritiesFinancingTransactionIdentification),nameof(References59Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References59Choice.SecuritiesSettlementTransactionIdentification),nameof(References59Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References59Choice.IntraPositionMovementIdentification),nameof(References59Choice.IntraPositionMovementIdentification))]
    #endif
    [IsoId("_8ScaD5NLEeWGlc8L7oPDIg")]
    [DisplayName("References 59 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References59Choice_
    #else
    public abstract partial class References59Choice_
    #endif
    {
    }
}
