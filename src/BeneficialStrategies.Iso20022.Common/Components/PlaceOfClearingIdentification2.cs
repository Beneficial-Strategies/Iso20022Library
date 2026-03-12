// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
/// </summary>
[IsoId("_FkYpQdXUEeiN28wlpBQScw")]
[DisplayName("Place Of Clearing Identification")]
public partial record PlaceOfClearingIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the place of clearing.
    /// </summary>
    [IsoId("_F1pYYdXUEeiN28wlpBQScw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? Identification { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a place of clearing.
    /// </summary>
    [IsoId("_F1pYY9XUEeiN28wlpBQScw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    
    #nullable disable
    
}
