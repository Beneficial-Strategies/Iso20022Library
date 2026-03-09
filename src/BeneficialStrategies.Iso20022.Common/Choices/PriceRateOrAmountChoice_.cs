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
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountChoice.Rate))]
    [KnownType(typeof(PriceRateOrAmountChoice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceRateOrAmountChoice.Rate),nameof(PriceRateOrAmountChoice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmountChoice.Amount),nameof(PriceRateOrAmountChoice.Amount))]
    #endif
    [IsoId("_QaaCGNp-Ed-ak6NoX_4Aeg_-1974423999")]
    [DisplayName("Price Rate Or Amount Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceRateOrAmountChoice_
    #else
    public abstract partial class PriceRateOrAmountChoice_
    #endif
    {
    }
}
