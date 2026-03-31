// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData15Choice
{
    /// <summary>
    /// Data on collateral used for the securities lending transaction.
    /// </summary>
    [IsoId("_fMZ5xQAFEeqefbt-QjTNnA")]
    [DisplayName("Securities Lending")]
    public record SecuritiesLending : TransactionCollateralData15Choice_ { }
}
