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
    [KnownType(typeof(CounterpartyTradeNature9Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature9Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature9Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature9Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CounterpartyTradeNature9Choice.FinancialInstitution),nameof(CounterpartyTradeNature9Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature9Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature9Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature9Choice.CentralCounterParty),nameof(CounterpartyTradeNature9Choice.CentralCounterParty))]
    [JsonDerivedType(typeof(CounterpartyTradeNature9Choice.Other),nameof(CounterpartyTradeNature9Choice.Other))]
    #endif
    [IsoId("_hsQpoT7KEeq0cMLnAmm7Lg")]
    [DisplayName("Counterparty Trade Nature 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyTradeNature9Choice_
    #else
    public abstract partial class CounterpartyTradeNature9Choice_
    #endif
    {
    }
}
