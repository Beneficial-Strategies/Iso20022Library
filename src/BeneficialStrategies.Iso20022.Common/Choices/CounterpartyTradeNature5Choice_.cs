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
    /// Nature of the reporting counterparty&apos;s company activities.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature5Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature5Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature5Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature5Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.FinancialInstitution),nameof(CounterpartyTradeNature5Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature5Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.CentralCounterParty),nameof(CounterpartyTradeNature5Choice.CentralCounterParty))]
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.Other),nameof(CounterpartyTradeNature5Choice.Other))]
    #endif
    [IsoId("_9qIT-bsAEea-m5tPqiasmQ")]
    [DisplayName("Counterparty Trade Nature 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyTradeNature5Choice_
    #else
    public abstract partial class CounterpartyTradeNature5Choice_
    #endif
    {
    }
}
