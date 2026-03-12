// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the amendment of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(CreditorEnrolmentAmendmentReason1Choice.Code))]
    [KnownType(typeof(CreditorEnrolmentAmendmentReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(CreditorEnrolmentAmendmentReason1Choice.Code),nameof(CreditorEnrolmentAmendmentReason1Choice.Code))]
    [JsonDerivedType(typeof(CreditorEnrolmentAmendmentReason1Choice.Proprietary),nameof(CreditorEnrolmentAmendmentReason1Choice.Proprietary))]
    [IsoId("_yRMkLfDBEemsS_0xy2XRug")]
    [DisplayName("Creditor Enrolment Amendment Reason 1 Choice")]
    public abstract partial record CreditorEnrolmentAmendmentReason1Choice_
    {
    }
}
