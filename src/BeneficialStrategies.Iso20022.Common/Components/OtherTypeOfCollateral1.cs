// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Allows to specify other collateral type by providing a description and the amount.
/// </summary>
[IsoId("_Um7s4Np-Ed-ak6NoX_4Aeg_-342642286")]
[DisplayName("Other Type Of Collateral")]
public partial record OtherTypeOfCollateral1
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the collateral.
    /// </summary>
    [IsoId("_Um7s4dp-Ed-ak6NoX_4Aeg_2125593373")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Description { get; init; } 
    
    /// <summary>
    /// Amount of the other collateral.
    /// </summary>
    [IsoId("_Um7s4tp-Ed-ak6NoX_4Aeg_1909287542")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
