// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Formal document used to record a fact and used as proof of the fact, in the context of a commercial trade transaction.
/// </summary>
[IsoId("_TnTb4tp-Ed-ak6NoX_4Aeg_-729563695")]
[DisplayName("Certificate Data Set")]
public record CertificateDataSet1
{
    /// <summary>
    /// Identifies the certificate data set.
    /// </summary>
    [IsoId("_TnTb49p-Ed-ak6NoX_4Aeg_-942248748")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; }

    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_TnTb5Np-Ed-ak6NoX_4Aeg_-729563693")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    public required TradeCertificateType1Code CertificateType { get; init; }

    /// <summary>
    /// Specifies if the certificate data set is required in relation to specific line items, and which line items.
    /// </summary>
    [IsoId("_TnTb5dp-Ed-ak6NoX_4Aeg_1492322947")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<LineItemAndPOIdentification1> LineItem { get; init; } = [];

    /// <summary>
    /// Characteristics of the goods that are certified, in the context of a commercial trade transaction.
    /// </summary>
    [IsoId("_TnTb5tp-Ed-ak6NoX_4Aeg_1300993152")]
    [DisplayName("Certified Characteristics")]
    [IsoXmlTag("CertfdChrtcs")]
    public required CertifiedCharacteristics1Choice_ CertifiedCharacteristics { get; init; }

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_TnTb59p-Ed-ak6NoX_4Aeg_-889596132")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; }

    /// <summary>
    /// Place where the certificate was issued.
    /// </summary>
    [IsoId("_TnTb6Np-Ed-ak6NoX_4Aeg_-729563412")]
    [DisplayName("Place Of Issue")]
    [IsoXmlTag("PlcOfIsse")]
    public PostalAddress5? PlaceOfIssue { get; init; }

    /// <summary>
    /// Issuer of the certificate, typically the inspection company or its agent.
    /// </summary>
    [IsoId("_TnTb6dp-Ed-ak6NoX_4Aeg_-729563160")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification26 Issuer { get; init; }

    /// <summary>
    /// Date(s) at which inspection of the goods took place.
    /// </summary>
    [IsoId("_Tncl0Np-Ed-ak6NoX_4Aeg_-258567065")]
    [DisplayName("Inspection Date")]
    [IsoXmlTag("InspctnDt")]
    public DatePeriodDetails? InspectionDate { get; init; }

    /// <summary>
    /// Indicates that the inspection has been performed by an authorised inspector.
    /// </summary>
    [IsoId("_Tncl0dp-Ed-ak6NoX_4Aeg_1960984582")]
    [DisplayName("Authorised Inspector Indicator")]
    [IsoXmlTag("AuthrsdInspctrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AuthorisedInspectorIndicator { get; init; }

    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_Tncl0tp-Ed-ak6NoX_4Aeg_-729563395")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CertificateIdentification { get; init; }

    /// <summary>
    /// Transport information relative to the goods that are covered by the certificate.
    /// </summary>
    [IsoId("_Tncl09p-Ed-ak6NoX_4Aeg_-884067004")]
    [DisplayName("Transport")]
    [IsoXmlTag("Trnsprt")]
    public SingleTransport3? Transport { get; init; }

    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_Tncl1Np-Ed-ak6NoX_4Aeg_-729563335")]
    [DisplayName("Goods Description")]
    [IsoXmlTag("GoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? GoodsDescription { get; init; }

    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    [IsoId("_Tncl1dp-Ed-ak6NoX_4Aeg_-729562858")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public PartyIdentification26? Consignor { get; init; }

    /// <summary>
    /// Party to whom the goods (which are the subject of the certificate) must be delivered.
    /// </summary>
    [IsoId("_Tncl1tp-Ed-ak6NoX_4Aeg_-729563118")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public PartyIdentification26? Consignee { get; init; }

    /// <summary>
    /// Manufacturer of the goods which are the subject of the certificate.
    /// </summary>
    [IsoId("_Tncl19p-Ed-ak6NoX_4Aeg_2141067859")]
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    public PartyIdentification26? Manufacturer { get; init; }

    /// <summary>
    /// Additional and important information that could not be captured by structured fields.
    /// </summary>
    [IsoId("_Tncl2Np-Ed-ak6NoX_4Aeg_-729563179")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax350Text> AdditionalInformation { get; init; } = [];
}
