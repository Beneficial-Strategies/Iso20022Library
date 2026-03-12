// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about investment plans issued during previous years.
/// </summary>
[IsoId("_zhY78U7eEeifNrXGwadPmg")]
[DisplayName("Previous Year")]
public partial record PreviousYear4
{
    #nullable enable
    
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_zxwTM07eEeifNrXGwadPmg")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public required PreviousYear1Choice_ PreviousYears { get; init; } 
    
    /// <summary>
    /// Indicates whether the product contains a cash asset for transfer from previous years.
    /// </summary>
    [IsoId("_zxwTNU7eEeifNrXGwadPmg")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    
    
    #nullable disable
    
}
