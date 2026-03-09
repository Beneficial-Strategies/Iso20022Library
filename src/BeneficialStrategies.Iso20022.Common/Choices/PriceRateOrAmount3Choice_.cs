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
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmount3Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmount3Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceRateOrAmount3Choice.Rate),nameof(PriceRateOrAmount3Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmount3Choice.Amount),nameof(PriceRateOrAmount3Choice.Amount))]
    #endif
    [IsoId("_dnG1obQBEee1Ke-6rZgsrA")]
    [DisplayName("Price Rate Or Amount 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceRateOrAmount3Choice_
    #else
    public abstract partial class PriceRateOrAmount3Choice_
    #endif
    {
    }
}
