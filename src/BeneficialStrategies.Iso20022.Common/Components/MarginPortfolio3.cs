// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the unique codes.
/// </summary>
[IsoId("_tm21gTICEe2fXedS_ucFOA")]
[DisplayName("Margin Portfolio")]
public partial record MarginPortfolio3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_tnypoTICEe2fXedS_ucFOA")]
    [DisplayName("Initial Margin Portfolio Code")]
    [IsoXmlTag("InitlMrgnPrtflCd")]
    public required PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_tnypozICEe2fXedS_ucFOA")]
    [DisplayName("Variation Margin Portfolio Code")]
    [IsoXmlTag("VartnMrgnPrtflCd")]
    public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; init; } 
    
    
    #nullable disable
    
}
