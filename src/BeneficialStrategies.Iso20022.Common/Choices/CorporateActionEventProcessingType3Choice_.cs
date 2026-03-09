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
    [KnownType(typeof(CorporateActionEventProcessingType3Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventProcessingType3Choice.Code),nameof(CorporateActionEventProcessingType3Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingType3Choice.Proprietary),nameof(CorporateActionEventProcessingType3Choice.Proprietary))]
    #endif
    [IsoId("_ctOwsZKQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Event Processing Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventProcessingType3Choice_
    #else
    public abstract partial class CorporateActionEventProcessingType3Choice_
    #endif
    {
    }
}
