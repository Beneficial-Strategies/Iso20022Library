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
    /// Choice between a percentage price or an amount price.
    /// </summary>
    [KnownType(typeof(PriceFormat5Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat5Choice.AmountPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat5Choice.PercentagePrice),nameof(PriceFormat5Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat5Choice.AmountPrice),nameof(PriceFormat5Choice.AmountPrice))]
    #endif
    [IsoId("_Q10yydp-Ed-ak6NoX_4Aeg_334581022")]
    [DisplayName("Price Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat5Choice_
    #else
    public abstract partial class PriceFormat5Choice_
    #endif
    {
    }
}
