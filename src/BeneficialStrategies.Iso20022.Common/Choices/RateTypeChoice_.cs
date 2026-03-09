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
    /// Rate is expressed as a percentage or a text.
    /// </summary>
    [KnownType(typeof(RateTypeChoice.PercentageRate))]
    [KnownType(typeof(RateTypeChoice.TextualRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateTypeChoice.PercentageRate),nameof(RateTypeChoice.PercentageRate))]
    [JsonDerivedType(typeof(RateTypeChoice.TextualRate),nameof(RateTypeChoice.TextualRate))]
    #endif
    [IsoId("_RIwV0dp-Ed-ak6NoX_4Aeg_-1267403783")]
    [DisplayName("Rate Type Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateTypeChoice_
    #else
    public abstract partial class RateTypeChoice_
    #endif
    {
    }
}
