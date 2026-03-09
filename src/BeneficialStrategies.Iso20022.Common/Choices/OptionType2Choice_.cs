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
    [KnownType(typeof(OptionType2Choice.Code))]
    [KnownType(typeof(OptionType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionType2Choice.Code),nameof(OptionType2Choice.Code))]
    [JsonDerivedType(typeof(OptionType2Choice.Proprietary),nameof(OptionType2Choice.Proprietary))]
    #endif
    [IsoId("_Qu-j4Np-Ed-ak6NoX_4Aeg_-1994386821")]
    [DisplayName("Option Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionType2Choice_
    #else
    public abstract partial class OptionType2Choice_
    #endif
    {
    }
}
