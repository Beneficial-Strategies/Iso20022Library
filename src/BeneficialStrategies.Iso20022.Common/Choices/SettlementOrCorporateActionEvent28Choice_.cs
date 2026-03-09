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
    [KnownType(typeof(SettlementOrCorporateActionEvent28Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent28Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent28Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent28Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent28Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent28Choice.CorporateActionEventType))]
    #endif
    [IsoId("_iE4RXffZEeiNZp_PtLohLw")]
    [DisplayName("Settlement Or Corporate Action Event 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent28Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent28Choice_
    #endif
    {
    }
}
