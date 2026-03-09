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
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType38Choice.Code))]
    [KnownType(typeof(RateType38Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateType38Choice.Code),nameof(RateType38Choice.Code))]
    [JsonDerivedType(typeof(RateType38Choice.Proprietary),nameof(RateType38Choice.Proprietary))]
    #endif
    [IsoId("_nGufYUEMEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType38Choice_
    #else
    public abstract partial class RateType38Choice_
    #endif
    {
    }
}
