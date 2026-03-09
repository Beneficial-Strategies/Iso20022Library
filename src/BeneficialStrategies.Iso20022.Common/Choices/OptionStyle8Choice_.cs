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
    /// Choice of format for the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle8Choice.Code))]
    [KnownType(typeof(OptionStyle8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionStyle8Choice.Code),nameof(OptionStyle8Choice.Code))]
    [JsonDerivedType(typeof(OptionStyle8Choice.Proprietary),nameof(OptionStyle8Choice.Proprietary))]
    #endif
    [IsoId("_g3ipUTq2EeWQ1Y7f8kds2A")]
    [DisplayName("Option Style 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionStyle8Choice_
    #else
    public abstract partial class OptionStyle8Choice_
    #endif
    {
    }
}
