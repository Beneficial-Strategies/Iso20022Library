// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the sale involved in a card transaction.
/// </summary>
[IsoId("_OQG4kf5rEeiLerArw36g0w")]
[DisplayName("Sale Context")]
public partial record SaleContext7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_OZUe8f5rEeiLerArw36g0w")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; } 
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_OZUe8_5rEeiLerArw36g0w")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    
    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_OZUe9f5rEeiLerArw36g0w")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceNumber { get; init; } 
    
    /// <summary>
    /// Type of goods and/or services.
    /// </summary>
    [IsoId("_OZUe_f5rEeiLerArw36g0w")]
    [DisplayName("Goods And Services Type")]
    [IsoXmlTag("GoodsAndSvcsTp")]
    public GoodsAndServices1Code? GoodsAndServicesType { get; init; } 
    
    /// <summary>
    /// Sub type of goods and/or services.
    /// </summary>
    [IsoId("_seyYsOkCEemeDPHh-U9b6w")]
    [DisplayName("Good And Services Sub Type")]
    [IsoXmlTag("GoodAndSvcsSubTp")]
    public GoodsAndServicesSubType1Code? GoodAndServicesSubType { get; init; } 
    
    /// <summary>
    /// Other goods and services sub type applied to the transaction.
    /// </summary>
    [IsoId("_8NcYAekEEemeDPHh-U9b6w")]
    [DisplayName("Good And Services Other Sub Type")]
    [IsoXmlTag("GoodAndSvcsOthrSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? GoodAndServicesOtherSubType { get; init; } 
    
    /// <summary>
    /// Also referred to as split tender. Indicates whether the payment transaction is a partial payment of the sale transaction.
    /// True: Partial payment of a sale transaction
    /// False: Not a partial payment of a sale transaction.
    /// </summary>
    [IsoId("_OZUfA_5rEeiLerArw36g0w")]
    [DisplayName("Split Payment Indicator")]
    [IsoXmlTag("SpltPmtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitPaymentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether a receipt from the goods or services provider was requested.
    /// True: Receipt requested
    /// False: Receipt not requested.
    /// </summary>
    [IsoId("_OZUfBf5rEeiLerArw36g0w")]
    [DisplayName("Receipt Request Indicator")]
    [IsoXmlTag("RctReqInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptRequestIndicator { get; init; } 
    
    /// <summary>
    /// Type of receipt requested or communication channel used.
    /// </summary>
    [IsoId("_OZUfB_5rEeiLerArw36g0w")]
    [DisplayName("Receipt Type")]
    [IsoXmlTag("RctTp")]
    public ReceiptType1Code? ReceiptType { get; init; } 
    
    /// <summary>
    /// Destination of the receipt (for example, e-mail address, SMS number, etc.).
    /// </summary>
    [IsoId("_OZUfCf5rEeiLerArw36g0w")]
    [DisplayName("Receipt Destination")]
    [IsoXmlTag("RctDstn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ReceiptDestination { get; init; } 
    
    
    #nullable disable
    
}
