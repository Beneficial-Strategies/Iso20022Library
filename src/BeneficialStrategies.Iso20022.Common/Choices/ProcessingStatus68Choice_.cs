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
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus68Choice.Code))]
    [KnownType(typeof(ProcessingStatus68Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus68Choice.Code),nameof(ProcessingStatus68Choice.Code))]
    [JsonDerivedType(typeof(ProcessingStatus68Choice.Proprietary),nameof(ProcessingStatus68Choice.Proprietary))]
    #endif
    [IsoId("_TDntl-FWEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status 68 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus68Choice_
    #else
    public abstract partial class ProcessingStatus68Choice_
    #endif
    {
    }
}
