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
[IsoId("_l1j-wbGJEeuSTr8k0UEM8A")]
[DisplayName("Supporting Document Entry")]
public record SupportingDocumentEntry2
{
    /// <summary>
    /// Unique and unambiguous identification of the supporting document entry.
    /// </summary>
    [IsoId("_l2d9sbGJEeuSTr8k0UEM8A")]
    [DisplayName("Entry Identification")]
    [IsoXmlTag("NtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EntryIdentification { get; init; }

    /// <summary>
    /// Identification of the original document for which the supporting documents are provided.
    /// </summary>
    [IsoId("_l2d9s7GJEeuSTr8k0UEM8A")]
    [DisplayName("Original Document")]
    [IsoXmlTag("OrgnlDoc")]
    public required DocumentIdentification22 OriginalDocument { get; init; }

    /// <summary>
    /// Document type in a coded form.
    /// TBC: Data must support &quot;_&quot;.
    /// </summary>
    [IsoId("_l2d9tbGJEeuSTr8k0UEM8A")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericUnderscoreText)]
    public required IsoExact4AlphaNumericUnderscoreText DocumentType { get; init; }

    /// <summary>
    /// Total amount of the supporting document entry.
    /// </summary>
    [IsoId("_l2d9t7GJEeuSTr8k0UEM8A")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Total amount after shipment of the supporting document entry.
    /// </summary>
    [IsoId("_l2d9ubGJEeuSTr8k0UEM8A")]
    [DisplayName("Total Amount After Shipment")]
    [IsoXmlTag("TtlAmtAftrShipmnt")]
    public ActiveCurrencyAndAmount? TotalAmountAfterShipment { get; init; }

    /// <summary>
    /// Total amount of the supporting document entry in the currency of the contract.
    /// </summary>
    [IsoId("_l2d9u7GJEeuSTr8k0UEM8A")]
    [DisplayName("Total Amount In Contract Currency")]
    [IsoXmlTag("TtlAmtInCtrctCcy")]
    public ActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; init; }

    /// <summary>
    /// Total amount after shipment of the supporting document entry in the currency of the contract.
    /// </summary>
    [IsoId("_l2d9vbGJEeuSTr8k0UEM8A")]
    [DisplayName("Total Amount After Shipment In Contract Currency")]
    [IsoXmlTag("TtlAmtAftrShipmntInCtrctCcy")]
    public ActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; init; }

    /// <summary>
    /// Conditions and attributes related to the shipment.
    /// </summary>
    [IsoId("_l2d9v7GJEeuSTr8k0UEM8A")]
    [DisplayName("Shipment Attributes")]
    [IsoXmlTag("ShipmntAttrbts")]
    public required ShipmentAttribute2 ShipmentAttributes { get; init; }

    /// <summary>
    /// Identification of the document entry amendment.
    /// </summary>
    [IsoId("_FnwlELP7Eeud-ZmjZVm7MA")]
    [DisplayName("Entry Amendment Identification")]
    [IsoXmlTag("NtryAmdmntId")]
    public DocumentEntryAmendment1? EntryAmendmentIdentification { get; init; }

    /// <summary>
    /// Indication of contract obligations execution.
    /// </summary>
    [IsoId("_xqX3ULP_Eeud-ZmjZVm7MA")]
    [DisplayName("Maturity Data")]
    [IsoXmlTag("MtrtyData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MaturityData { get; init; }

    /// <summary>
    /// Further details on the supporting document entry.
    /// </summary>
    [IsoId("_l2d9wbGJEeuSTr8k0UEM8A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Documents provided as attachments to the supporting document entry.
    /// </summary>
    [IsoId("_l2d9w7GJEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];
}
