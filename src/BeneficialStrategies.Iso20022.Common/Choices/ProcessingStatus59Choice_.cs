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
    /// Provides the status of a transaction.
    /// </summary>
    [KnownType(typeof(ProcessingStatus59Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus59Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus59Choice.Accepted))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus59Choice.Rejected),nameof(ProcessingStatus59Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus59Choice.Cancelled),nameof(ProcessingStatus59Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus59Choice.Accepted),nameof(ProcessingStatus59Choice.Accepted))]
    #endif
    [IsoId("_6HV0_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 59 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus59Choice_
    #else
    public abstract partial class ProcessingStatus59Choice_
    #endif
    {
    }
}
