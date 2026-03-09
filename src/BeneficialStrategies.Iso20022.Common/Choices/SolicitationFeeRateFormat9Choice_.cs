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
    [KnownType(typeof(SolicitationFeeRateFormat9Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat9Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat9Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SolicitationFeeRateFormat9Choice.Rate),nameof(SolicitationFeeRateFormat9Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat9Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat9Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat9Choice.Amount),nameof(SolicitationFeeRateFormat9Choice.Amount))]
    #endif
    [IsoId("_ckNXm5KQEeWHWpTQn1FFVg")]
    [DisplayName("Solicitation Fee Rate Format 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat9Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat9Choice_
    #endif
    {
    }
}
