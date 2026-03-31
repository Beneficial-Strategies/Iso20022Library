// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Card Acquisition Response message.
/// </summary>
[IsoId("_eq2jANxZEeioifFt1dhnJA")]
[DisplayName("Card Acquisition Response")]
public record CardAcquisitionResponse1
{
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_faoksNxaEeioifFt1dhnJA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Type of payment card.
    /// </summary>
    [IsoId("_ifQzUNxaEeioifFt1dhnJA")]
    [DisplayName("Payment Brand")]
    [IsoXmlTag("PmtBrnd")]
    public SimpleValueList<IsoMax35Text> PaymentBrand { get; init; } = [];

    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_lnOCwNxaEeioifFt1dhnJA")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_YVTEQNxbEeioifFt1dhnJA")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public ValueList<LoyaltyAccount1> LoyaltyAccount { get; init; } = [];

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_clbcsNxbEeioifFt1dhnJA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];
}
