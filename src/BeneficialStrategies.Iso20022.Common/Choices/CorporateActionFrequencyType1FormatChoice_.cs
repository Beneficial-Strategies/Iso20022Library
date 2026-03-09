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
    /// Choice of formats to express the frequency of a CA event.
    /// </summary>
    [KnownType(typeof(CorporateActionFrequencyType1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionFrequencyType1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionFrequencyType1FormatChoice.Code),nameof(CorporateActionFrequencyType1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionFrequencyType1FormatChoice.Proprietary),nameof(CorporateActionFrequencyType1FormatChoice.Proprietary))]
    #endif
    [IsoId("_RmQKJ9p-Ed-ak6NoX_4Aeg_-1912631141")]
    [DisplayName("Corporate Action Frequency Type 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionFrequencyType1FormatChoice_
    #else
    public abstract partial class CorporateActionFrequencyType1FormatChoice_
    #endif
    {
    }
}
