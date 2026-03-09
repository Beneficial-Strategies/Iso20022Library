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
    /// Choice of format for the pending cancellation reason.
    /// </summary>
    [KnownType(typeof(PendingCancellationReasons5Choice.Code))]
    [KnownType(typeof(PendingCancellationReasons5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationReasons5Choice.Code),nameof(PendingCancellationReasons5Choice.Code))]
    [JsonDerivedType(typeof(PendingCancellationReasons5Choice.Proprietary),nameof(PendingCancellationReasons5Choice.Proprietary))]
    #endif
    [IsoId("_8Qc2K5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Cancellation Reasons 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationReasons5Choice_
    #else
    public abstract partial class PendingCancellationReasons5Choice_
    #endif
    {
    }
}
