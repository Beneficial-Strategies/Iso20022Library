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
    [KnownType(typeof(SettlementOrCorporateActionEvent29Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent29Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent29Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent29Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent29Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent29Choice.CorporateActionEventType))]
    #endif
    [IsoId("_sanT8_fZEeiNZp_PtLohLw")]
    [DisplayName("Settlement Or Corporate Action Event 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent29Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent29Choice_
    #endif
    {
    }
}
