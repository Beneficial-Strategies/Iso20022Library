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
/// Provides the history of status and reasons for a pending, posted or cancelled transaction.
/// </summary>
[IsoId("_0e6CsglIEeGATtfOBToyew_246812455")]
[DisplayName("Status Trail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusTrail2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusTrail2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusTrail2( System.DateTime reqStatusDate )
    {
        StatusDate = reqStatusDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_0e6CswlIEeGATtfOBToyew_-559345248")]
    [DisplayName("Status Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDt")]
    #endif
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime StatusDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime StatusDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime StatusDate { get; init; } 
    #else
    public System.DateTime StatusDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous way to identify the organisation that sent the message instance.
    /// </summary>
    [IsoId("_0e6CtAlIEeGATtfOBToyew_-990066161")]
    [DisplayName("Sending Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndgOrgId")]
    #endif
    [IsoXmlTag("SndgOrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification7? SendingOrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification7? SendingOrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification7? SendingOrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    [IsoId("_0fDMoAlIEeGATtfOBToyew_-789305067")]
    [DisplayName("User Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrId")]
    #endif
    [IsoXmlTag("UsrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? UserIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UserIdentification { get; init; } 
    #else
    public System.String? UserIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_0fDMoQlIEeGATtfOBToyew_-472606511")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus19Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus19Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus19Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    [IsoId("_0fDMoglIEeGATtfOBToyew_-413581719")]
    [DisplayName("Inferred Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IfrrdMtchgSts")]
    #endif
    [IsoXmlTag("IfrrdMtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus7Choice_? InferredMatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus7Choice_? InferredMatchingStatus { get; init; } 
    #else
    public MatchingStatus7Choice_? InferredMatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_0fDMowlIEeGATtfOBToyew_-910035571")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus7Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus7Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus7Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_0fDMpAlIEeGATtfOBToyew_843943317")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementStatus7Choice_? SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus7Choice_? SettlementStatus { get; init; } 
    #else
    public SettlementStatus7Choice_? SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    [IsoId("_0fDMpQlIEeGATtfOBToyew_-1347368937")]
    [DisplayName("Modification Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModPrcgSts")]
    #endif
    [IsoXmlTag("ModPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationProcessingStatus2Choice_? ModificationProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationProcessingStatus2Choice_? ModificationProcessingStatus { get; init; } 
    #else
    public ModificationProcessingStatus2Choice_? ModificationProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    [IsoId("_0fM9oAlIEeGATtfOBToyew_-792027274")]
    [DisplayName("Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlSts")]
    #endif
    [IsoXmlTag("CxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus20Choice_? CancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus20Choice_? CancellationStatus { get; init; } 
    #else
    public ProcessingStatus20Choice_? CancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status is settled.
    /// </summary>
    [IsoId("_0fM9oQlIEeGATtfOBToyew_1819539191")]
    [DisplayName("Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttld")]
    #endif
    [IsoXmlTag("Sttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryReason1? Settled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryReason1? Settled { get; init; } 
    #else
    public ProprietaryReason1? Settled { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_0fM9oglIEeGATtfOBToyew_363123468")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
