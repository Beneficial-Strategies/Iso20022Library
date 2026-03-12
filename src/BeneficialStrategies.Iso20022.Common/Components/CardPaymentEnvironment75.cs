// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_XX2O8QxTEeqEbo60f0v6aw")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment75
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_XjZ-sQxTEeqEbo60f0v6aw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer10? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_XjZ-swxTEeqEbo60f0v6aw")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation32? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_XjZ-tQxTEeqEbo60f0v6aw")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction10? POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_XjZ-twxTEeqEbo60f0v6aw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard30? Card { get; init; } 
    
    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_XjZ-uQxTEeqEbo60f0v6aw")]
    [DisplayName("Check")]
    [IsoXmlTag("Chck")]
    public Check1? Check { get; init; } 
    
    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    [IsoId("_XjZ-uwxTEeqEbo60f0v6aw")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    
    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_XjZ-vQxTEeqEbo60f0v6aw")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount2? LoyaltyAccount { get; init; } 
    
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_XjZ-vwxTEeqEbo60f0v6aw")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_XjZ-wQxTEeqEbo60f0v6aw")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; } 
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_XjZ-wwxTEeqEbo60f0v6aw")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken5? PaymentToken { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_XjZ-xQxTEeqEbo60f0v6aw")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder16? Cardholder { get; init; } 
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_XjZ-xwxTEeqEbo60f0v6aw")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType22? ProtectedCardholderData { get; init; } 
    
    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_XjZ-yQxTEeqEbo60f0v6aw")]
    [DisplayName("Sale Environment")]
    [IsoXmlTag("SaleEnvt")]
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; } 
    
    
    #nullable disable
    
}
