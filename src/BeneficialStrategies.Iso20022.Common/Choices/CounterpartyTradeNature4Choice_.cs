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
    [KnownType(typeof(CounterpartyTradeNature4Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature4Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature4Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature4Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.FinancialInstitution),nameof(CounterpartyTradeNature4Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature4Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.CentralCounterParty),nameof(CounterpartyTradeNature4Choice.CentralCounterParty))]
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.Other),nameof(CounterpartyTradeNature4Choice.Other))]
    #endif
    [IsoId("_6UemybsAEea-m5tPqiasmQ")]
    [DisplayName("Counterparty Trade Nature 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyTradeNature4Choice_
    #else
    public abstract partial class CounterpartyTradeNature4Choice_
    #endif
    {
    }
}
