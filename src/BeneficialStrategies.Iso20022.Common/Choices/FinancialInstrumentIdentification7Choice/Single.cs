// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification7Choice
{
    /// <summary>
    /// Instrument consists of single instrument.
    /// </summary>
    [IsoId("_LHTy0YG-EeaalK9UbuVGFw")]
    [DisplayName("Single")]
    public record Single : FinancialInstrumentIdentification7Choice_ { }
}
