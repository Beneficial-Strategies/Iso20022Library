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
    [KnownType(typeof(CorporateActionEventType103Choice.Code))]
    [KnownType(typeof(CorporateActionEventType103Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventType103Choice.Code),nameof(CorporateActionEventType103Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventType103Choice.Proprietary),nameof(CorporateActionEventType103Choice.Proprietary))]
    #endif
    [IsoId("_i6MUBR9PEeuFz_FaCzCLgQ")]
    [DisplayName("Corporate Action Event Type 103 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType103Choice_
    #else
    public abstract partial class CorporateActionEventType103Choice_
    #endif
    {
    }
}
