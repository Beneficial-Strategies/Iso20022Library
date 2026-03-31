// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralPortfolioCode5Choice
{
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoPortfolio is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_YxDO0TIDEe2fXedS_ucFOA")]
    [DisplayName("Portfolio")]
    public record Portfolio : CollateralPortfolioCode5Choice_ { }
}
