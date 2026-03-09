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
    /// Choice of corporate action stage.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStage4Choice.Code))]
    [KnownType(typeof(CorporateActionEventStage4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventStage4Choice.Code),nameof(CorporateActionEventStage4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStage4Choice.Proprietary),nameof(CorporateActionEventStage4Choice.Proprietary))]
    #endif
    [IsoId("_8Qbo0ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Stage 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventStage4Choice_
    #else
    public abstract partial class CorporateActionEventStage4Choice_
    #endif
    {
    }
}
