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
[IsoId("_aW1eMY0wEeW1W6lLicSC4w")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction54
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_aiAzcY0wEeW1W6lLicSC4w")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult10 AuthorisationResult { get; init; }

    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_aiAzc40wEeW1W6lLicSC4w")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Product code which are allowed by the payment card.
    /// </summary>
    [IsoId("_aiAzdY0wEeW1W6lLicSC4w")]
    [DisplayName("Allowed Product Code")]
    [IsoXmlTag("AllwdPdctCd")]
    public ValueList<Product4> AllowedProductCode { get; init; } = [];

    /// <summary>
    /// Product code not allowed by the payment card.
    /// </summary>
    [IsoId("_xftloJIPEeWww5VvitAAGw")]
    [DisplayName("Not Allowed Product Code")]
    [IsoXmlTag("NotAllwdPdctCd")]
    public ValueList<Product4> NotAllowedProductCode { get; init; } = [];

    /// <summary>
    /// Products that may be added to the purchase after the authorisation.
    /// </summary>
    [IsoId("_QqQUAJVbEeWuuIjj4l7kpg")]
    [DisplayName("Additional Available Product")]
    [IsoXmlTag("AddtlAvlblPdct")]
    public ValueList<Product5> AdditionalAvailableProduct { get; init; } = [];

    /// <summary>
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_aiAzd40wEeW1W6lLicSC4w")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection41? Balance { get; init; }

    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_aiAzeY0wEeW1W6lLicSC4w")]
    [DisplayName("Protected Balance")]
    [IsoXmlTag("PrtctdBal")]
    public ContentInformationType10? ProtectedBalance { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_aiAze40wEeW1W6lLicSC4w")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action6> Action { get; init; } = [];

    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be proposed to the cardholder.
    /// </summary>
    [IsoId("_aiAzfY0wEeW1W6lLicSC4w")]
    [DisplayName("Currency Conversion Eligibility")]
    [IsoXmlTag("CcyConvsElgblty")]
    public CurrencyConversion6? CurrencyConversionEligibility { get; init; }
}
