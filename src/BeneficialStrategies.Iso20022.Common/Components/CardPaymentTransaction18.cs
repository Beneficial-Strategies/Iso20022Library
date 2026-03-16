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
[IsoId("_oVu5IR0jEeK5OKMB21JFBg")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction18
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_ohyYIR0jEeK5OKMB21JFBg")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult1 AuthorisationResult { get; init; }

    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_ohyYJR0jEeK5OKMB21JFBg")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult2? TransactionVerificationResult { get; init; }

    /// <summary>
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_ohyYKR0jEeK5OKMB21JFBg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ImpliedCurrencyAndAmount? Balance { get; init; }

    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_ohyYLR0jEeK5OKMB21JFBg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_ohyYMR0jEeK5OKMB21JFBg")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action2? Action { get; init; }
}
