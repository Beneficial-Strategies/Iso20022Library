// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes a financing relation between two parties, for example invoice, credit, financing request, cash accounts.
/// </summary>
[IsoId("_OTgzMzU2-AOSNFX-8224501")]
[DisplayName("Financing Agreement Item")]
public partial record FinancingAgreementItem1
{
    #nullable enable
    
    /// <summary>
    /// Parameters related to the context of the item.
    /// </summary>
    [IsoId("_OTgzMzY4-AOSNFX-8224501")]
    [DisplayName("Item Context")]
    [IsoXmlTag("ItmCntxt")]
    public required FinancialItemParameters1 ItemContext { get; init; } 
    
    /// <summary>
    /// Code to indicate the action concerning the item.
    /// </summary>
    [IsoId("_OTgzMzY5-AOSNFX-8224501")]
    [DisplayName("Item Action")]
    [IsoXmlTag("ItmActn")]
    public AgreementItemAction1Code? ItemAction { get; init; } 
    
    /// <summary>
    /// Desired payment instruction to be used by buyer.
    /// </summary>
    [IsoId("_OTgzMzcw-AOSNFX-8224501")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public PaymentInstrumentCode? PaymentInstrument { get; init; } 
    
    /// <summary>
    /// Validation status of the item.
    /// </summary>
    [IsoId("_OTgzMzcx-AOSNFX-8224501")]
    [DisplayName("Validation Status Information")]
    [IsoXmlTag("VldtnStsInf")]
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    
    /// <summary>
    /// Guarantee is (to be) provided according current rating.
    /// </summary>
    [IsoId("_OTgzMzcy-AOSNFX-8224501")]
    [DisplayName("Rating")]
    [IsoXmlTag("Ratg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Rating { get; init; } 
    
    /// <summary>
    /// Set to yes if the agreement was rejected and needs to be re-opened for arbitrage.
    /// </summary>
    [IsoId("_OTgzMzcz-AOSNFX-8224501")]
    [DisplayName("Reopen Indication")]
    [IsoXmlTag("ReopIndctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ReopenIndication { get; init; } 
    
    /// <summary>
    /// Issuers, amounts and periods to be guaranteed. At a given date, the sum of all issuers is guaranteed, covered as specified by rank/position and excess. For each period, the maximum value at a given date is used.
    /// </summary>
    [IsoId("_OTgzMzc1-AOSNFX-8224501")]
    [DisplayName("Guarantee")]
    [IsoXmlTag("Grnt")]
    public GuaranteeDetails1? Guarantee { get; init; } 
    
    /// <summary>
    /// Status of guarantee if applicable.
    /// </summary>
    [IsoId("_OTgzMzc2-AOSNFX-8224501")]
    [DisplayName("Guarantee Status")]
    [IsoXmlTag("GrntSts")]
    public ValidationStatusInformation1? GuaranteeStatus { get; init; } 
    
    /// <summary>
    /// Reference to the guarantee letter issued by a guarantee provider.
    /// </summary>
    [IsoId("_OTgzMzc3-AOSNFX-8224501")]
    [DisplayName("Related Guarantee Letter")]
    [IsoXmlTag("RltdGrntLttr")]
    public QualifiedDocumentInformation1? RelatedGuaranteeLetter { get; init; } 
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMzc4-AOSNFX-8224501")]
    [DisplayName("Associated Document")]
    [IsoXmlTag("AssoctdDoc")]
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    
    /// <summary>
    /// Free form textual information related to the agreement.
    /// </summary>
    [IsoId("_OTgzMzc5-AOSNFX-8224502")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    
    #nullable disable
    
}
