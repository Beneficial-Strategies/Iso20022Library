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
    [KnownType(typeof(CorporateActionEventType34Choice.Code))]
    [KnownType(typeof(CorporateActionEventType34Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType34Choice.Code),nameof(CorporateActionEventType34Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType34Choice.Proprietary),nameof(CorporateActionEventType34Choice.Proprietary))]
    #endif
    [IsoId("_iZJ_wUGKEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Event Type 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType34Choice_
    #else
    public abstract partial class CorporateActionEventType34Choice_
    #endif
    {
    }
}
