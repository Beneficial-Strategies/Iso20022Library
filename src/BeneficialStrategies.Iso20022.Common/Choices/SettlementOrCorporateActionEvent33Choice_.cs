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
    [KnownType(typeof(SettlementOrCorporateActionEvent33Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent33Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent33Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent33Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent33Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent33Choice.CorporateActionEventType))]
    #endif
    [IsoId("_s9qhPAVVEeqjd8n6wD9JVw")]
    [DisplayName("Settlement Or Corporate Action Event 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent33Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent33Choice_
    #endif
    {
    }
}
