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
    /// Specifies the reason for the cancellation request of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(CreditorEnrolmentCancellationReason1Choice.Code))]
    [KnownType(typeof(CreditorEnrolmentCancellationReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CreditorEnrolmentCancellationReason1Choice.Code),nameof(CreditorEnrolmentCancellationReason1Choice.Code))]
    [JsonDerivedType(typeof(CreditorEnrolmentCancellationReason1Choice.Proprietary),nameof(CreditorEnrolmentCancellationReason1Choice.Proprietary))]
    #endif
    [IsoId("_pQ9SyfDBEemsS_0xy2XRug")]
    [DisplayName("Creditor Enrolment Cancellation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditorEnrolmentCancellationReason1Choice_
    #else
    public abstract partial class CreditorEnrolmentCancellationReason1Choice_
    #endif
    {
    }
}
