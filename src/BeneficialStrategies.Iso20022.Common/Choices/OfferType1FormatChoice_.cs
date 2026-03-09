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
    /// Choice of formats to express the conditions that apply to the offer.
    /// </summary>
    [KnownType(typeof(OfferType1FormatChoice.Code))]
    [KnownType(typeof(OfferType1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OfferType1FormatChoice.Code),nameof(OfferType1FormatChoice.Code))]
    [JsonDerivedType(typeof(OfferType1FormatChoice.Proprietary),nameof(OfferType1FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rm2nEtp-Ed-ak6NoX_4Aeg_-1842379446")]
    [DisplayName("Offer Type 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OfferType1FormatChoice_
    #else
    public abstract partial class OfferType1FormatChoice_
    #endif
    {
    }
}
