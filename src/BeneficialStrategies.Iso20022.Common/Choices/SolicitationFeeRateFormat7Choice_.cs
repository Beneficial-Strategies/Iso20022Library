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
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.Rate),nameof(SolicitationFeeRateFormat7Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat7Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.Amount),nameof(SolicitationFeeRateFormat7Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat7Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_7y0l9UEKEeWVgfuHGaKtRQ")]
    [DisplayName("Solicitation Fee Rate Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat7Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat7Choice_
    #endif
    {
    }
}
