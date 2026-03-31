// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentIdentification5Choice
{
    /// <summary>
    /// Instrument consists of single instrument.
    /// </summary>
    [IsoId("_HQWTwX5aEea2k7EBUopqxw")]
    [DisplayName("Single")]
    public record Single : FinancialInstrumentIdentification5Choice_ { }
}
