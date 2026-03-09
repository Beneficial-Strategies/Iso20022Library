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
    [KnownType(typeof(PriceFormat2Choice.Amount))]
    [KnownType(typeof(PriceFormat2Choice.Rate))]
    [KnownType(typeof(PriceFormat2Choice.NotSpecified))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat2Choice.Amount),nameof(PriceFormat2Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat2Choice.Rate),nameof(PriceFormat2Choice.Rate))]
    [JsonDerivedType(typeof(PriceFormat2Choice.NotSpecified),nameof(PriceFormat2Choice.NotSpecified))]
    #endif
    [IsoId("_QatkG9p-Ed-ak6NoX_4Aeg_-495676528")]
    [DisplayName("Price Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat2Choice_
    #else
    public abstract partial class PriceFormat2Choice_
    #endif
    {
    }
}
