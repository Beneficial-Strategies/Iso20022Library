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
    [KnownType(typeof(CorporateActionEventProcessingType2Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventProcessingType2Choice.Code),nameof(CorporateActionEventProcessingType2Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingType2Choice.Proprietary),nameof(CorporateActionEventProcessingType2Choice.Proprietary))]
    #endif
    [IsoId("_RLnv5zndEeWLJsP1cO-amg")]
    [DisplayName("Corporate Action Event Processing Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventProcessingType2Choice_
    #else
    public abstract partial class CorporateActionEventProcessingType2Choice_
    #endif
    {
    }
}
