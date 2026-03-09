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
/// Undertaking status information.
/// </summary>
[IsoId("_-DLK5XltEeG7BsjMvd1mEw_1047822406")]
[DisplayName("Undertaking Status Advice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingStatusAdvice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingStatusAdvice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingStatusAdvice1( PartyIdentification43 reqInitiatingParty,ExternalUndertakingStatusCategory1Code reqStatusCategory,UndertakingStatus3Code reqStatus )
    {
        InitiatingParty = reqInitiatingParty;
        StatusCategory = reqStatusCategory;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the party that initiated the report.
    /// </summary>
    [IsoId("_-DLK5nltEeG7BsjMvd1mEw_24427462")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 InitiatingParty { get; init; } 
    #else
    public PartyIdentification43 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-DLK53ltEeG7BsjMvd1mEw_-1609250460")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Undertaking8? UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking8? UndertakingIdentification { get; init; } 
    #else
    public Undertaking8? UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence number assigned by the issuer to each amendment of the undertaking.
    /// </summary>
    [IsoId("_-DLK6HltEeG7BsjMvd1mEw_-238433445")]
    [DisplayName("Amendment Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntSeqNb")]
    #endif
    [IsoXmlTag("AmdmntSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? AmendmentSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AmendmentSequenceNumber { get; init; } 
    #else
    public System.UInt64? AmendmentSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-DU74HltEeG7BsjMvd1mEw_-1490832620")]
    [DisplayName("Advising Party Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvsgPtyRefNb")]
    #endif
    [IsoXmlTag("AdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdvisingPartyReferenceNumber { get; init; } 
    #else
    public System.String? AdvisingPartyReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_-DU74XltEeG7BsjMvd1mEw_1807062323")]
    [DisplayName("Confirmer Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnfrmrRefNb")]
    #endif
    [IsoXmlTag("CnfrmrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmerReferenceNumber { get; init; } 
    #else
    public System.String? ConfirmerReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of the status.
    /// </summary>
    [IsoId("_-DU75HltEeG7BsjMvd1mEw_-482858718")]
    [DisplayName("Status Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsCtgy")]
    #endif
    [IsoXmlTag("StsCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingStatusCategory1Code StatusCategory { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingStatusCategory1Code StatusCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingStatusCategory1Code StatusCategory { get; init; } 
    #else
    public ExternalUndertakingStatusCategory1Code StatusCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reported status.
    /// </summary>
    [IsoId("_-DU74nltEeG7BsjMvd1mEw_-818864240")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingStatus3Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingStatus3Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingStatus3Code Status { get; init; } 
    #else
    public UndertakingStatus3Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_-DU743ltEeG7BsjMvd1mEw_1827841012")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation8? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation8? StatusReason { get; init; } 
    #else
    public StatusReasonInformation8? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount reported.
    /// </summary>
    [IsoId("_rO8tFq-2EeGNi5z8K_XPKQ")]
    [DisplayName("Reported Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdAmt")]
    #endif
    [IsoXmlTag("RptdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportedAmount1? ReportedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportedAmount1? ReportedAmount { get; init; } 
    #else
    public ReportedAmount1? ReportedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original message to which the status report may be sent in response.
    /// </summary>
    [IsoId("_-DU75XltEeG7BsjMvd1mEw_1261386021")]
    [DisplayName("Original Message Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgDtls")]
    #endif
    [IsoXmlTag("OrgnlMsgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalMessage1? OriginalMessageDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessage1? OriginalMessageDetails { get; init; } 
    #else
    public OriginalMessage1? OriginalMessageDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Document or template enclosed in the report.
    /// </summary>
    [IsoId("_1IyGs37nEeGudZE4UaJCHQ")]
    [DisplayName("Enclosed File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NclsdFile")]
    #endif
    [IsoXmlTag("NclsdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document9? EnclosedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document9? EnclosedFile { get; init; } 
    #else
    public Document9? EnclosedFile { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the report.
    /// </summary>
    [IsoId("_-Des4HltEeG7BsjMvd1mEw_1652499690")]
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
