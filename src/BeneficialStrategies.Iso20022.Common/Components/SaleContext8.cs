// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the sale involved in a card transaction.
/// </summary>
[IsoId("_GejwcShKEeyhZIgCcGlTyA")]
[DisplayName("Sale Context")]
public record SaleContext8
{
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_GknVIShKEeyhZIgCcGlTyA")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_GknVIyhKEeyhZIgCcGlTyA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_GknVJShKEeyhZIgCcGlTyA")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceNumber { get; init; }

    /// <summary>
    /// Type of goods and/or services.
    /// </summary>
    [IsoId("_GknVJyhKEeyhZIgCcGlTyA")]
    [DisplayName("Goods And Services Type")]
    [IsoXmlTag("GoodsAndSvcsTp")]
    public GoodsAndServices1Code? GoodsAndServicesType { get; init; }

    /// <summary>
    /// Sub type of goods and/or services.
    /// </summary>
    [IsoId("_GknVKShKEeyhZIgCcGlTyA")]
    [DisplayName("Good And Services Sub Type")]
    [IsoXmlTag("GoodAndSvcsSubTp")]
    public GoodsAndServicesSubType1Code? GoodAndServicesSubType { get; init; }

    /// <summary>
    /// Other goods and services sub type applied to the transaction.
    /// </summary>
    [IsoId("_GknVKyhKEeyhZIgCcGlTyA")]
    [DisplayName("Good And Services Other Sub Type")]
    [IsoXmlTag("GoodAndSvcsOthrSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GoodAndServicesOtherSubType { get; init; }

    /// <summary>
    /// Code that specifies the good or service delivery channel.
    /// </summary>
    [IsoId("_pHSlYD5LEeyHI64WSlzTlg")]
    [DisplayName("Good And Service Delivery Channel")]
    [IsoXmlTag("GoodAndSvcDlvryChanl")]
    public GoodAndServiceDeliveryChannel1Code? GoodAndServiceDeliveryChannel { get; init; }

    /// <summary>
    /// Other good or service delivery channel defined at private or national level.
    /// </summary>
    [IsoId("_3TryoD5LEeyHI64WSlzTlg")]
    [DisplayName("Other Good And Service Delivery Channel")]
    [IsoXmlTag("OthrGoodAndSvcDlvryChanl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherGoodAndServiceDeliveryChannel { get; init; }

    /// <summary>
    /// Code that specifies the good or service delivery schedule.
    /// </summary>
    [IsoId("_AJPeED5MEeyHI64WSlzTlg")]
    [DisplayName("Good And Service Delivery Schedule")]
    [IsoXmlTag("GoodAndSvcDlvrySchdl")]
    public GoodAndServiceDeliverySchedule1Code? GoodAndServiceDeliverySchedule { get; init; }

    /// <summary>
    /// Other good or service delivery schedule defined at private or national level.
    /// </summary>
    [IsoId("_H9uuED5MEeyHI64WSlzTlg")]
    [DisplayName("Other Good And Service Delivery Schedule")]
    [IsoXmlTag("OthrGoodAndSvcDlvrySchdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherGoodAndServiceDeliverySchedule { get; init; }

    /// <summary>
    /// Also referred to as split tender. Indicates whether the payment transaction is a partial payment of the sale transaction.
    /// True: Partial payment of a sale transaction
    /// False: Not a partial payment of a sale transaction.
    /// </summary>
    [IsoId("_GknVLShKEeyhZIgCcGlTyA")]
    [DisplayName("Split Payment Indicator")]
    [IsoXmlTag("SpltPmtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitPaymentIndicator { get; init; }

    /// <summary>
    /// Indicates whether a receipt from the goods or services provider was requested.
    /// True: Receipt requested
    /// False: Receipt not requested.
    /// </summary>
    [IsoId("_GknVLyhKEeyhZIgCcGlTyA")]
    [DisplayName("Receipt Request Indicator")]
    [IsoXmlTag("RctReqInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptRequestIndicator { get; init; }

    /// <summary>
    /// Type of receipt requested or communication channel used.
    /// </summary>
    [IsoId("_GknVMShKEeyhZIgCcGlTyA")]
    [DisplayName("Receipt Type")]
    [IsoXmlTag("RctTp")]
    public SimpleValueList<ReceiptType1Code> ReceiptType { get; init; } = [];

    /// <summary>
    /// Destination of the receipt (for example, e-mail address, SMS number, etc.).
    /// </summary>
    [IsoId("_GknVMyhKEeyhZIgCcGlTyA")]
    [DisplayName("Receipt Destination")]
    [IsoXmlTag("RctDstn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ReceiptDestination { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_SeXxYShKEeyhZIgCcGlTyA")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
