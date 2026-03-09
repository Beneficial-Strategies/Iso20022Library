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
    [KnownType(typeof(RateOrName4Choice.Rate))]
    [KnownType(typeof(RateOrName4Choice.RateIndexDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateOrName4Choice.Rate),nameof(RateOrName4Choice.Rate))]
    [JsonDerivedType(typeof(RateOrName4Choice.RateIndexDetails),nameof(RateOrName4Choice.RateIndexDetails))]
    #endif
    [IsoId("_KYxnQRIlEeyLzJfz3xPQNA")]
    [DisplayName("Rate Or Name 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateOrName4Choice_
    #else
    public abstract partial class RateOrName4Choice_
    #endif
    {
    }
}
