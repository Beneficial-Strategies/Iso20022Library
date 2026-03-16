// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationResult1Choice
{
    /// <summary>
    /// Provides the result.
    /// </summary>
    [IsoId("_X3RjXGgkEeGHuf0_3c6vdw")]
    [DisplayName("Result")]
    public record Result : InvestigationResult1Choice_ { }
}
