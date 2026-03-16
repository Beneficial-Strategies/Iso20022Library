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
[IsoId("_59UioSpPEeuUucRY0yCMTA")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment77
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_6KyW4SpPEeuUucRY0yCMTA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer10? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_6KyW4ypPEeuUucRY0yCMTA")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation41? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_6KyW5SpPEeuUucRY0yCMTA")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction11? POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_6KyW5ypPEeuUucRY0yCMTA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard31? Card { get; init; }

    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_6KyW6SpPEeuUucRY0yCMTA")]
    [DisplayName("Check")]
    [IsoXmlTag("Chck")]
    public Check1? Check { get; init; }

    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    [IsoId("_6KyW6ypPEeuUucRY0yCMTA")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount2> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_6KyW7SpPEeuUucRY0yCMTA")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public ValueList<LoyaltyAccount2> LoyaltyAccount { get; init; } = [];

    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_6KyW7ypPEeuUucRY0yCMTA")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice3? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_6KyW8SpPEeuUucRY0yCMTA")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice3? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_6KyW8ypPEeuUucRY0yCMTA")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public Token1? PaymentToken { get; init; }

    /// <summary>
    /// Merchant token information.
    /// </summary>
    [IsoId("_gUmRUC5HEeunNvJlR_vCbg")]
    [DisplayName("Merchant Token")]
    [IsoXmlTag("MrchntTkn")]
    public MerchantToken1? MerchantToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_6KyW9SpPEeuUucRY0yCMTA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder17? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_6KyW9ypPEeuUucRY0yCMTA")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType28? ProtectedCardholderData { get; init; }

    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_6KyW-SpPEeuUucRY0yCMTA")]
    [DisplayName("Sale Environment")]
    [IsoXmlTag("SaleEnvt")]
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; }
}
