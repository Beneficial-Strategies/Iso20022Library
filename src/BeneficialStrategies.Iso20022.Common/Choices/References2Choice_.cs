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
    [KnownType(typeof(References2Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References2Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References2Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References2Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References2Choice.SecuritiesSettlementTransactionIdentification),nameof(References2Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References2Choice.SecuritiesFinancingTransactionIdentification),nameof(References2Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References2Choice.IntraPositionMovementIdentification),nameof(References2Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References2Choice.OtherTransactionIdentification),nameof(References2Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_US9oCdp-Ed-ak6NoX_4Aeg_1980096839")]
    [DisplayName("References 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References2Choice_
    #else
    public abstract partial class References2Choice_
    #endif
    {
    }
}
