// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment fund transactions that result in cash movements out of a fund, eg, redemption, switch-out.
/// </summary>
[IsoId("_UwBXetp-Ed-ak6NoX_4Aeg_-853943641")]
[DisplayName("Investment Fund Transaction Out Type")]
public partial record InvestmentFundTransactionOutType1
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction, expressed as a code.
    /// </summary>
    [IsoId("_UwBXe9p-Ed-ak6NoX_4Aeg_-567650955")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required InvestmentFundTransactionOutType4Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of transaction.
    /// </summary>
    [IsoId("_UwKhYNp-Ed-ak6NoX_4Aeg_-567650920")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
