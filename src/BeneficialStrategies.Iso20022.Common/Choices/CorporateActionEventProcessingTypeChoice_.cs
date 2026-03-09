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
    /// Choice between a standard code or a proprietary code for specifying the processing type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingTypeChoice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingTypeChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventProcessingTypeChoice.Code),nameof(CorporateActionEventProcessingTypeChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingTypeChoice.Proprietary),nameof(CorporateActionEventProcessingTypeChoice.Proprietary))]
    #endif
    [IsoId("_Q4g6aNp-Ed-ak6NoX_4Aeg_944669894")]
    [DisplayName("Corporate Action Event Processing Type Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventProcessingTypeChoice_
    #else
    public abstract partial class CorporateActionEventProcessingTypeChoice_
    #endif
    {
    }
}
