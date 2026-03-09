// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes a financing relation between two parties, for example invoice, credit, financing request, cash accounts.
/// </summary>
[IsoId("_OTgzMzU2-AOSNFX-8224501")]
[DisplayName("Financing Agreement Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingAgreementItem1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingAgreementItem1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingAgreementItem1( FinancialItemParameters1 reqItemContext,System.String reqRating,System.String reqReopenIndication )
    {
        ItemContext = reqItemContext;
        Rating = reqRating;
        ReopenIndication = reqReopenIndication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Parameters related to the context of the item.
    /// </summary>
    [IsoId("_OTgzMzY4-AOSNFX-8224501")]
    [DisplayName("Item Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmCntxt")]
    #endif
    [IsoXmlTag("ItmCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialItemParameters1 ItemContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialItemParameters1 ItemContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialItemParameters1 ItemContext { get; init; } 
    #else
    public FinancialItemParameters1 ItemContext { get; set; } 
    #endif
    
    /// <summary>
    /// Code to indicate the action concerning the item.
    /// </summary>
    [IsoId("_OTgzMzY5-AOSNFX-8224501")]
    [DisplayName("Item Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmActn")]
    #endif
    [IsoXmlTag("ItmActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreementItemAction1Code? ItemAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreementItemAction1Code? ItemAction { get; init; } 
    #else
    public AgreementItemAction1Code? ItemAction { get; set; } 
    #endif
    
    /// <summary>
    /// Desired payment instruction to be used by buyer.
    /// </summary>
    [IsoId("_OTgzMzcw-AOSNFX-8224501")]
    [DisplayName("Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrm")]
    #endif
    [IsoXmlTag("PmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrumentCode? PaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrumentCode? PaymentInstrument { get; init; } 
    #else
    public PaymentInstrumentCode? PaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Validation status of the item.
    /// </summary>
    [IsoId("_OTgzMzcx-AOSNFX-8224501")]
    [DisplayName("Validation Status Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnStsInf")]
    #endif
    [IsoXmlTag("VldtnStsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #else
    public ValidationStatusInformation1? ValidationStatusInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Guarantee is (to be) provided according current rating.
    /// </summary>
    [IsoId("_OTgzMzcy-AOSNFX-8224501")]
    [DisplayName("Rating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ratg")]
    #endif
    [IsoXmlTag("Ratg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Rating { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Rating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Rating { get; init; } 
    #else
    public System.String Rating { get; set; } 
    #endif
    
    /// <summary>
    /// Set to yes if the agreement was rejected and needs to be re-opened for arbitrage.
    /// </summary>
    [IsoId("_OTgzMzcz-AOSNFX-8224501")]
    [DisplayName("Reopen Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReopIndctn")]
    #endif
    [IsoXmlTag("ReopIndctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ReopenIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReopenIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReopenIndication { get; init; } 
    #else
    public System.String ReopenIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Issuers, amounts and periods to be guaranteed. At a given date, the sum of all issuers is guaranteed, covered as specified by rank/position and excess. For each period, the maximum value at a given date is used.
    /// </summary>
    [IsoId("_OTgzMzc1-AOSNFX-8224501")]
    [DisplayName("Guarantee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grnt")]
    #endif
    [IsoXmlTag("Grnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GuaranteeDetails1? Guarantee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GuaranteeDetails1? Guarantee { get; init; } 
    #else
    public GuaranteeDetails1? Guarantee { get; set; } 
    #endif
    
    /// <summary>
    /// Status of guarantee if applicable.
    /// </summary>
    [IsoId("_OTgzMzc2-AOSNFX-8224501")]
    [DisplayName("Guarantee Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntSts")]
    #endif
    [IsoXmlTag("GrntSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusInformation1? GuaranteeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusInformation1? GuaranteeStatus { get; init; } 
    #else
    public ValidationStatusInformation1? GuaranteeStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the guarantee letter issued by a guarantee provider.
    /// </summary>
    [IsoId("_OTgzMzc3-AOSNFX-8224501")]
    [DisplayName("Related Guarantee Letter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdGrntLttr")]
    #endif
    [IsoXmlTag("RltdGrntLttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? RelatedGuaranteeLetter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? RelatedGuaranteeLetter { get; init; } 
    #else
    public QualifiedDocumentInformation1? RelatedGuaranteeLetter { get; set; } 
    #endif
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMzc4-AOSNFX-8224501")]
    [DisplayName("Associated Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDoc")]
    #endif
    [IsoXmlTag("AssoctdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #else
    public QualifiedDocumentInformation1? AssociatedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Free form textual information related to the agreement.
    /// </summary>
    [IsoId("_OTgzMzc5-AOSNFX-8224502")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
