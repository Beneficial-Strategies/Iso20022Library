// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creditor Enrolment Amendment6.
/// </summary>
[IsoId("_zez7VzEyEe6g-ffJsqGiSA")]
[DisplayName("Creditor Enrolment Amendment6")]
public partial record CreditorEnrolmentAmendment6
{
    #nullable enable

    /// <summary>
    /// Activation Data.
    /// </summary>
    [DisplayName("Activation Data")]
    [IsoXmlTag("ActvtnData")]
    public CreditorInvoice5? ActivationData { get; init; } 

    /// <summary>
    /// Creditor Enrolment.
    /// </summary>
    [DisplayName("Creditor Enrolment")]
    [IsoXmlTag("CdtrEnrlmnt")]
    public CreditorEnrolment6? CreditorEnrolment { get; init; } 

    
    #nullable disable
    
}
