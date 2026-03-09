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
    /// Choice of cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus8Choice.Code))]
    [KnownType(typeof(CancellationProcessingStatus8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationProcessingStatus8Choice.Code),nameof(CancellationProcessingStatus8Choice.Code))]
    [JsonDerivedType(typeof(CancellationProcessingStatus8Choice.Proprietary),nameof(CancellationProcessingStatus8Choice.Proprietary))]
    #endif
    [IsoId("_8QcPjZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Processing Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationProcessingStatus8Choice_
    #else
    public abstract partial class CancellationProcessingStatus8Choice_
    #endif
    {
    }
}
