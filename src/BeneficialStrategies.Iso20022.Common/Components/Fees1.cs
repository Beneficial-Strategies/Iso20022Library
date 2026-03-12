// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_2CKQMYjIEeeqaMoyJI1HbA")]
[DisplayName("Fees")]
public partial record Fees1
{
    #nullable enable
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_2SYdg4jIEeeqaMoyJI1HbA")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("_2ShncYjIEeeqaMoyJI1HbA")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public Fee4? IndividualFee { get; init; } 
    
    
    #nullable disable
    
}
