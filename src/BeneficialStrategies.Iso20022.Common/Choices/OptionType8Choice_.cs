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
    /// Choice of format for option type.
    /// </summary>
    [KnownType(typeof(OptionType8Choice.Code))]
    [KnownType(typeof(OptionType8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionType8Choice.Code),nameof(OptionType8Choice.Code))]
    [JsonDerivedType(typeof(OptionType8Choice.Proprietary),nameof(OptionType8Choice.Proprietary))]
    #endif
    [IsoId("_xoFSIeLaEeWFtOV72FbX9w")]
    [DisplayName("Option Type 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionType8Choice_
    #else
    public abstract partial class OptionType8Choice_
    #endif
    {
    }
}
