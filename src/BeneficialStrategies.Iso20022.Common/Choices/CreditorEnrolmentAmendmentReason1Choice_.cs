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
    /// Specifies the reason for the amendment of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(CreditorEnrolmentAmendmentReason1Choice.Code))]
    [KnownType(typeof(CreditorEnrolmentAmendmentReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CreditorEnrolmentAmendmentReason1Choice.Code),nameof(CreditorEnrolmentAmendmentReason1Choice.Code))]
    [JsonDerivedType(typeof(CreditorEnrolmentAmendmentReason1Choice.Proprietary),nameof(CreditorEnrolmentAmendmentReason1Choice.Proprietary))]
    #endif
    [IsoId("_yRMkLfDBEemsS_0xy2XRug")]
    [DisplayName("Creditor Enrolment Amendment Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CreditorEnrolmentAmendmentReason1Choice_
    #else
    public abstract partial class CreditorEnrolmentAmendmentReason1Choice_
    #endif
    {
    }
}
