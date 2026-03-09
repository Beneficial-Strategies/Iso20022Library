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
    [KnownType(typeof(SettlementOrCorporateActionEvent10Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent10Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent10Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent10Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent10Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent10Choice.CorporateActionEventType))]
    #endif
    [IsoId("_tF4tARHAEeKHC-9MYSJwtQ")]
    [DisplayName("Settlement Or Corporate Action Event 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent10Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent10Choice_
    #endif
    {
    }
}
