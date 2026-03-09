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
    [KnownType(typeof(SolicitationFeeRateFormat1Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat1Choice.NotSpecifiedRate))]
    [KnownType(typeof(SolicitationFeeRateFormat1Choice.AmountToQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SolicitationFeeRateFormat1Choice.Rate),nameof(SolicitationFeeRateFormat1Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat1Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat1Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat1Choice.AmountToQuantity))]
    #endif
    [IsoId("_UOMcx9p-Ed-ak6NoX_4Aeg_-903069211")]
    [DisplayName("Solicitation Fee Rate Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat1Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat1Choice_
    #endif
    {
    }
}
