// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a system party.
/// </summary>
[IsoId("_Tz7vAeE8EeWHlNkrP2xqHA")]
[DisplayName("System Party Identification")]
public partial record SystemPartyIdentification6
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party referenced by a request.
    /// </summary>
    [IsoId("_T9AygeE8EeWHlNkrP2xqHA")]
    [DisplayName("Related Party Identification")]
    [IsoXmlTag("RltdPtyId")]
    public required PartyIdentification91 RelatedPartyIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    [IsoId("_T9Ayg-E8EeWHlNkrP2xqHA")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public FinancialInstitutionIdentification12? ResponsiblePartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
