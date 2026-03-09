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
    [KnownType(typeof(PriceType2Choice.Market))]
    [KnownType(typeof(PriceType2Choice.Indicative))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceType2Choice.Market),nameof(PriceType2Choice.Market))]
    [JsonDerivedType(typeof(PriceType2Choice.Indicative),nameof(PriceType2Choice.Indicative))]
    #endif
    [IsoId("_XLcRBdp-Ed-ak6NoX_4Aeg_-173872087")]
    [DisplayName("Price Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceType2Choice_
    #else
    public abstract partial class PriceType2Choice_
    #endif
    {
    }
}
