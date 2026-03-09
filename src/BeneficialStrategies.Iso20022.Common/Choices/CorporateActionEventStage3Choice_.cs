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
    [KnownType(typeof(CorporateActionEventStage3Choice.Code))]
    [KnownType(typeof(CorporateActionEventStage3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventStage3Choice.Code),nameof(CorporateActionEventStage3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStage3Choice.Proprietary),nameof(CorporateActionEventStage3Choice.Proprietary))]
    #endif
    [IsoId("_RCKigTqqEeWyoP0PbocV1Q")]
    [DisplayName("Corporate Action Event Stage 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventStage3Choice_
    #else
    public abstract partial class CorporateActionEventStage3Choice_
    #endif
    {
    }
}
