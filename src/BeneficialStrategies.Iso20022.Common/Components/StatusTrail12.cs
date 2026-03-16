// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status Trail12.
/// </summary>
[IsoId("_xZuHAYcSEe-U27oWwgmhCQ")]
[DisplayName("Status Trail12")]
public partial record StatusTrail12
{
    #nullable enable

    /// <summary>
    /// Cancellation Status.
    /// </summary>
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public ProcessingStatus86Choice_? CancellationStatus { get; init; } 

    /// <summary>
    /// Inferred Matching Status.
    /// </summary>
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus25Choice_? InferredMatchingStatus { get; init; } 

    /// <summary>
    /// Matching Status.
    /// </summary>
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus25Choice_? MatchingStatus { get; init; } 

    /// <summary>
    /// Modification Processing Status.
    /// </summary>
    [DisplayName("Modification Processing Status")]
    [IsoXmlTag("ModPrcgSts")]
    public ModificationProcessingStatus10Choice_? ModificationProcessingStatus { get; init; } 

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus87Choice_? ProcessingStatus { get; init; } 

    /// <summary>
    /// Sending Organisation Identification.
    /// </summary>
    [DisplayName("Sending Organisation Identification")]
    [IsoXmlTag("SndgOrgId")]
    public OrganisationIdentification31? SendingOrganisationIdentification { get; init; } 

    /// <summary>
    /// Settled.
    /// </summary>
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; } 

    /// <summary>
    /// Settlement Status.
    /// </summary>
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus32Choice_? SettlementStatus { get; init; } 

    /// <summary>
    /// Status Date.
    /// </summary>
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public required IsoISODateTime StatusDate { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// User Identification.
    /// </summary>
    [DisplayName("User Identification")]
    [IsoXmlTag("UsrId")]
    public IsoMax35Text? UserIdentification { get; init; } 

    
    #nullable disable
    
}
