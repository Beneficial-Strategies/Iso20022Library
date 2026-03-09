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
    /// Choice between a standard code or proprietary code to specify the type of conversion.
    /// </summary>
    [KnownType(typeof(ConversionTypeFormat4Choice.Code))]
    [KnownType(typeof(ConversionTypeFormat4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ConversionTypeFormat4Choice.Code),nameof(ConversionTypeFormat4Choice.Code))]
    [JsonDerivedType(typeof(ConversionTypeFormat4Choice.Proprietary),nameof(ConversionTypeFormat4Choice.Proprietary))]
    #endif
    [IsoId("_c5VTb5KQEeWHWpTQn1FFVg")]
    [DisplayName("Conversion Type Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConversionTypeFormat4Choice_
    #else
    public abstract partial class ConversionTypeFormat4Choice_
    #endif
    {
    }
}
