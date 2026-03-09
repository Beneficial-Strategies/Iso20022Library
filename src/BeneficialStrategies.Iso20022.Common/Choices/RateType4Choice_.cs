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
    /// Specifies the rate as a percentage or a text.
    /// </summary>
    [KnownType(typeof(RateType4Choice.Percentage))]
    [KnownType(typeof(RateType4Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateType4Choice.Percentage),nameof(RateType4Choice.Percentage))]
    [JsonDerivedType(typeof(RateType4Choice.Other),nameof(RateType4Choice.Other))]
    #endif
    [IsoId("_Rp-zkdp-Ed-ak6NoX_4Aeg_-171034137")]
    [DisplayName("Rate Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType4Choice_
    #else
    public abstract partial class RateType4Choice_
    #endif
    {
    }
}
