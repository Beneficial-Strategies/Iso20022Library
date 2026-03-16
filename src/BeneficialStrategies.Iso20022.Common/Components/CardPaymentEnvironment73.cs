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
[IsoId("_n9i-QYX-EemxIqbaFEE8-w")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment73
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_oH7pUYX-EemxIqbaFEE8-w")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer9? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_oH7pU4X-EemxIqbaFEE8-w")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation32? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_oH7pVYX-EemxIqbaFEE8-w")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction9? POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_oH7pV4X-EemxIqbaFEE8-w")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard28? Card { get; init; }

    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_oH7pWYX-EemxIqbaFEE8-w")]
    [DisplayName("Check")]
    [IsoXmlTag("Chck")]
    public Check1? Check { get; init; }

    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    [IsoId("_oH7pW4X-EemxIqbaFEE8-w")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount1> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_oH7pXYX-EemxIqbaFEE8-w")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public ValueList<LoyaltyAccount1> LoyaltyAccount { get; init; } = [];

    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_oH7pX4X-EemxIqbaFEE8-w")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_oH7pYYX-EemxIqbaFEE8-w")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_oH7pY4X-EemxIqbaFEE8-w")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken4? PaymentToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_oH7pZYX-EemxIqbaFEE8-w")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder14? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_oH7pZ4X-EemxIqbaFEE8-w")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType17? ProtectedCardholderData { get; init; }

    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_oH7paYX-EemxIqbaFEE8-w")]
    [DisplayName("Sale Environment")]
    [IsoXmlTag("SaleEnvt")]
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; }
}
