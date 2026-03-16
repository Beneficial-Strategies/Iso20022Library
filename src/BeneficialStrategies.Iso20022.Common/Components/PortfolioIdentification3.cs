// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the portfolio if the collateral is reported on a portfolio basis.
/// </summary>
[IsoId("_B0ZF0TIDEe2fXedS_ucFOA")]
[DisplayName("Portfolio Identification")]
public record PortfolioIdentification3
{
    /// <summary>
    /// Unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_B1XWMTIDEe2fXedS_ucFOA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text Code { get; init; }

    /// <summary>
    /// Indicates whether the collateral portfolio includes transactions exempt from reporting.
    /// Usage: If the element is not present, the PortfolioTransactionExemption is False.
    /// </summary>
    [IsoId("_B1X9QTIDEe2fXedS_ucFOA")]
    [DisplayName("Portfolio Transaction Exemption")]
    [IsoXmlTag("PrtflTxXmptn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PortfolioTransactionExemption { get; init; }
}
