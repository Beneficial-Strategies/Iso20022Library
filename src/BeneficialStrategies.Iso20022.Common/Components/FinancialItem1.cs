// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information about a financing relation between two parties represented by a document, for example invoice, credit.
/// The component may include an external document describing details of the underlying trade object using an external schema.
/// </summary>
[IsoId("_OTgzMzMy-AOSNFX-8224500")]
[DisplayName("Financial Item")]
public partial record FinancialItem1
{
    #nullable enable
    
    /// <summary>
    /// Parameters identifying the context of the item.
    /// </summary>
    [IsoId("_OTgzMzk3-AOSNFX-8224503")]
    [DisplayName("Item Context")]
    [IsoXmlTag("ItmCntxt")]
    public required FinancialItemParameters1 ItemContext { get; init; } 
    
    /// <summary>
    /// Identifier of financial document that is the base document for this item, for example an invoice number.
    /// </summary>
    [IsoId("_OTgzMzk4-AOSNFX-8224503")]
    [DisplayName("Financial Document Reference")]
    [IsoXmlTag("FinDocRef")]
    public QualifiedDocumentInformation1? FinancialDocumentReference { get; init; } 
    
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_OTgzMzk5-AOSNFX-8224503")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the total amount related to the financial document.
    /// </summary>
    [IsoId("_OTgzNDAw-AOSNFX-8224503")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required InvoiceTotals1 TotalAmount { get; init; } 
    
    /// <summary>
    /// Specifies the remaining monetary amount.
    /// </summary>
    [IsoId("_OTgzNDAx-AOSNFX-8224503")]
    [DisplayName("Due Amount")]
    [IsoXmlTag("DueAmt")]
    public ActiveCurrencyAndAmount? DueAmount { get; init; } 
    
    /// <summary>
    /// Instalment information for payment.
    /// </summary>
    [IsoId("_OTgzNDAy-AOSNFX-8224503")]
    [DisplayName("Instalment Information")]
    [IsoXmlTag("InstlmtInf")]
    public Instalment2? InstalmentInformation { get; init; } 
    
    /// <summary>
    /// Additional proprietary textual information concerning the item.
    /// </summary>
    [IsoId("_OTgzNDA1-AOSNFX-8224503")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Associated free form document, for example a delivery confirmation.
    /// </summary>
    [IsoId("_OTgzNDA2-AOSNFX-8224503")]
    [DisplayName("Associated Document")]
    [IsoXmlTag("AssoctdDoc")]
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    
    /// <summary>
    /// Validation status of the item.
    /// </summary>
    [IsoId("_OTgzNDA3-AOSNFX-8224503")]
    [DisplayName("Validation Status Information")]
    [IsoXmlTag("VldtnStsInf")]
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    
    /// <summary>
    /// Financing status if applicable for the item.
    /// </summary>
    [IsoId("_OTgzNDA4-AOSNFX-8224503")]
    [DisplayName("Financing Status")]
    [IsoXmlTag("FincgSts")]
    public FinancingInformationAndStatus1? FinancingStatus { get; init; } 
    
    /// <summary>
    /// Structured proprietary information concerning details of the financial item.
    /// </summary>
    [IsoId("_OTgzNDA0-AOSNFX-8224503")]
    [DisplayName("Proprietary Details")]
    [IsoXmlTag("PrtryDtls")]
    public SupplementaryData1? ProprietaryDetails { get; init; } 
    
    
    #nullable disable
    
}
