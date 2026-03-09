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
    [KnownType(typeof(OfferTypeFormat1Choice.Code))]
    [KnownType(typeof(OfferTypeFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OfferTypeFormat1Choice.Code),nameof(OfferTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(OfferTypeFormat1Choice.Proprietary),nameof(OfferTypeFormat1Choice.Proprietary))]
    #endif
    [IsoId("_Q3nigtp-Ed-ak6NoX_4Aeg_789019440")]
    [DisplayName("Offer Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OfferTypeFormat1Choice_
    #else
    public abstract partial class OfferTypeFormat1Choice_
    #endif
    {
    }
}
