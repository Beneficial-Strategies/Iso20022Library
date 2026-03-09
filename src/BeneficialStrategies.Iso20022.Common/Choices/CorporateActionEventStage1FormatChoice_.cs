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
    /// Choice of formats to express the stage of the CA event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStage1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionEventStage1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventStage1FormatChoice.Code),nameof(CorporateActionEventStage1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventStage1FormatChoice.Proprietary),nameof(CorporateActionEventStage1FormatChoice.Proprietary))]
    #endif
    [IsoId("_RmHANNp-Ed-ak6NoX_4Aeg_-299884544")]
    [DisplayName("Corporate Action Event Stage 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventStage1FormatChoice_
    #else
    public abstract partial class CorporateActionEventStage1FormatChoice_
    #endif
    {
    }
}
