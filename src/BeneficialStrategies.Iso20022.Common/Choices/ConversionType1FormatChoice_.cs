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
    /// Choice of formats to express the type of conversion.
    /// </summary>
    [KnownType(typeof(ConversionType1FormatChoice.Code))]
    [KnownType(typeof(ConversionType1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ConversionType1FormatChoice.Code),nameof(ConversionType1FormatChoice.Code))]
    [JsonDerivedType(typeof(ConversionType1FormatChoice.Proprietary),nameof(ConversionType1FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rl9PMNp-Ed-ak6NoX_4Aeg_-1506659145")]
    [DisplayName("Conversion Type 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConversionType1FormatChoice_
    #else
    public abstract partial class ConversionType1FormatChoice_
    #endif
    {
    }
}
