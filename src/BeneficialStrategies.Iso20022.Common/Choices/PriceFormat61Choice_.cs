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
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat61Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat61Choice.NotSpecifiedPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat61Choice.AmountPrice),nameof(PriceFormat61Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat61Choice.NotSpecifiedPrice),nameof(PriceFormat61Choice.NotSpecifiedPrice))]
    #endif
    [IsoId("_4doiepbREee8S7xwGG7Veg")]
    [DisplayName("Price Format 61 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat61Choice_
    #else
    public abstract partial class PriceFormat61Choice_
    #endif
    {
    }
}
