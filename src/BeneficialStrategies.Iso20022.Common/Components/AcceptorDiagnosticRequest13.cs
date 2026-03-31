// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Diagnostic Request13.
/// </summary>
[IsoId("_-3eBcaEwEe-MRKYsaX6JDg")]
[DisplayName("Acceptor Diagnostic Request13")]
public record AcceptorDiagnosticRequest13
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
    public required CardPaymentEnvironment81 Environment { get; init; }
}
