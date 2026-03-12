// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_AO07o9okEeC60axPepSq7g_-859713029")]
[DisplayName("Party Identification")]
public partial record PartyIdentification55
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_AO07pNokEeC60axPepSq7g_-973552095")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification68Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_AO07pdokEeC60axPepSq7g_-2034904054")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_AO07ptokEeC60axPepSq7g_-731153817")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
