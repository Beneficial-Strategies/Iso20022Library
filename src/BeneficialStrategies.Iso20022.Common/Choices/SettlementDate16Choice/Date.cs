// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDate16Choice
{
    /// <summary>
    /// Numeric representation of the day of the month and year.
    /// </summary>
    [IsoId("_GxX0s5BhEeakHoV5BVecAQ")]
    [DisplayName("Date")]
    public record Date : SettlementDate16Choice_ { }
}
