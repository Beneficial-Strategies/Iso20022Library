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
    [KnownType(typeof(SolicitationFeeRateFormat3Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat3Choice.NotSpecifiedRate))]
    [KnownType(typeof(SolicitationFeeRateFormat3Choice.AmountToQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SolicitationFeeRateFormat3Choice.Rate),nameof(SolicitationFeeRateFormat3Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat3Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat3Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat3Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat3Choice.AmountToQuantity))]
    #endif
    [IsoId("_3xdV8OwOEd-sn-FiNtktcA")]
    [DisplayName("Solicitation Fee Rate Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat3Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat3Choice_
    #endif
    {
    }
}
