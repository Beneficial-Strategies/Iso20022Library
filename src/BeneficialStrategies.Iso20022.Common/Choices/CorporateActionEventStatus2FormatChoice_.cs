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
    /// Choice of formats to express the status of the CA option.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStatus2FormatChoice.Code))]
    [KnownType(typeof(CorporateActionEventStatus2FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventStatus2FormatChoice.Code),nameof(CorporateActionEventStatus2FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStatus2FormatChoice.Proprietary),nameof(CorporateActionEventStatus2FormatChoice.Proprietary))]
    #endif
    [IsoId("_RmQKIdp-Ed-ak6NoX_4Aeg_-108007853")]
    [DisplayName("Corporate Action Event Status 2 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventStatus2FormatChoice_
    #else
    public abstract partial class CorporateActionEventStatus2FormatChoice_
    #endif
    {
    }
}
