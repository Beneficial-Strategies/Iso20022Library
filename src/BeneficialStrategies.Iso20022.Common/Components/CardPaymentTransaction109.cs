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
[IsoId("_xBbp4S8qEeu125Ip9zFcsQ")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction109
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_xNcsoS8qEeu125Ip9zFcsQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult14 AuthorisationResult { get; init; }

    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_xNcsoy8qEeu125Ip9zFcsQ")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; }

    /// <summary>
    /// Product code which are allowed by the payment card.
    /// </summary>
    [IsoId("_xNcspS8qEeu125Ip9zFcsQ")]
    [DisplayName("Allowed Product Code")]
    [IsoXmlTag("AllwdPdctCd")]
    public Product4? AllowedProductCode { get; init; }

    /// <summary>
    /// Product code not allowed by the payment card.
    /// </summary>
    [IsoId("_xNcspy8qEeu125Ip9zFcsQ")]
    [DisplayName("Not Allowed Product Code")]
    [IsoXmlTag("NotAllwdPdctCd")]
    public Product4? NotAllowedProductCode { get; init; }

    /// <summary>
    /// Products that may be added to the purchase after the authorisation.
    /// </summary>
    [IsoId("_xNcsqS8qEeu125Ip9zFcsQ")]
    [DisplayName("Additional Available Product")]
    [IsoXmlTag("AddtlAvlblPdct")]
    public Product5? AdditionalAvailableProduct { get; init; }

    /// <summary>
    /// Balance and currency code of the account, related to the payment.
    /// </summary>
    [IsoId("_xNcsqy8qEeu125Ip9zFcsQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection93? Balance { get; init; }

    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_xNcsrS8qEeu125Ip9zFcsQ")]
    [DisplayName("Protected Balance")]
    [IsoXmlTag("PrtctdBal")]
    public ContentInformationType28? ProtectedBalance { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_xNcsry8qEeu125Ip9zFcsQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action11? Action { get; init; }

    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be proposed to the cardholder.
    /// </summary>
    [IsoId("_xNcssS8qEeu125Ip9zFcsQ")]
    [DisplayName("Currency Conversion Eligibility")]
    [IsoXmlTag("CcyConvsElgblty")]
    public CurrencyConversion20? CurrencyConversionEligibility { get; init; }
}
