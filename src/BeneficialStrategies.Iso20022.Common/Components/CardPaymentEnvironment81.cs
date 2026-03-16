// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Environment81.
/// </summary>
[IsoId("_UbcCkaEYEe-MRKYsaX6JDg")]
[DisplayName("Card Payment Environment81")]
public partial record CardPaymentEnvironment81
{
    #nullable enable

    /// <summary>
    /// Acquirer.
    /// </summary>
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer10? Acquirer { get; init; } 

    /// <summary>
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard35? Card { get; init; } 

    /// <summary>
    /// Cardholder.
    /// </summary>
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder21? Cardholder { get; init; } 

    /// <summary>
    /// Check.
    /// </summary>
    [DisplayName("Check")]
    [IsoXmlTag("Chck")]
    public Check1? Check { get; init; } 

    /// <summary>
    /// Customer Device.
    /// </summary>
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice3? CustomerDevice { get; init; } 

    /// <summary>
    /// Loyalty Account.
    /// </summary>
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public ValueList<LoyaltyAccount3> LoyaltyAccount { get; init; } = [];

    /// <summary>
    /// Merchant.
    /// </summary>
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation41? Merchant { get; init; } 

    /// <summary>
    /// Merchant Token.
    /// </summary>
    [DisplayName("Merchant Token")]
    [IsoXmlTag("MrchntTkn")]
    public MerchantToken2? MerchantToken { get; init; } 

    /// <summary>
    /// Payment Token.
    /// </summary>
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public Token1? PaymentToken { get; init; } 

    /// <summary>
    /// POI.
    /// </summary>
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction15? POI { get; init; } 

    /// <summary>
    /// Protected Cardholder Data.
    /// </summary>
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType40? ProtectedCardholderData { get; init; } 

    /// <summary>
    /// Sale Environment.
    /// </summary>
    [DisplayName("Sale Environment")]
    [IsoXmlTag("SaleEnvt")]
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; } 

    /// <summary>
    /// Service Provider.
    /// </summary>
    [DisplayName("Service Provider")]
    [IsoXmlTag("SvcPrvdr")]
    public Acquirer10? ServiceProvider { get; init; } 

    /// <summary>
    /// Stored Value Account.
    /// </summary>
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount2> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Wallet.
    /// </summary>
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice3? Wallet { get; init; } 

    
    #nullable disable
    
}
