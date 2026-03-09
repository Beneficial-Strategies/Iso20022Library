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
    /// Choice of corporate action processing status.
    /// </summary>
    [KnownType(typeof(CorporateActionEventProcessingStatus4Choice.Code))]
    [KnownType(typeof(CorporateActionEventProcessingStatus4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionEventProcessingStatus4Choice.Code),nameof(CorporateActionEventProcessingStatus4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionEventProcessingStatus4Choice.Proprietary),nameof(CorporateActionEventProcessingStatus4Choice.Proprietary))]
    #endif
    [IsoId("_8QborZNLEeWGlc8L7oPDIg")]
    [DisplayName("Corporate Action Event Processing Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventProcessingStatus4Choice_
    #else
    public abstract partial class CorporateActionEventProcessingStatus4Choice_
    #endif
    {
    }
}
