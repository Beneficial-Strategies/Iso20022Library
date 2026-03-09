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
    /// Choice between a standard code or proprietary code to specify the type of offer.
    /// </summary>
    [KnownType(typeof(OfferTypeFormat12Choice.Code))]
    [KnownType(typeof(OfferTypeFormat12Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OfferTypeFormat12Choice.Code),nameof(OfferTypeFormat12Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat12Choice.Proprietary),nameof(OfferTypeFormat12Choice.Proprietary))]
    #endif
    [IsoId("_xf7D0Re1EeyroI8qKgB7Mg")]
    [DisplayName("Offer Type Format 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OfferTypeFormat12Choice_
    #else
    public abstract partial class OfferTypeFormat12Choice_
    #endif
    {
    }
}
