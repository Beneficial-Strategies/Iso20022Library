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
    /// Choice of format for the form of securities.
    /// </summary>
    [KnownType(typeof(FormOfSecurity6Choice.Code))]
    [KnownType(typeof(FormOfSecurity6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FormOfSecurity6Choice.Code),nameof(FormOfSecurity6Choice.Code))]
    [JsonDerivedType(typeof(FormOfSecurity6Choice.Proprietary),nameof(FormOfSecurity6Choice.Proprietary))]
    #endif
    [IsoId("_MBPGgTm-EeWV5sr121Fc8A")]
    [DisplayName("Form Of Security 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FormOfSecurity6Choice_
    #else
    public abstract partial class FormOfSecurity6Choice_
    #endif
    {
    }
}
