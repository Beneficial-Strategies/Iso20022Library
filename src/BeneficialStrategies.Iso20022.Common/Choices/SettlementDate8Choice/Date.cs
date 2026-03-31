// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDate8Choice
{
    /// <summary>
    /// Numeric representation of the day of the month and year.
    /// </summary>
    [IsoId("_AcsYg9okEeC60axPepSq7g_-1449291241")]
    [DisplayName("Date")]
    public record Date : SettlementDate8Choice_ { }
}
