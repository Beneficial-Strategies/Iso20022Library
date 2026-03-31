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
[IsoId("_E5ScoXDtEe2MCaKO5AtGsA")]
[DisplayName("Acceptor Authorisation Request")]
public record AcceptorAuthorisationRequest12
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_E_z7YXDtEe2MCaKO5AtGsA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_E_z7Y3DtEe2MCaKO5AtGsA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Card payment transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_E_z7ZXDtEe2MCaKO5AtGsA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction124 Transaction { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_E_2XoXDtEe2MCaKO5AtGsA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
