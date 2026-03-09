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
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent5Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent5Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent5Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent5Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent5Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent5Choice.CorporateActionEventType))]
    #endif
    [IsoId("_PlRa6fvmEeCBQp5TnX1XKQ")]
    [DisplayName("Settlement Or Corporate Action Event 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent5Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent5Choice_
    #endif
    {
    }
}
