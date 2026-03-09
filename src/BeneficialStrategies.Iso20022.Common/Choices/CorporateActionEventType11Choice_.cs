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
    [KnownType(typeof(CorporateActionEventType11Choice.Code))]
    [KnownType(typeof(CorporateActionEventType11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType11Choice.Code),nameof(CorporateActionEventType11Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType11Choice.Proprietary),nameof(CorporateActionEventType11Choice.Proprietary))]
    #endif
    [IsoId("_SdmZwQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Corporate Action Event Type 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType11Choice_
    #else
    public abstract partial class CorporateActionEventType11Choice_
    #endif
    {
    }
}
