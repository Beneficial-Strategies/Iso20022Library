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
    /// Provides an amount choice between currency or digital token.
    /// </summary>
    [KnownType(typeof(CurrencyOrDigitalTokenAmount1Choice.Amount))]
    [KnownType(typeof(CurrencyOrDigitalTokenAmount1Choice.DigitalTokenAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CurrencyOrDigitalTokenAmount1Choice.Amount),nameof(CurrencyOrDigitalTokenAmount1Choice.Amount))]
    [JsonDerivedType(typeof(CurrencyOrDigitalTokenAmount1Choice.DigitalTokenAmount),nameof(CurrencyOrDigitalTokenAmount1Choice.DigitalTokenAmount))]
    #endif
    [IsoId("_mG0UsANhEe2-vqzwMUAewg")]
    [DisplayName("Currency Or Digital Token Amount 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CurrencyOrDigitalTokenAmount1Choice_
    #else
    public abstract partial class CurrencyOrDigitalTokenAmount1Choice_
    #endif
    {
    }
}
