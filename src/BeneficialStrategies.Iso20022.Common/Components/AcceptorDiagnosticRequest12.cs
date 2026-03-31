// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Diagnostic Request12.
/// </summary>
[IsoId("_vg8CMZN3Ee6im_tx3Nh8SA")]
[DisplayName("Acceptor Diagnostic Request12")]
public record AcceptorDiagnosticRequest12
{
    /// <summary>
    /// Acquirer Availability Requested.
    /// </summary>
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment80 Environment { get; init; }
}
