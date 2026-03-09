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
[IsoId("_dsyaDji8Eeydid5dcNPKvg")]
[DisplayName("Status Trail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusTrail11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusTrail11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusTrail11( System.DateTime reqStatusDate )
    {
        StatusDate = reqStatusDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_dsyaEDi8Eeydid5dcNPKvg")]
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
    [IsoId("_dsyaEji8Eeydid5dcNPKvg")]
    [DisplayName("Sending Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndgOrgId")]
    #endif
    [IsoXmlTag("SndgOrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification32? SendingOrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification32? SendingOrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification32? SendingOrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    [IsoId("_dsyaFDi8Eeydid5dcNPKvg")]
    [DisplayName("User Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrId")]
    #endif
    [IsoXmlTag("UsrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? UserIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UserIdentification { get; init; } 
    #else
    public System.String? UserIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_dsyaFji8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus92Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus92Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus92Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    [IsoId("_dsyaGDi8Eeydid5dcNPKvg")]
    [DisplayName("Inferred Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IfrrdMtchgSts")]
    #endif
    [IsoXmlTag("IfrrdMtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus30Choice_? InferredMatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus30Choice_? InferredMatchingStatus { get; init; } 
    #else
    public MatchingStatus30Choice_? InferredMatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_dsyaGji8Eeydid5dcNPKvg")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus30Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus30Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus30Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_dsyaHDi8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementStatus22Choice_? SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus22Choice_? SettlementStatus { get; init; } 
    #else
    public SettlementStatus22Choice_? SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    [IsoId("_dsyaHji8Eeydid5dcNPKvg")]
    [DisplayName("Modification Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModPrcgSts")]
    #endif
    [IsoXmlTag("ModPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationProcessingStatus11Choice_? ModificationProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationProcessingStatus11Choice_? ModificationProcessingStatus { get; init; } 
    #else
    public ModificationProcessingStatus11Choice_? ModificationProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    [IsoId("_dsyaIDi8Eeydid5dcNPKvg")]
    [DisplayName("Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlSts")]
    #endif
    [IsoXmlTag("CxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus93Choice_? CancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus93Choice_? CancellationStatus { get; init; } 
    #else
    public ProcessingStatus93Choice_? CancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status is settled.
    /// </summary>
    [IsoId("_dsyaIji8Eeydid5dcNPKvg")]
    [DisplayName("Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttld")]
    #endif
    [IsoXmlTag("Sttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryReason5? Settled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryReason5? Settled { get; init; } 
    #else
    public ProprietaryReason5? Settled { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_dsyaJDi8Eeydid5dcNPKvg")]
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
