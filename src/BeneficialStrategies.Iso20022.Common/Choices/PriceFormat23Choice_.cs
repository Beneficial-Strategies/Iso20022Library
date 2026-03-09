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
    /// Choice between a percentage price or an amount price or an unspecified price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat23Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat23Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat23Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat23Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat23Choice.PercentagePrice),nameof(PriceFormat23Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat23Choice.AmountPrice),nameof(PriceFormat23Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat23Choice.NotSpecifiedPrice),nameof(PriceFormat23Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat23Choice.IndexPoints),nameof(PriceFormat23Choice.IndexPoints))]
    #endif
    [IsoId("_ASFIoOwOEd-sn-FiNtktcA")]
    [DisplayName("Price Format 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat23Choice_
    #else
    public abstract partial class PriceFormat23Choice_
    #endif
    {
    }
}
