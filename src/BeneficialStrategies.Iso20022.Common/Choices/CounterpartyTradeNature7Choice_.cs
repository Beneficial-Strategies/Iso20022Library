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
    /// Nature of the company activities of the reporting counterparty.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature7Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature7Choice.NonFinancialInstitution))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CounterpartyTradeNature7Choice.FinancialInstitution),nameof(CounterpartyTradeNature7Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature7Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature7Choice.NonFinancialInstitution))]
    #endif
    [IsoId("_-N5Qman9EemdLtwzt4CWxg")]
    [DisplayName("Counterparty Trade Nature 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyTradeNature7Choice_
    #else
    public abstract partial class CounterpartyTradeNature7Choice_
    #endif
    {
    }
}
