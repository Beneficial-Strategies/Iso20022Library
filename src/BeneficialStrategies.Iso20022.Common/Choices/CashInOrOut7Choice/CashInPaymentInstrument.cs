// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut7Choice
{
    /// <summary>
    /// Payment instrument for the cash-in flow.
    /// </summary>
    [IsoId("_3zQJUzbsEead9bDRE_1DAQ")]
    [DisplayName("Cash In Payment Instrument")]
    public record CashInPaymentInstrument : CashInOrOut7Choice_ { }
}
