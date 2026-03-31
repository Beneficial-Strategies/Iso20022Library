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
[IsoId("_MaApkQxtEeqdx6buGpCCQw")]
[DisplayName("Card Acquisition Response")]
public record CardAcquisitionResponse2
{
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_MkyWMQxtEeqdx6buGpCCQw")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Type of payment card.
    /// </summary>
    [IsoId("_MkyWMwxtEeqdx6buGpCCQw")]
    [DisplayName("Payment Brand")]
    [IsoXmlTag("PmtBrnd")]
    public SimpleValueList<IsoMax35Text> PaymentBrand { get; init; } = [];

    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_MkyWNQxtEeqdx6buGpCCQw")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_MkyWNwxtEeqdx6buGpCCQw")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public ValueList<LoyaltyAccount2> LoyaltyAccount { get; init; } = [];

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_MkyWOQxtEeqdx6buGpCCQw")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];
}
