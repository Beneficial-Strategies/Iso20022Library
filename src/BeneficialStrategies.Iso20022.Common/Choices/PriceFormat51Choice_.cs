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
    /// Choice between a percentage price or an amount price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat51Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat51Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat51Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat51Choice.PercentagePrice),nameof(PriceFormat51Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat51Choice.AmountPrice),nameof(PriceFormat51Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat51Choice.IndexPoints),nameof(PriceFormat51Choice.IndexPoints))]
    #endif
    [IsoId("_Wy2joUGNEeWqy4niLuXETA")]
    [DisplayName("Price Format 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat51Choice_
    #else
    public abstract partial class PriceFormat51Choice_
    #endif
    {
    }
}
