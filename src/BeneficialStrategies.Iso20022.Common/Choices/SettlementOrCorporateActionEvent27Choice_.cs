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
    [KnownType(typeof(SettlementOrCorporateActionEvent27Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent27Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent27Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent27Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent27Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent27Choice.CorporateActionEventType))]
    #endif
    [IsoId("_U11c0dEmEeiO-eodGv5iKQ")]
    [DisplayName("Settlement Or Corporate Action Event 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent27Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent27Choice_
    #endif
    {
    }
}
