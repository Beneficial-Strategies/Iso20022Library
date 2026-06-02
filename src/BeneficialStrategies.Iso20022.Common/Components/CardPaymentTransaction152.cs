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
[IsoId("_UsXI4bYJEfCUZfsQO4rYeA")]
[DisplayName("Card Payment Transaction152")]
public record CardPaymentTransaction152
{
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_UtYclbYJEfCUZfsQO4rYeA")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult17 AuthorisationResult { get; init; }

    /// <summary>
    /// Product code which are allowed by the payment card.
    /// </summary>
    [IsoId("_UtYcm7YJEfCUZfsQO4rYeA")]
    [DisplayName("Allowed Product Code")]
    [IsoXmlTag("AllwdPdctCd")]
    public ValueList<Product4> AllowedProductCode { get; init; } = [];

    /// <summary>
    /// Product code not allowed by the payment card.
    /// </summary>
    [IsoId("_UtYcobYJEfCUZfsQO4rYeA")]
    [DisplayName("Not Allowed Product Code")]
    [IsoXmlTag("NotAllwdPdctCd")]
    public ValueList<Product4> NotAllowedProductCode { get; init; } = [];

    /// <summary>
    /// Products that may be added to the purchase after the authorisation.
    /// </summary>
    [IsoId("_UtYcp7YJEfCUZfsQO4rYeA")]
    [DisplayName("Additional Available Product")]
    [IsoXmlTag("AddtlAvlblPdct")]
    public ValueList<Product5> AdditionalAvailableProduct { get; init; } = [];

    /// <summary>
    /// Balance and currency code of the account, related to the payment.
    /// </summary>
    [IsoId("_UtYcrbYJEfCUZfsQO4rYeA")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection93? Balance { get; init; }

    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_UtYcs7YJEfCUZfsQO4rYeA")]
    [DisplayName("Protected Balance")]
    [IsoXmlTag("PrtctdBal")]
    public ContentInformationType40? ProtectedBalance { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_UtYcubYJEfCUZfsQO4rYeA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action18> Action { get; init; } = [];

    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider.
    /// </summary>
    [IsoId("_UtYcv7YJEfCUZfsQO4rYeA")]
    [DisplayName("Currency Conversion Eligibility")]
    [IsoXmlTag("CcyConvsElgblty")]
    public CurrencyConversion34? CurrencyConversionEligibility { get; init; }
}
