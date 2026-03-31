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
[IsoId("_kRo00QujEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Diagnostic Request")]
public record AcceptorDiagnosticRequest8
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_kceL0QujEeqw5uEXxQ9H4g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Indicates if the availability of the acquirer must be tested.
    /// </summary>
    [IsoId("_yq_gAQujEeqw5uEXxQ9H4g")]
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }
}
