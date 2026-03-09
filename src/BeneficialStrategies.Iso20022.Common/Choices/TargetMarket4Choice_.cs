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
    /// Choice of formats for the specification of how a financial product is in scope of a target market parameter.
    /// </summary>
    [KnownType(typeof(TargetMarket4Choice.Type))]
    [KnownType(typeof(TargetMarket4Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TargetMarket4Choice.Type),nameof(TargetMarket4Choice.Type))]
    [JsonDerivedType(typeof(TargetMarket4Choice.Other),nameof(TargetMarket4Choice.Other))]
    #endif
    [IsoId("_eEqHsNdhEeibyvRfU9vJ7w")]
    [DisplayName("Target Market 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TargetMarket4Choice_
    #else
    public abstract partial class TargetMarket4Choice_
    #endif
    {
    }
}
