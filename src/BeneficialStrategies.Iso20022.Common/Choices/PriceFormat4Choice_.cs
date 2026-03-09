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
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat4Choice.Amount))]
    [KnownType(typeof(PriceFormat4Choice.Rate))]
    [KnownType(typeof(PriceFormat4Choice.NotSpecified))]
    [KnownType(typeof(PriceFormat4Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat4Choice.Amount),nameof(PriceFormat4Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat4Choice.Rate),nameof(PriceFormat4Choice.Rate))]
    [JsonDerivedType(typeof(PriceFormat4Choice.NotSpecified),nameof(PriceFormat4Choice.NotSpecified))]
    [JsonDerivedType(typeof(PriceFormat4Choice.IndexPoints),nameof(PriceFormat4Choice.IndexPoints))]
    #endif
    [IsoId("_QbJo8tp-Ed-ak6NoX_4Aeg_-733600915")]
    [DisplayName("Price Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat4Choice_
    #else
    public abstract partial class PriceFormat4Choice_
    #endif
    {
    }
}
