// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the status being requested.
/// </summary>
[IsoId("_D2Ul8fJlEd-DocZblYEqZw")]
[DisplayName("Document Number")]
public partial record DocumentNumber6
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_D2Ul8_JlEd-DocZblYEqZw")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber1Choice_ Number { get; init; } 
    
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_D2Ul9fJlEd-DocZblYEqZw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<Identification7> References { get; init; } = new ValueList<Identification7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _D2Ul9fJlEd-DocZblYEqZw
    
    
    #nullable disable
    
}
