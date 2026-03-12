// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summation of the call amounts either due to A or due to B.
/// </summary>
[IsoId("_UlvaEtp-Ed-ak6NoX_4Aeg_1884281908")]
[DisplayName("Result")]
public partial record Result1
{
    #nullable enable
    
    /// <summary>
    /// Amount payable by party B to party A.
    /// </summary>
    [IsoId("_UlvaE9p-Ed-ak6NoX_4Aeg_-97807248")]
    [DisplayName("Due To Party A")]
    [IsoXmlTag("DueToPtyA")]
    public ActiveCurrencyAndAmount? DueToPartyA { get; init; } 
    
    /// <summary>
    /// Amount payable by party A to party B.
    /// </summary>
    [IsoId("_UlvaFNp-Ed-ak6NoX_4Aeg_-1435615045")]
    [DisplayName("Due To Party B")]
    [IsoXmlTag("DueToPtyB")]
    public ActiveCurrencyAndAmount? DueToPartyB { get; init; } 
    
    /// <summary>
    /// Provides additional information related to the collateral that may be requested.
    /// </summary>
    [IsoId("_UlvaFdp-Ed-ak6NoX_4Aeg_903687993")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
