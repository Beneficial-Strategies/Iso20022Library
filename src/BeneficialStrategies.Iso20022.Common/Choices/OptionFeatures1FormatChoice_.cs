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
    /// Choice of formats to express the feature of an option.
    /// </summary>
    [KnownType(typeof(OptionFeatures1FormatChoice.Code))]
    [KnownType(typeof(OptionFeatures1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionFeatures1FormatChoice.Code),nameof(OptionFeatures1FormatChoice.Code))]
    [JsonDerivedType(typeof(OptionFeatures1FormatChoice.Proprietary),nameof(OptionFeatures1FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rm2nFdp-Ed-ak6NoX_4Aeg_741252058")]
    [DisplayName("Option Features 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionFeatures1FormatChoice_
    #else
    public abstract partial class OptionFeatures1FormatChoice_
    #endif
    {
    }
}
