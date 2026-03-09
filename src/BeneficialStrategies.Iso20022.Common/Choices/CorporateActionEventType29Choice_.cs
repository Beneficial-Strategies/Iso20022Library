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
    [KnownType(typeof(CorporateActionEventType29Choice.Code))]
    [KnownType(typeof(CorporateActionEventType29Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType29Choice.Code),nameof(CorporateActionEventType29Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType29Choice.Proprietary),nameof(CorporateActionEventType29Choice.Proprietary))]
    #endif
    [IsoId("_Jlw70Tp9EeWVrPy0StzzSg")]
    [DisplayName("Corporate Action Event Type 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType29Choice_
    #else
    public abstract partial class CorporateActionEventType29Choice_
    #endif
    {
    }
}
