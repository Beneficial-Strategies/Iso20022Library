// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify an organization or a person.
/// </summary>
[IsoId("_T9ZTo1msEeOQYsoJizpkVw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification72
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_TZ36YFmtEeOQYsoJizpkVw")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification43 PartyIdentification { get; init; } 
    
    /// <summary>
    /// Identifier and name of an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_vESPoJDzEeSZY4BVJy2t3A")]
    [DisplayName("Legal Organisation")]
    [IsoXmlTag("LglOrg")]
    public LegalOrganisation1? LegalOrganisation { get; init; } 
    
    /// <summary>
    /// Tax registration details.
    /// </summary>
    [IsoId("_Y5uOQFmtEeOQYsoJizpkVw")]
    [DisplayName("Tax Party")]
    [IsoXmlTag("TaxPty")]
    public TaxParty1? TaxParty { get; init; } 
    
    
    #nullable disable
    
}
