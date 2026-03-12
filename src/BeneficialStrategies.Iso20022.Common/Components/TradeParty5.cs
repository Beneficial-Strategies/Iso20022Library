// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an entity involved in a trade activity.
/// </summary>
[IsoId("_EjORi249EeiU9cctagi5ow")]
[DisplayName("Trade Party")]
public partial record TradeParty5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_ExO4QW49EeiU9cctagi5ow")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification135 PartyIdentification { get; init; } 
    
    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    [IsoId("_ExO4Q249EeiU9cctagi5ow")]
    [DisplayName("Legal Organisation")]
    [IsoXmlTag("LglOrg")]
    public LegalOrganisation2? LegalOrganisation { get; init; } 
    
    /// <summary>
    /// Further tax details of an entity involved in an activity which is subject to taxation.
    /// </summary>
    [IsoId("_ExO4RW49EeiU9cctagi5ow")]
    [DisplayName("Tax Party")]
    [IsoXmlTag("TaxPty")]
    public TaxParty4? TaxParty { get; init; } 
    
    
    #nullable disable
    
}
