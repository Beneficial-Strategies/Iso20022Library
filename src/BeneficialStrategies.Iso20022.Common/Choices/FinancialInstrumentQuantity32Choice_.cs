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
    /// Defines the format for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity32Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity32Choice.NominalValue))]
    [KnownType(typeof(FinancialInstrumentQuantity32Choice.MonetaryValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity32Choice.Unit),nameof(FinancialInstrumentQuantity32Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity32Choice.NominalValue),nameof(FinancialInstrumentQuantity32Choice.NominalValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity32Choice.MonetaryValue),nameof(FinancialInstrumentQuantity32Choice.MonetaryValue))]
    #endif
    [IsoId("_Y6yLkZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Financial Instrument Quantity 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity32Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity32Choice_
    #endif
    {
    }
}
