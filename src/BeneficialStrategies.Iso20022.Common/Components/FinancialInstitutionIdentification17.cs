// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial institution.
/// </summary>
[IsoId("_vEm5sWAYEeiH9-hkDDXUHA")]
[DisplayName("Financial Institution Identification")]
public partial record FinancialInstitutionIdentification17
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the financial institution.
    /// </summary>
    [IsoId("_vVRL4WAYEeiH9-hkDDXUHA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required FinancialInstitutionIdentification10Choice_ Party { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_vVRL42AYEeiH9-hkDDXUHA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    
    #nullable disable
    
}
