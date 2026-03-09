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
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType16Choice.Code))]
    [KnownType(typeof(CorporateActionEventType16Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType16Choice.Code),nameof(CorporateActionEventType16Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType16Choice.Proprietary),nameof(CorporateActionEventType16Choice.Proprietary))]
    #endif
    [IsoId("_EdZyISM9EeKqJ_haxcymCw")]
    [DisplayName("Corporate Action Event Type 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType16Choice_
    #else
    public abstract partial class CorporateActionEventType16Choice_
    #endif
    {
    }
}
