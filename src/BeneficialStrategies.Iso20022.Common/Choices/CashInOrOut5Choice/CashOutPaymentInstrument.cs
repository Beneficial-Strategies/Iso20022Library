// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut5Choice
{
    /// <summary>
    /// Payment instrument for the cash-out flow.
    /// </summary>
    [IsoId("_SBq61Np-Ed-ak6NoX_4Aeg_1170441476")]
    [DisplayName("Cash Out Payment Instrument")]
    public record CashOutPaymentInstrument : CashInOrOut5Choice_ { }
}
