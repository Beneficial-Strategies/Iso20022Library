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
    [KnownType(typeof(References4Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References4Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References4Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References4Choice.IntraPositionMovementIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References4Choice.OtherTransactionIdentification),nameof(References4Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References4Choice.SecuritiesFinancingTransactionIdentification),nameof(References4Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References4Choice.SecuritiesSettlementTransactionIdentification),nameof(References4Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References4Choice.IntraPositionMovementIdentification),nameof(References4Choice.IntraPositionMovementIdentification))]
    #endif
    [IsoId("_UR6fK9p-Ed-ak6NoX_4Aeg_1775353480")]
    [DisplayName("References 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References4Choice_
    #else
    public abstract partial class References4Choice_
    #endif
    {
    }
}
