// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control document entry supporting the contract registration.
/// </summary>
[IsoId("_UZhbktM-EeSDLevdaFPXHw")]
[DisplayName("Supporting Document Entry")]
public record SupportingDocumentEntry1
{
    /// <summary>
    /// Unique and unambiguous identification of the supporting document entry.
    /// </summary>
    [IsoId("_OKZKZNM_EeSDLevdaFPXHw")]
    [DisplayName("Entry Identification")]
    [IsoXmlTag("NtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EntryIdentification { get; init; }

    /// <summary>
    /// Identification of the original document for which the supporting documents are provided.
    /// </summary>
    [IsoId("_U55vVNM_EeSDLevdaFPXHw")]
    [DisplayName("Original Document")]
    [IsoXmlTag("OrgnlDoc")]
    public required DocumentIdentification22 OriginalDocument { get; init; }

    /// <summary>
    /// Document type in a coded form.
    /// TBC: Data must support &quot;_&quot;.
    /// </summary>
    [IsoId("_aRX4YNNBEeSDLevdaFPXHw")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText DocumentType { get; init; }

    /// <summary>
    /// Total amount of the supporting document entry.
    /// </summary>
    [IsoId("_iVxMoNNBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Total amount after shipment of the supporting document entry.
    /// </summary>
    [IsoId("_qZ3l8NNBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount After Shipment")]
    [IsoXmlTag("TtlAmtAftrShipmnt")]
    public ActiveCurrencyAndAmount? TotalAmountAfterShipment { get; init; }

    /// <summary>
    /// Total amount of the supporting document entry in the currency of the contract.
    /// </summary>
    [IsoId("_w5GTMtNBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount In Contract Currency")]
    [IsoXmlTag("TtlAmtInCtrctCcy")]
    public ActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; init; }

    /// <summary>
    /// Total amount after shipment of the supporting document entry in the currency of the contract.
    /// </summary>
    [IsoId("_w5GTM9NBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount After Shipment In Contract Currency")]
    [IsoXmlTag("TtlAmtAftrShipmntInCtrctCcy")]
    public ActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; init; }

    /// <summary>
    /// Conditions and attributes related to the shipment.
    /// </summary>
    [IsoId("_Aa6bQNNCEeSDLevdaFPXHw")]
    [DisplayName("Shipment Attributes")]
    [IsoXmlTag("ShipmntAttrbts")]
    public required ShipmentAttribute1 ShipmentAttributes { get; init; }

    /// <summary>
    /// Further details on the supporting document entry.
    /// </summary>
    [IsoId("_H-HuANNCEeSDLevdaFPXHw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Documents provided as attachments to the supporting document entry.
    /// </summary>
    [IsoId("_VCOdgdNCEeSDLevdaFPXHw")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public DocumentGeneralInformation3? Attachment { get; init; }
}
