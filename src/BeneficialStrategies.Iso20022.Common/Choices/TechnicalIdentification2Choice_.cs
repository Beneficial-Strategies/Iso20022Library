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
    /// Selection between a generic technical address or a BIC identifier when setting up or modifying the technical address for a party.
    /// </summary>
    [KnownType(typeof(TechnicalIdentification2Choice.BICFI))]
    [KnownType(typeof(TechnicalIdentification2Choice.TechnicalAddress))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TechnicalIdentification2Choice.BICFI),nameof(TechnicalIdentification2Choice.BICFI))]
    [JsonDerivedType(typeof(TechnicalIdentification2Choice.TechnicalAddress),nameof(TechnicalIdentification2Choice.TechnicalAddress))]
    #endif
    [IsoId("_X5McYb11Eeiut6mmSKzDFQ")]
    [DisplayName("Technical Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TechnicalIdentification2Choice_
    #else
    public abstract partial class TechnicalIdentification2Choice_
    #endif
    {
    }
}
