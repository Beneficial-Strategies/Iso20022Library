// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic request from an acceptor.
/// </summary>
[IsoId("_ECrlYbX_EfCUZfsQO4rYeA")]
[DisplayName("Acceptor Diagnostic Request14")]
public record AcceptorDiagnosticRequest14
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_EDlkVbX_EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Indicates if the availability of the acquirer must be tested.
    /// </summary>
    [IsoId("_EDlkW7X_EfCUZfsQO4rYeA")]
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }
}
