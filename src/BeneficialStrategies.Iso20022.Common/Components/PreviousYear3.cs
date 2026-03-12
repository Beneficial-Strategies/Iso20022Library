// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
/// </summary>
[IsoId("_jl0BAEj2EeG0Lek-7i1x-A_1558311877")]
[DisplayName("Previous Year")]
public partial record PreviousYear3
{
    #nullable enable
    
    /// <summary>
    /// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
    /// </summary>
    [IsoId("_jl0BAUj2EeG0Lek-7i1x-A_-1651304524")]
    [DisplayName("Previous Year")]
    [IsoXmlTag("PrvsYr")]
    public required PreviousYear1Choice_ PreviousYear { get; init; } 
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_jl9yAEj2EeG0Lek-7i1x-A_982439671")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    
    #nullable disable
    
}
