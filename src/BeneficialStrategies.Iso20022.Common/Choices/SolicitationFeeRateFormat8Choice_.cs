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
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SolicitationFeeRateFormat8Choice.Rate),nameof(SolicitationFeeRateFormat8Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat8Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat8Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat8Choice.Amount),nameof(SolicitationFeeRateFormat8Choice.Amount))]
    #endif
    [IsoId("_NlMNz2NZEeW4z96Yfj3Wng")]
    [DisplayName("Solicitation Fee Rate Format 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat8Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat8Choice_
    #endif
    {
    }
}
