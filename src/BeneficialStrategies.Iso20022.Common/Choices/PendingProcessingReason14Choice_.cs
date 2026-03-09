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
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason14Choice.Code))]
    [KnownType(typeof(PendingProcessingReason14Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingProcessingReason14Choice.Code),nameof(PendingProcessingReason14Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason14Choice.Proprietary),nameof(PendingProcessingReason14Choice.Proprietary))]
    #endif
    [IsoId("_6P-zN5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Reason 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessingReason14Choice_
    #else
    public abstract partial class PendingProcessingReason14Choice_
    #endif
    {
    }
}
