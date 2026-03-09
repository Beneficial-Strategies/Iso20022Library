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
    [KnownType(typeof(CorporateActionProcessingStatus6Choice.Code))]
    [KnownType(typeof(CorporateActionProcessingStatus6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionProcessingStatus6Choice.Code),nameof(CorporateActionProcessingStatus6Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionProcessingStatus6Choice.Proprietary),nameof(CorporateActionProcessingStatus6Choice.Proprietary))]
    #endif
    [IsoId("_W9mj5ZmtEeWLs7cvLxlyAg")]
    [DisplayName("Corporate Action Processing Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionProcessingStatus6Choice_
    #else
    public abstract partial class CorporateActionProcessingStatus6Choice_
    #endif
    {
    }
}
