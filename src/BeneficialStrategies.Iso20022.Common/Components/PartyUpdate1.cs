// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes of the party, which are / are being updated.
/// </summary>
[IsoId("_oZdVsPH1Eeaz_YGUGLjP6A")]
[DisplayName("Party Update")]
public partial record PartyUpdate1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    [IsoId("_3j8_ITbvEeeYhaZ6bvG1Xg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_7OkLIPmjEeak-cGuSQTPwg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification136 Identification { get; init; } 
    
    /// <summary>
    /// Unique identification of the party, as previously defined.
    /// </summary>
    [IsoId("_pemdMEn3EeexwKvkdw4OGA")]
    [DisplayName("Previous Identification")]
    [IsoXmlTag("PrvsId")]
    public PartyIdentification136? PreviousIdentification { get; init; } 
    
    /// <summary>
    /// Any other additional information about the party.
    /// </summary>
    [IsoId("_a3_3AvmkEeak-cGuSQTPwg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public required PartyDetail1 Other { get; init; } 
    
    /// <summary>
    /// Information about decision taken by a relevant institution concerning the party.
    /// </summary>
    [IsoId("_IffBgPH3Eeaz_YGUGLjP6A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<StatusDetail1> Status { get; init; } = [];
    // ID for the above is _IffBgPH3Eeaz_YGUGLjP6A
    
    /// <summary>
    /// Period of time when the associated record is technically valid.
    /// </summary>
    [IsoId("_BoOKUTb5EeeYhaZ6bvG1Xg")]
    [DisplayName("Technical Validity Period")]
    [IsoXmlTag("TechVldtyPrd")]
    public Period4Choice_? TechnicalValidityPeriod { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_5O9IYTbvEeeYhaZ6bvG1Xg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
