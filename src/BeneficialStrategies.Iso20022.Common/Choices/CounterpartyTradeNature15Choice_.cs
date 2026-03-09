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
    /// Nature of the counterparty&apos;s company activities.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature15Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature15Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature15Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature15Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.FinancialInstitution),nameof(CounterpartyTradeNature15Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature15Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.CentralCounterParty),nameof(CounterpartyTradeNature15Choice.CentralCounterParty))]
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.Other),nameof(CounterpartyTradeNature15Choice.Other))]
    #endif
    [IsoId("_1y9eQQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Counterparty Trade Nature 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyTradeNature15Choice_
    #else
    public abstract partial class CounterpartyTradeNature15Choice_
    #endif
    {
    }
}
