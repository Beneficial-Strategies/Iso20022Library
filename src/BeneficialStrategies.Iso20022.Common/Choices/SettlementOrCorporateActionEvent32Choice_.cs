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
    [KnownType(typeof(SettlementOrCorporateActionEvent32Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent32Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent32Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent32Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent32Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent32Choice.CorporateActionEventType))]
    #endif
    [IsoId("_ipRlwAVVEeqjd8n6wD9JVw")]
    [DisplayName("Settlement Or Corporate Action Event 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent32Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent32Choice_
    #endif
    {
    }
}
