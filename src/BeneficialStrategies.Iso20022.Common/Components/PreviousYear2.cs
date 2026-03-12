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
[IsoId("_3gNXVEXfEeGY6MkiuzuPOA_-2106668594")]
[DisplayName("Previous Year")]
public partial record PreviousYear2
{
    #nullable enable
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_3gXIUUXfEeGY6MkiuzuPOA_1869042413")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public required PreviousYear1Choice_ PreviousYears { get; init; } 
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_3gXIUEXfEeGY6MkiuzuPOA_194153996")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    
    #nullable disable
    
}
