// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status reason of the creditor enrolment request.
/// </summary>
[IsoId("_Ub7vn-H7Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Status Reason")]
public record CreditorEnrolmentStatusReason2
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_UdRMUeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public RTPPartyIdentification1? Originator { get; init; }

    /// <summary>
    /// Specifies the status reason for the debtor activation request.
    /// </summary>
    [IsoId("_UdRMU-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CreditorEnrolmentStatusReason2Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_UdRMVeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
