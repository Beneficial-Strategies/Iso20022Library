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
[IsoId("_8ZY84U7NEeyGi9JAv6wq7Q")]
[DisplayName("Card Acquisition Response")]
public record CardAcquisitionResponse3
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_5wvcoU7uEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_8fgzAU7NEeyGi9JAv6wq7Q")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Type of payment card.
    /// </summary>
    [IsoId("_8fgzA07NEeyGi9JAv6wq7Q")]
    [DisplayName("Payment Brand")]
    [IsoXmlTag("PmtBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentBrand { get; init; }

    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_8fgzBU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_8fgzB07NEeyGi9JAv6wq7Q")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount3? LoyaltyAccount { get; init; }

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_8fgzCU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }
}
