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
    /// Choice of formats for the market for a type of investor expressed as a code.
    /// </summary>
    [KnownType(typeof(TargetMarket3Choice.Type))]
    [KnownType(typeof(TargetMarket3Choice.Other))]
    [KnownType(typeof(TargetMarket3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TargetMarket3Choice.Type),nameof(TargetMarket3Choice.Type))]
    [JsonDerivedType(typeof(TargetMarket3Choice.Other),nameof(TargetMarket3Choice.Other))]
    [JsonDerivedType(typeof(TargetMarket3Choice.Proprietary),nameof(TargetMarket3Choice.Proprietary))]
    #endif
    [IsoId("_JK13wDcREeiIxKQErQxblg")]
    [DisplayName("Target Market 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TargetMarket3Choice_
    #else
    public abstract partial class TargetMarket3Choice_
    #endif
    {
    }
}
