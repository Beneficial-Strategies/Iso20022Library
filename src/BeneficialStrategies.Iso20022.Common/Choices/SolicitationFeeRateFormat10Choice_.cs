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
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.Rate),nameof(SolicitationFeeRateFormat10Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat10Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.Amount),nameof(SolicitationFeeRateFormat10Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat10Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_ctoZN5KQEeWHWpTQn1FFVg")]
    [DisplayName("Solicitation Fee Rate Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat10Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat10Choice_
    #endif
    {
    }
}
