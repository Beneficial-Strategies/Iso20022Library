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
    [KnownType(typeof(OptionStyle4Choice.Code))]
    [KnownType(typeof(OptionStyle4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionStyle4Choice.Code),nameof(OptionStyle4Choice.Code))]
    [JsonDerivedType(typeof(OptionStyle4Choice.Proprietary),nameof(OptionStyle4Choice.Proprietary))]
    #endif
    [IsoId("_Q4NYYtp-Ed-ak6NoX_4Aeg_1303508122")]
    [DisplayName("Option Style 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionStyle4Choice_
    #else
    public abstract partial class OptionStyle4Choice_
    #endif
    {
    }
}
