// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_ZpEjIU7OEeyGi9JAv6wq7Q")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment78
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_ZvLyMU7OEeyGi9JAv6wq7Q")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer10? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_ZvLyM07OEeyGi9JAv6wq7Q")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation41? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_ZvLyNU7OEeyGi9JAv6wq7Q")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction12? POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_ZvMZQU7OEeyGi9JAv6wq7Q")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard32? Card { get; init; }

    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_ZvMZQ07OEeyGi9JAv6wq7Q")]
    [DisplayName("Check")]
    [IsoXmlTag("Chck")]
    public Check1? Check { get; init; }

    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    [IsoId("_ZvMZRU7OEeyGi9JAv6wq7Q")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount2> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_ZvMZR07OEeyGi9JAv6wq7Q")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public ValueList<LoyaltyAccount3> LoyaltyAccount { get; init; } = [];

    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_ZvMZSU7OEeyGi9JAv6wq7Q")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice3? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_ZvMZS07OEeyGi9JAv6wq7Q")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice3? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_ZvMZTU7OEeyGi9JAv6wq7Q")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public Token1? PaymentToken { get; init; }

    /// <summary>
    /// Merchant token information.
    /// </summary>
    [IsoId("_ZvMZT07OEeyGi9JAv6wq7Q")]
    [DisplayName("Merchant Token")]
    [IsoXmlTag("MrchntTkn")]
    public MerchantToken2? MerchantToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_ZvMZUU7OEeyGi9JAv6wq7Q")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder18? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_ZvMZU07OEeyGi9JAv6wq7Q")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType32? ProtectedCardholderData { get; init; }

    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_ZvMZVU7OEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Environment")]
    [IsoXmlTag("SaleEnvt")]
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; }
}
