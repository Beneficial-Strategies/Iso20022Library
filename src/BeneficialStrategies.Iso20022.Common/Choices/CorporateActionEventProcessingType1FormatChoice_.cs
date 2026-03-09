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
    /// Choice of formats to express the type of event processing.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingType1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingType1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventProcessingType1FormatChoice.Code),nameof(CorporateActionEventProcessingType1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingType1FormatChoice.Proprietary),nameof(CorporateActionEventProcessingType1FormatChoice.Proprietary))]
    #endif
    [IsoId("_RmHAMdp-Ed-ak6NoX_4Aeg_699190436")]
    [DisplayName("Corporate Action Event Processing Type 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventProcessingType1FormatChoice_
    #else
    public abstract partial class CorporateActionEventProcessingType1FormatChoice_
    #endif
    {
    }
}
