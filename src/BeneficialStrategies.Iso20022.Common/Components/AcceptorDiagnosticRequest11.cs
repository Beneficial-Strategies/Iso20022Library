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
[IsoId("_Jf9WkXJ-Ee299ZbWCkdR_w")]
[DisplayName("Acceptor Diagnostic Request")]
public record AcceptorDiagnosticRequest11
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_JmYusXJ-Ee299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Indicates if the availability of the acquirer must be tested.
    /// </summary>
    [IsoId("_JmYus3J-Ee299ZbWCkdR_w")]
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }
}
