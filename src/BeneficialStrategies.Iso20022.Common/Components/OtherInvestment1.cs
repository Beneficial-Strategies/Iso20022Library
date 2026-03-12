// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment that is not characterised by any other financial instrument provided.
/// </summary>
[IsoId("_OWQacLLnEeavNMum-T1eEA")]
[DisplayName("Other Investment")]
public partial record OtherInvestment1
{
    #nullable enable
    
    /// <summary>
    /// Text description of the investment.
    /// </summary>
    [IsoId("_YaCMgLLnEeavNMum-T1eEA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Description { get; init; } 
    
    /// <summary>
    /// Value of the other investment.
    /// </summary>
    [IsoId("_b8JBULLnEeavNMum-T1eEA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
