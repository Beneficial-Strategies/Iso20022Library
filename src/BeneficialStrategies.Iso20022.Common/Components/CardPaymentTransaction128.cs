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
[IsoId("_LTvzAXG7Ee2TbaNWBpRZpQ")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction128
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_LaAMAXG7Ee2TbaNWBpRZpQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult17 AuthorisationResult { get; init; }

    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_LaAzEXG7Ee2TbaNWBpRZpQ")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Product code which are allowed by the payment card.
    /// </summary>
    [IsoId("_LaAzE3G7Ee2TbaNWBpRZpQ")]
    [DisplayName("Allowed Product Code")]
    [IsoXmlTag("AllwdPdctCd")]
    public ValueList<Product4> AllowedProductCode { get; init; } = [];

    /// <summary>
    /// Product code not allowed by the payment card.
    /// </summary>
    [IsoId("_LaCoQXG7Ee2TbaNWBpRZpQ")]
    [DisplayName("Not Allowed Product Code")]
    [IsoXmlTag("NotAllwdPdctCd")]
    public ValueList<Product4> NotAllowedProductCode { get; init; } = [];

    /// <summary>
    /// Products that may be added to the purchase after the authorisation.
    /// </summary>
    [IsoId("_LaDPUXG7Ee2TbaNWBpRZpQ")]
    [DisplayName("Additional Available Product")]
    [IsoXmlTag("AddtlAvlblPdct")]
    public ValueList<Product5> AdditionalAvailableProduct { get; init; } = [];

    /// <summary>
    /// Balance and currency code of the account, related to the payment.
    /// </summary>
    [IsoId("_LaDPU3G7Ee2TbaNWBpRZpQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection93? Balance { get; init; }

    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_LaDPVXG7Ee2TbaNWBpRZpQ")]
    [DisplayName("Protected Balance")]
    [IsoXmlTag("PrtctdBal")]
    public ContentInformationType35? ProtectedBalance { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_LaDPV3G7Ee2TbaNWBpRZpQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action14> Action { get; init; } = [];

    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be proposed to the cardholder.
    /// </summary>
    [IsoId("_LaDPWXG7Ee2TbaNWBpRZpQ")]
    [DisplayName("Currency Conversion Eligibility")]
    [IsoXmlTag("CcyConvsElgblty")]
    public CurrencyConversion26? CurrencyConversionEligibility { get; init; }
}
