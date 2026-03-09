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
    /// Choice of format for the option type.
    /// </summary>
    [KnownType(typeof(OptionType6Choice.Code))]
    [KnownType(typeof(OptionType6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionType6Choice.Code),nameof(OptionType6Choice.Code))]
    [JsonDerivedType(typeof(OptionType6Choice.Proprietary),nameof(OptionType6Choice.Proprietary))]
    #endif
    [IsoId("_tfykITnCEeWV5sr121Fc8A")]
    [DisplayName("Option Type 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionType6Choice_
    #else
    public abstract partial class OptionType6Choice_
    #endif
    {
    }
}
