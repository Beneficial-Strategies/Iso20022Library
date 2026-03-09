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
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus4Choice.Code))]
    [KnownType(typeof(CorporateActionProcessingStatus4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionProcessingStatus4Choice.Code),nameof(CorporateActionProcessingStatus4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionProcessingStatus4Choice.Proprietary),nameof(CorporateActionProcessingStatus4Choice.Proprietary))]
    #endif
    [IsoId("_s2r48SXZEeOFIcNWlDEvdQ")]
    [DisplayName("Corporate Action Processing Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionProcessingStatus4Choice_
    #else
    public abstract partial class CorporateActionProcessingStatus4Choice_
    #endif
    {
    }
}
