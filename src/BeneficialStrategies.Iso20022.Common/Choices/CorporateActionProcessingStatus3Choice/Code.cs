// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus3Choice
{
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [IsoId("_PMH--QuIEeGnWuuxuI2McQ")]
    [DisplayName("Code")]
    public record Code : CorporateActionProcessingStatus3Choice_ { }
}
