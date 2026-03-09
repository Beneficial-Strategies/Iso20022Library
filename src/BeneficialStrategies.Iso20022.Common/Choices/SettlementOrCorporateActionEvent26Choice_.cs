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
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent26Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent26Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent26Choice.CorporateActionEventType))]
    #endif
    [IsoId("_eA1Q7dEfEeiO-eodGv5iKQ")]
    [DisplayName("Settlement Or Corporate Action Event 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent26Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent26Choice_
    #endif
    {
    }
}
