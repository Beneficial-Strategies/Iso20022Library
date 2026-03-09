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
    [KnownType(typeof(SettlementOrCorporateActionEvent14Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent14Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent14Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent14Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent14Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent14Choice.CorporateActionEventType))]
    #endif
    [IsoId("_-e-JczqDEeWVrPy0StzzSg")]
    [DisplayName("Settlement Or Corporate Action Event 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent14Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent14Choice_
    #endif
    {
    }
}
