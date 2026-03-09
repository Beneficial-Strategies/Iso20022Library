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
    /// Instruction has been rejected for further processing.
    /// </summary>
    [KnownType(typeof(RejectionStatus33Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus33Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus33Choice.NoSpecifiedReason),nameof(RejectionStatus33Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus33Choice.Reason),nameof(RejectionStatus33Choice.Reason))]
    #endif
    [IsoId("_FjyNTxIwEeydmIVkS03esw")]
    [DisplayName("Rejection Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus33Choice_
    #else
    public abstract partial class RejectionStatus33Choice_
    #endif
    {
    }
}
