// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes for the cancellation of the party.
/// </summary>
[IsoId("_mI_kIDbvEeeYhaZ6bvG1Xg")]
[DisplayName("Party Cancellation")]
public partial record PartyCancellation1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    [IsoId("_Ng-FgTbvEeeYhaZ6bvG1Xg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the party to be cancelled.
    /// </summary>
    [IsoId("_AH5WITbwEeeYhaZ6bvG1Xg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification136 Identification { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_zOVpwTbvEeeYhaZ6bvG1Xg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
