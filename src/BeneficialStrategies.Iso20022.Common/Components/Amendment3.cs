// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendent request.
/// </summary>
[IsoId("_999TsHltEeG7BsjMvd1mEw_-1184372634")]
[DisplayName("Amendment")]
public partial record Amendment3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking amendment request.
    /// </summary>
    [IsoId("_999TsXltEeG7BsjMvd1mEw_-1391454126")]
    [DisplayName("Applicant Request Number")]
    [IsoXmlTag("ApplcntReqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ApplicantRequestNumber { get; init; } 
    
    /// <summary>
    /// Identification of the undertaking.
    /// </summary>
    [IsoId("_999TsnltEeG7BsjMvd1mEw_911944804")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking9 UndertakingIdentification { get; init; } 
    
    /// <summary>
    /// Party requesting the issuance of the amendment.
    /// </summary>
    [IsoId("_999Ts3ltEeG7BsjMvd1mEw_1152590564")]
    [DisplayName("Applicant")]
    [IsoXmlTag("Applcnt")]
    public required PartyIdentification43 Applicant { get; init; } 
    
    /// <summary>
    /// Details concerning the requested termination of the undertaking.
    /// </summary>
    [IsoId("_9-HEsHltEeG7BsjMvd1mEw_2064337649")]
    [DisplayName("Termination Details")]
    [IsoXmlTag("TermntnDtls")]
    public UndertakingTermination3? TerminationDetails { get; init; } 
    
    /// <summary>
    /// Indication of the amount of increase or decrease to the undertaking amount.
    /// </summary>
    [IsoId("_9-HEsXltEeG7BsjMvd1mEw_-1359539373")]
    [DisplayName("Increase Decrease Amount")]
    [IsoXmlTag("IncrDcrAmt")]
    public UndertakingAmount2? IncreaseDecreaseAmount { get; init; } 
    
    /// <summary>
    /// Requested new expiry terms for the undertaking.
    /// </summary>
    [IsoId("_9-HEsnltEeG7BsjMvd1mEw_-880815384")]
    [DisplayName("New Expiry Details")]
    [IsoXmlTag("NewXpryDtls")]
    public ExpiryDetails2? NewExpiryDetails { get; init; } 
    
    /// <summary>
    /// Requested new beneficiary of the undertaking.
    /// </summary>
    [IsoId("_9-HEs3ltEeG7BsjMvd1mEw_1568325617")]
    [DisplayName("New Beneficiary")]
    [IsoXmlTag("NewBnfcry")]
    public Beneficiary1? NewBeneficiary { get; init; } 
    
    /// <summary>
    /// Requested new terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_9-HEtHltEeG7BsjMvd1mEw_-2101190221")]
    [DisplayName("New Undertaking Terms And Conditions")]
    [IsoXmlTag("NewUdrtkgTermsAndConds")]
    public Narrative1? NewUndertakingTermsAndConditions { get; init; } 
    
    /// <summary>
    /// Amendment details related to the counter-undertaking.
    /// </summary>
    [IsoId("_rFW_UH76EeGvEbxvurqpIg")]
    [DisplayName("Counter Undertaking")]
    [IsoXmlTag("CntrUdrtkg")]
    public Undertaking10? CounterUndertaking { get; init; } 
    
    /// <summary>
    /// Communication channel for delivery of the amendment.
    /// </summary>
    [IsoId("_9-HEtXltEeG7BsjMvd1mEw_-474768646")]
    [DisplayName("Delivery Channel")]
    [IsoXmlTag("DlvryChanl")]
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    
    /// <summary>
    /// Document or template enclosed in the request.
    /// </summary>
    [IsoId("_9-Q1sHltEeG7BsjMvd1mEw_1278799241")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public Document9? EnclosedFile { get; init; } 
    
    /// <summary>
    /// Additional information related to the request.
    /// </summary>
    [IsoId("_9-Q1sXltEeG7BsjMvd1mEw_-1410697911")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    
    #nullable disable
    
}
