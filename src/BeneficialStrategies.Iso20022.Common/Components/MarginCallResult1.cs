// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the summation of the call amounts per margin type and optionaly the default fund amount (only for CCP).
/// </summary>
[IsoId("_UlSuJtp-Ed-ak6NoX_4Aeg_740528065")]
[DisplayName("Margin Call Result")]
public partial record MarginCallResult1
{
    #nullable enable
    
    /// <summary>
    /// Total amount required by the clearing member to participate to the default fund.
    /// </summary>
    [IsoId("_UlSuJ9p-Ed-ak6NoX_4Aeg_1920575599")]
    [DisplayName("Default Fund Amount")]
    [IsoXmlTag("DfltFndAmt")]
    public ActiveCurrencyAndAmount? DefaultFundAmount { get; init; } 
    
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [IsoId("_UlSuKNp-Ed-ak6NoX_4Aeg_1522303182")]
    [DisplayName("Margin Call Result")]
    [IsoXmlTag("MrgnCallRslt")]
    public required MarginCallResult1Choice_ MarginCallResult { get; init; } 
    
    
    #nullable disable
    
}
