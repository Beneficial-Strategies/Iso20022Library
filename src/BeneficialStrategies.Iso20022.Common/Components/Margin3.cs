// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the calculation of the margin.
/// </summary>
[IsoId("_-eMvBKMOEeCojJW5vEuTEQ_631064077")]
[DisplayName("Margin")]
public partial record Margin3
{
    #nullable enable
    
    /// <summary>
    /// Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.
    /// </summary>
    [IsoId("_-eMvBaMOEeCojJW5vEuTEQ_937741961")]
    [DisplayName("Initial Margin")]
    [IsoXmlTag("InitlMrgn")]
    public Amount2? InitialMargin { get; init; } 
    
    /// <summary>
    /// Provides details on the calculation of the variation margin.
    /// </summary>
    [IsoId("_-eMvBqMOEeCojJW5vEuTEQ_2054797146")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public VariationMargin3? VariationMargin { get; init; } 
    
    /// <summary>
    /// Provides details on the margin type and amount.
    /// </summary>
    [IsoId("_-eMvB6MOEeCojJW5vEuTEQ_-399143130")]
    [DisplayName("Other Margin")]
    [IsoXmlTag("OthrMrgn")]
    public Margin4? OtherMargin { get; init; } 
    
    
    #nullable disable
    
}
