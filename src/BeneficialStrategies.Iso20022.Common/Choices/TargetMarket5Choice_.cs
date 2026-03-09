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
    [KnownType(typeof(TargetMarket5Choice.Type))]
    [KnownType(typeof(TargetMarket5Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TargetMarket5Choice.Type),nameof(TargetMarket5Choice.Type))]
    [JsonDerivedType(typeof(TargetMarket5Choice.Other),nameof(TargetMarket5Choice.Other))]
    #endif
    [IsoId("_xLdncbVLEeqkjqDuFVh1-A")]
    [DisplayName("Target Market 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TargetMarket5Choice_
    #else
    public abstract partial class TargetMarket5Choice_
    #endif
    {
    }
}
