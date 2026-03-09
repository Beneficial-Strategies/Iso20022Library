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
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.Rate),nameof(SolicitationFeeRateFormat5Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat5Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.Amount),nameof(SolicitationFeeRateFormat5Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat5Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_REpUgRLsEeKJ5uSjVyVvug")]
    [DisplayName("Solicitation Fee Rate Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat5Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat5Choice_
    #endif
    {
    }
}
