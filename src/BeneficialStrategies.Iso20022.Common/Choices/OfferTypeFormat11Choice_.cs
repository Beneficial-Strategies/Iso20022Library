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
    [KnownType(typeof(OfferTypeFormat11Choice.Code))]
    [KnownType(typeof(OfferTypeFormat11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OfferTypeFormat11Choice.Code),nameof(OfferTypeFormat11Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat11Choice.Proprietary),nameof(OfferTypeFormat11Choice.Proprietary))]
    #endif
    [IsoId("_cta945KQEeWHWpTQn1FFVg")]
    [DisplayName("Offer Type Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OfferTypeFormat11Choice_
    #else
    public abstract partial class OfferTypeFormat11Choice_
    #endif
    {
    }
}
