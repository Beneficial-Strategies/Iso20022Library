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
    [KnownType(typeof(OfferTypeFormat3Choice.Code))]
    [KnownType(typeof(OfferTypeFormat3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OfferTypeFormat3Choice.Code),nameof(OfferTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat3Choice.Proprietary),nameof(OfferTypeFormat3Choice.Proprietary))]
    #endif
    [IsoId("_q9LvwS87EeKNZpaVtgp8Wg")]
    [DisplayName("Offer Type Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OfferTypeFormat3Choice_
    #else
    public abstract partial class OfferTypeFormat3Choice_
    #endif
    {
    }
}
