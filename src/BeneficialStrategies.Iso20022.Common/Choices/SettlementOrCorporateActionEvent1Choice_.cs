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
    [KnownType(typeof(SettlementOrCorporateActionEvent1Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent1Choice.CorporateActionEventType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent1Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent1Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent1Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent1Choice.CorporateActionEventType))]
    #endif
    [IsoId("_QwUApdp-Ed-ak6NoX_4Aeg_1179810715")]
    [DisplayName("Settlement Or Corporate Action Event 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent1Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent1Choice_
    #endif
    {
    }
}
