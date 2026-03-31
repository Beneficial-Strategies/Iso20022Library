// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the status of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(CreditorEnrolmentStatusReason2Choice.Code))]
    [KnownType(typeof(CreditorEnrolmentStatusReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CreditorEnrolmentStatusReason2Choice.Code),
        nameof(CreditorEnrolmentStatusReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CreditorEnrolmentStatusReason2Choice.Proprietary),
        nameof(CreditorEnrolmentStatusReason2Choice.Proprietary)
    )]
    [IsoId("_fW_fY-IxEeqbls7Gk4-ckA")]
    [DisplayName("Creditor Enrolment Status Reason 2 Choice")]
    public abstract record CreditorEnrolmentStatusReason2Choice_ { }
}
