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
    [KnownType(typeof(CancellationProcessingStatus9Choice.Code))]
    [KnownType(typeof(CancellationProcessingStatus9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationProcessingStatus9Choice.Code),nameof(CancellationProcessingStatus9Choice.Code))]
    [JsonDerivedType(typeof(CancellationProcessingStatus9Choice.Proprietary),nameof(CancellationProcessingStatus9Choice.Proprietary))]
    #endif
    [IsoId("_BlUUkeFfEeWIA4E9cYSxxQ")]
    [DisplayName("Cancellation Processing Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationProcessingStatus9Choice_
    #else
    public abstract partial class CancellationProcessingStatus9Choice_
    #endif
    {
    }
}
