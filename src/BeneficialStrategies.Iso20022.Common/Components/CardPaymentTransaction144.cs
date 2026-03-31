// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Transaction144.
/// </summary>
[IsoId("_z8qxoZ-MEe-nbM0aSPcoiQ")]
[DisplayName("Card Payment Transaction144")]
public record CardPaymentTransaction144
{
    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action17> Action { get; init; } = [];

    /// <summary>
    /// Additional Available Product.
    /// </summary>
    [DisplayName("Additional Available Product")]
    [IsoXmlTag("AddtlAvlblPdct")]
    public ValueList<Product5> AdditionalAvailableProduct { get; init; } = [];

    /// <summary>
    /// Allowed Product Code.
    /// </summary>
    [DisplayName("Allowed Product Code")]
    [IsoXmlTag("AllwdPdctCd")]
    public ValueList<Product4> AllowedProductCode { get; init; } = [];

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult17 AuthorisationResult { get; init; }

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection93? Balance { get; init; }

    /// <summary>
    /// Currency Conversion Eligibility.
    /// </summary>
    [DisplayName("Currency Conversion Eligibility")]
    [IsoXmlTag("CcyConvsElgblty")]
    public CurrencyConversion29? CurrencyConversionEligibility { get; init; }

    /// <summary>
    /// Not Allowed Product Code.
    /// </summary>
    [DisplayName("Not Allowed Product Code")]
    [IsoXmlTag("NotAllwdPdctCd")]
    public ValueList<Product4> NotAllowedProductCode { get; init; } = [];

    /// <summary>
    /// Protected Balance.
    /// </summary>
    [DisplayName("Protected Balance")]
    [IsoXmlTag("PrtctdBal")]
    public ContentInformationType40? ProtectedBalance { get; init; }
}
