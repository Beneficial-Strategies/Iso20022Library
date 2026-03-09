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
    [KnownType(typeof(SettlementOrCorporateActionEvent31Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent31Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent31Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent31Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent31Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent31Choice.CorporateActionEventType))]
    #endif
    [IsoId("_fOXgDemrEemUgrefIx730g")]
    [DisplayName("Settlement Or Corporate Action Event 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent31Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent31Choice_
    #endif
    {
    }
}
