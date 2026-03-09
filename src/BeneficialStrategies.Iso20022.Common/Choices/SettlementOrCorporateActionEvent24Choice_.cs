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
    [KnownType(typeof(SettlementOrCorporateActionEvent24Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent24Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent24Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent24Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent24Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent24Choice.CorporateActionEventType))]
    #endif
    [IsoId("_7k6mLc32Eee5nJBZsW8MFQ")]
    [DisplayName("Settlement Or Corporate Action Event 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent24Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent24Choice_
    #endif
    {
    }
}
