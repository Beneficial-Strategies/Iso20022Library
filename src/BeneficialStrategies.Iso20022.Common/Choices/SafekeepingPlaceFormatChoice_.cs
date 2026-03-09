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
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormatChoice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsDSS))]
    [KnownType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsCountry))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormatChoice.Identification),nameof(SafekeepingPlaceFormatChoice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsDSS),nameof(SafekeepingPlaceFormatChoice.IdentificationAsDSS))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsCountry),nameof(SafekeepingPlaceFormatChoice.IdentificationAsCountry))]
    #endif
    [IsoId("_RB5f5Np-Ed-ak6NoX_4Aeg_-418949931")]
    [DisplayName("Safekeeping Place Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormatChoice_
    #else
    public abstract partial class SafekeepingPlaceFormatChoice_
    #endif
    {
    }
}
