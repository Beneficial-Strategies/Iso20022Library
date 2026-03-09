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
    /// Choice between a percentage rate or a rate index or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrType1Choice.Rate))]
    [KnownType(typeof(RateOrType1Choice.Type))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateOrType1Choice.Rate),nameof(RateOrType1Choice.Rate))]
    [JsonDerivedType(typeof(RateOrType1Choice.Type),nameof(RateOrType1Choice.Type))]
    #endif
    [IsoId("_XAtno8IiEeuexrfMa3dl_Q")]
    [DisplayName("Rate Or Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateOrType1Choice_
    #else
    public abstract partial class RateOrType1Choice_
    #endif
    {
    }
}
