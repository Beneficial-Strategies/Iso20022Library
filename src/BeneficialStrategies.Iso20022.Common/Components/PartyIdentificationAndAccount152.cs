// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_DXYlkZEbEeakHoV5BVecAQ")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount152
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_DnKG8ZEbEeakHoV5BVecAQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification245Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_DnKG85EbEeakHoV5BVecAQ")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [IsoId("_DnKG9ZEbEeakHoV5BVecAQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_DnKG95EbEeakHoV5BVecAQ")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification10? AlternateIdentification { get; init; } 
    
    
    #nullable disable
    
}
