// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation response from the acquirer.
/// </summary>
[IsoId("_GB4jQTGlEeO118ZQJgaQSQ")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction24
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_GSZrgTGlEeO118ZQJgaQSQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult1 AuthorisationResult { get; init; }

    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_GSZrgzGlEeO118ZQJgaQSQ")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult2? TransactionVerificationResult { get; init; }

    /// <summary>
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_GSZrhTGlEeO118ZQJgaQSQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection41? Balance { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_GSZriTGlEeO118ZQJgaQSQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action3> Action { get; init; } = [];

    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be accepted by the cardholder.
    /// </summary>
    [IsoId("_GsBP8DGmEeO118ZQJgaQSQ")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion1? CurrencyConversion { get; init; }
}
