// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Undertaking status information.
/// </summary>
[IsoId("_-DLK5XltEeG7BsjMvd1mEw_1047822406")]
[DisplayName("Undertaking Status Advice")]
public partial record UndertakingStatusAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Details related to the party that initiated the report.
    /// </summary>
    [IsoId("_-DLK5nltEeG7BsjMvd1mEw_24427462")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification43 InitiatingParty { get; init; } 
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-DLK53ltEeG7BsjMvd1mEw_-1609250460")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public Undertaking8? UndertakingIdentification { get; init; } 
    
    /// <summary>
    /// Sequence number assigned by the issuer to each amendment of the undertaking.
    /// </summary>
    [IsoId("_-DLK6HltEeG7BsjMvd1mEw_-238433445")]
    [DisplayName("Amendment Sequence Number")]
    [IsoXmlTag("AmdmntSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AmendmentSequenceNumber { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-DU74HltEeG7BsjMvd1mEw_-1490832620")]
    [DisplayName("Advising Party Reference Number")]
    [IsoXmlTag("AdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_-DU74XltEeG7BsjMvd1mEw_1807062323")]
    [DisplayName("Confirmer Reference Number")]
    [IsoXmlTag("CnfrmrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; } 
    
    /// <summary>
    /// Specifies the category of the status.
    /// </summary>
    [IsoId("_-DU75HltEeG7BsjMvd1mEw_-482858718")]
    [DisplayName("Status Category")]
    [IsoXmlTag("StsCtgy")]
    public required ExternalUndertakingStatusCategory1Code StatusCategory { get; init; } 
    
    /// <summary>
    /// Specifies the reported status.
    /// </summary>
    [IsoId("_-DU74nltEeG7BsjMvd1mEw_-818864240")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required UndertakingStatus3Code Status { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_-DU743ltEeG7BsjMvd1mEw_1827841012")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReasonInformation8? StatusReason { get; init; } 
    
    /// <summary>
    /// Amount reported.
    /// </summary>
    [IsoId("_rO8tFq-2EeGNi5z8K_XPKQ")]
    [DisplayName("Reported Amount")]
    [IsoXmlTag("RptdAmt")]
    public ReportedAmount1? ReportedAmount { get; init; } 
    
    /// <summary>
    /// Information concerning the original message to which the status report may be sent in response.
    /// </summary>
    [IsoId("_-DU75XltEeG7BsjMvd1mEw_1261386021")]
    [DisplayName("Original Message Details")]
    [IsoXmlTag("OrgnlMsgDtls")]
    public OriginalMessage1? OriginalMessageDetails { get; init; } 
    
    /// <summary>
    /// Document or template enclosed in the report.
    /// </summary>
    [IsoId("_1IyGs37nEeGudZE4UaJCHQ")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public Document9? EnclosedFile { get; init; } 
    
    /// <summary>
    /// Additional information related to the report.
    /// </summary>
    [IsoId("_-Des4HltEeG7BsjMvd1mEw_1652499690")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    
    #nullable disable
    
}
