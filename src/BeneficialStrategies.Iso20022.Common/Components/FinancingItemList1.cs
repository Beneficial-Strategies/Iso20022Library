// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a list of financing items exchanged between two parties, for example invoice, credit, financing request.
/// </summary>
[IsoId("_OTgzMTk3-AOSNFX-8224490")]
[DisplayName("Financing Item List")]
public record FinancingItemList1
{
    /// <summary>
    /// Identification assigned to unambiguously identify the financing item list.
    /// </summary>
    [IsoId("_OTgzMzI0-AOSNFX-8224499")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identifier { get; init; }

    /// <summary>
    /// Date of creation of this document.
    /// </summary>
    [IsoId("_OTgzMzI1-AOSNFX-8224499")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; }

    /// <summary>
    /// Reference to related documents for example to original assignment in a status response or retry.
    /// </summary>
    [IsoId("_OTgzMzI2-AOSNFX-8224500")]
    [DisplayName("Related Document")]
    [IsoXmlTag("RltdDoc")]
    public QualifiedDocumentInformation1? RelatedDocument { get; init; }

    /// <summary>
    /// Cut off date for items used to establish the total request amount.
    /// </summary>
    [IsoId("_OTgzMzI3-AOSNFX-8224500")]
    [DisplayName("Amount Cut Off Date")]
    [IsoXmlTag("AmtCutOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AmountCutOffDate { get; init; }

    /// <summary>
    /// Party to which the list is assigned.
    /// </summary>
    [IsoId("_OTgzMzI4-AOSNFX-8224500")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required QualifiedPartyIdentification1 Assignee { get; init; }

    /// <summary>
    /// Party assigning the list.
    /// </summary>
    [IsoId("_OTgzMzI5-AOSNFX-8224500")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required QualifiedPartyIdentification1 Assigner { get; init; }

    /// <summary>
    /// Identifies parties that notify the assignment(s) and the notified parties.
    /// </summary>
    [IsoId("_OTgzMzMx-AOSNFX-8224500")]
    [DisplayName("Notification Information")]
    [IsoXmlTag("NtfctnInf")]
    public FinancingNotificationParties1? NotificationInformation { get; init; }

    /// <summary>
    /// List of items/transactions.
    /// </summary>
    [IsoId("_OTgzMzMz-AOSNFX-8224500")]
    [DisplayName("Financial Item")]
    [IsoXmlTag("FinItm")]
    public FinancialItem1? FinancialItem { get; init; }

    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    [IsoId("_OTgzMzM0-AOSNFX-8224500")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText ItemCount { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the list, irrespective of currencies.
    /// </summary>
    [IsoId("_OTgzMzM1-AOSNFX-8224500")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Total amount in all items. Requires same currency, necessary when financing request is in percentage.
    /// </summary>
    [IsoId("_OTgzMzM2-AOSNFX-8224500")]
    [DisplayName("Total Request Amount")]
    [IsoXmlTag("TtlReqAmt")]
    public ActiveCurrencyAndAmount? TotalRequestAmount { get; init; }

    /// <summary>
    /// Total amount requested.
    /// </summary>
    [IsoId("_OTgzMzM3-AOSNFX-8224500")]
    [DisplayName("Total Request Financing")]
    [IsoXmlTag("TtlReqFincg")]
    public FinancingRateOrAmountChoice_? TotalRequestFinancing { get; init; }

    /// <summary>
    /// Acceptable exchange rate for financing by different currency.
    /// </summary>
    [IsoId("_OTgzMzM4-AOSNFX-8224500")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public AgreedRate1? AgreedRate { get; init; }

    /// <summary>
    /// Instalment for the financing.
    /// </summary>
    [IsoId("_OTgzMzQw-AOSNFX-8224500")]
    [DisplayName("Financing Instalment")]
    [IsoXmlTag("FincgInstlmt")]
    public Instalment2? FinancingInstalment { get; init; }

    /// <summary>
    /// Additional free form information concerning the list.
    /// </summary>
    [IsoId("_OTgzMzQx-AOSNFX-8224500")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000, MinimumLength = 1)]
    public IsoMax2000Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Validation status of the list.
    /// </summary>
    [IsoId("_OTgzMzQy-AOSNFX-8224500")]
    [DisplayName("Validation Status Information")]
    [IsoXmlTag("VldtnStsInf")]
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; }

    /// <summary>
    /// Financing status if applicable to the nature of the items.
    /// </summary>
    [IsoId("_OTgzMzQz-AOSNFX-8224500")]
    [DisplayName("Financing Status")]
    [IsoXmlTag("FincgSts")]
    public FinancingInformationAndStatus1? FinancingStatus { get; init; }
}
