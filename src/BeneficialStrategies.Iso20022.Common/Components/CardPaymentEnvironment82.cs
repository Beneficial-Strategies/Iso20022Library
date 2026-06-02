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
[IsoId("_DXu20bXyEfCUZfsQO4rYeA")]
[DisplayName("Card Payment Environment82")]
public record CardPaymentEnvironment82
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_DYsgJ7XyEfCUZfsQO4rYeA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer10? Acquirer { get; init; }

    /// <summary>
    /// Third party agent which provides services.
    /// </summary>
    [IsoId("_DYsgLbXyEfCUZfsQO4rYeA")]
    [DisplayName("Service Provider")]
    [IsoXmlTag("SvcPrvdr")]
    public Acquirer10? ServiceProvider { get; init; }

    /// <summary>
    /// Merchant performing the card payment transaction.
    /// </summary>
    [IsoId("_DYsgM7XyEfCUZfsQO4rYeA")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation45? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_DYsgObXyEfCUZfsQO4rYeA")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction16? POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_DYsgP7XyEfCUZfsQO4rYeA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard35? Card { get; init; }

    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_DYsgRbXyEfCUZfsQO4rYeA")]
    [DisplayName("Check")]
    [IsoXmlTag("Chck")]
    public Check1? Check { get; init; }

    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    [IsoId("_DYtuQbXyEfCUZfsQO4rYeA")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount2> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_DYtuR7XyEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public ValueList<LoyaltyAccount3> LoyaltyAccount { get; init; } = [];

    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_DYtuTbXyEfCUZfsQO4rYeA")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice3? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_DYtuU7XyEfCUZfsQO4rYeA")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice3? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_DYtuWbXyEfCUZfsQO4rYeA")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public Token1? PaymentToken { get; init; }

    /// <summary>
    /// Merchant token information.
    /// </summary>
    [IsoId("_DYtuX7XyEfCUZfsQO4rYeA")]
    [DisplayName("Merchant Token")]
    [IsoXmlTag("MrchntTkn")]
    public MerchantToken2? MerchantToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_DYtuZbXyEfCUZfsQO4rYeA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder21? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_DYtua7XyEfCUZfsQO4rYeA")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType40? ProtectedCardholderData { get; init; }

    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_DYtucbXyEfCUZfsQO4rYeA")]
    [DisplayName("Sale Environment")]
    [IsoXmlTag("SaleEnvt")]
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; }
}
