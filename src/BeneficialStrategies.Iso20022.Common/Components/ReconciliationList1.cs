// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a list of reconciliation information concerning financial items.
/// </summary>
[IsoId("_OTgzMTk5-AOSNFX-8224490")]
[DisplayName("Reconciliation List")]
public partial record ReconciliationList1
{
    #nullable enable
    
    /// <summary>
    /// Date of creation of this document.
    /// </summary>
    [IsoId("_OTgzNDE5-AOSNFX-8224504")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; } 
    
    /// <summary>
    /// Reference to related documents for example to original assignment in a status response or retry.
    /// </summary>
    [IsoId("_OTgzNDIw-AOSNFX-8224504")]
    [DisplayName("Related Document")]
    [IsoXmlTag("RltdDoc")]
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    
    /// <summary>
    /// Party to be advised.
    /// </summary>
    [IsoId("_OTgzNDIx-AOSNFX-8224504")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public required QualifiedPartyIdentification1 Recipient { get; init; } 
    
    /// <summary>
    /// Informing party.
    /// </summary>
    [IsoId("_OTgzNDIy-AOSNFX-8224504")]
    [DisplayName("Advisor")]
    [IsoXmlTag("Advsr")]
    public required QualifiedPartyIdentification1 Advisor { get; init; } 
    
    /// <summary>
    /// Identification parameters.
    /// </summary>
    [IsoId("_OTgzNDIz-AOSNFX-8224504")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public required FinancialItemParameters1 Parameters { get; init; } 
    
    /// <summary>
    /// Reference to a payment instruction.
    /// </summary>
    [IsoId("_OTgzNDI0-AOSNFX-8224504")]
    [DisplayName("Payment Reference")]
    [IsoXmlTag("PmtRef")]
    public required PaymentIdentification1 PaymentReference { get; init; } 
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_OTgzNDI1-AOSNFX-8224504")]
    [DisplayName("Payment Means")]
    [IsoXmlTag("PmtMeans")]
    public required PaymentMeans1 PaymentMeans { get; init; } 
    
    /// <summary>
    /// Effective date of payment.
    /// </summary>
    [IsoId("_OTgzNDI2-AOSNFX-8224504")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PaymentDate { get; init; } 
    
    /// <summary>
    /// Terms of the payment.
    /// </summary>
    [IsoId("_OTgzNDI3-AOSNFX-8224504")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public required PaymentTerms6 PaymentTerms { get; init; } 
    
    /// <summary>
    /// Amount of the referenced payment.
    /// </summary>
    [IsoId("_OTgzNDI4-AOSNFX-8224504")]
    [DisplayName("Payment Amount")]
    [IsoXmlTag("PmtAmt")]
    public required CurrencyAndAmount PaymentAmount { get; init; } 
    
    /// <summary>
    /// Financial item impacted by the payment.
    /// </summary>
    [IsoId("_OTgzNDI5-AOSNFX-8224504")]
    [DisplayName("Item")]
    [IsoXmlTag("Itm")]
    public ValueList<FinancialItem1> Item { get; init; } = [];
    // ID for the above is _OTgzNDI5-AOSNFX-8224504
    
    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    [IsoId("_OTgzNDMw-AOSNFX-8224504")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText ItemCount { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the list, irrespective of currencies.
    /// </summary>
    [IsoId("_OTgzNDMx-AOSNFX-8224504")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzNDMy-AOSNFX-8224504")]
    [DisplayName("Associated Document")]
    [IsoXmlTag("AssoctdDoc")]
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    
    /// <summary>
    /// Additional proprietary formal information concerning the list.
    /// </summary>
    [IsoId("_OTgzNDMz-AOSNFX-8224505")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Validation status of the list.
    /// </summary>
    [IsoId("_OTgzNDM0-AOSNFX-8224505")]
    [DisplayName("Validation Status Information")]
    [IsoXmlTag("VldtnStsInf")]
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    
    
    #nullable disable
    
}
