// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_zxUwC-H5Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Amendment")]
public record CreditorEnrolmentAmendment4
{
    /// <summary>
    /// Specific attributes of the creditor and service enrolment provided by the creditor for its enrolment.
    /// </summary>
    [IsoId("_zyspAeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Enrolment")]
    [IsoXmlTag("CdtrEnrlmnt")]
    public CreditorEnrolment4? CreditorEnrolment { get; init; }

    /// <summary>
    /// Specific attributes requested from the debtor for its activation as specified by the creditor in the creditor enrolment request.
    /// </summary>
    [IsoId("_zyspA-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Activation Data")]
    [IsoXmlTag("ActvtnData")]
    public CreditorInvoice4? ActivationData { get; init; }
}
