// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer involved in a withdrawal transaction.
/// </summary>
[IsoId("_I2rJ8a14EeWMg5rOByfExw")]
[DisplayName("ATM Customer")]
public record ATMCustomer4
{
    /// <summary>
    /// Profile of the customer selected to perform the transaction.
    /// </summary>
    [IsoId("_JDfd8a14EeWMg5rOByfExw")]
    [DisplayName("Profile")]
    [IsoXmlTag("Prfl")]
    public ATMCustomerProfile4? Profile { get; init; }

    /// <summary>
    /// Language selected by the customer at the ATM for the customer session. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_JDfd8614EeWMg5rOByfExw")]
    [DisplayName("Selected Language")]
    [IsoXmlTag("SelctdLang")]
    public LanguageCode? SelectedLanguage { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the customer and its card.
    /// </summary>
    [IsoId("_JDfd9a14EeWMg5rOByfExw")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication8> Authentication { get; init; } = [];

    // ID for the above is _JDfd9a14EeWMg5rOByfExw

    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_JDfd9614EeWMg5rOByfExw")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public TransactionVerificationResult5? AuthenticationResult { get; init; }
}
