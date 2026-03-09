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
    /// Choice of price type.
    /// </summary>
    [KnownType(typeof(PriceType4Choice.Market))]
    [KnownType(typeof(PriceType4Choice.Indicative))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceType4Choice.Market),nameof(PriceType4Choice.Market))]
    [JsonDerivedType(typeof(PriceType4Choice.Indicative),nameof(PriceType4Choice.Indicative))]
    #endif
    [IsoId("_ys8oMbQBEee1Ke-6rZgsrA")]
    [DisplayName("Price Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceType4Choice_
    #else
    public abstract partial class PriceType4Choice_
    #endif
    {
    }
}
