// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityOrOperationalError4Choice
{
    /// <summary>
    /// Provides the financial instruments details or the business error.
    /// </summary>
    [IsoId("_P5yGsZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Report Or Business Error")]
    public record SecurityReportOrBusinessError : SecurityOrOperationalError4Choice_ { }
}
