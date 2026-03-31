// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation request from an acceptor.
/// </summary>
[IsoId("_R-Cb4U3jEey_VecAUE-C9Q")]
[DisplayName("Acceptor Authorisation Request")]
public record AcceptorAuthorisationRequest11
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_SFZoIU3jEey_VecAUE-C9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_SFZoI03jEey_VecAUE-C9Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Card payment transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_SFZoJU3jEey_VecAUE-C9Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction119 Transaction { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_SFZoJ03jEey_VecAUE-C9Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
