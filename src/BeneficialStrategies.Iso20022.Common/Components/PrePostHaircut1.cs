// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of collateral calculated pre-haircut and/or post-haircut.
/// </summary>
[IsoId("_SUuMwFfVEeqqKf65rDYWYw")]
[DisplayName("Pre Post Haircut")]
public partial record PrePostHaircut1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the amount of collateral calculated pre-haircut.
    /// </summary>
    [IsoId("_ikXEIFfVEeqqKf65rDYWYw")]
    [DisplayName("Pre Haircut")]
    [IsoXmlTag("PreHrcut")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PreHaircut { get; init; } 
    
    /// <summary>
    /// Indicates the amount of collateral calculated post-haircut.
    /// </summary>
    [IsoId("_j8ulQFfVEeqqKf65rDYWYw")]
    [DisplayName("Post Haircut")]
    [IsoXmlTag("PstHrcut")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PostHaircut { get; init; } 
    
    
    #nullable disable
    
}
