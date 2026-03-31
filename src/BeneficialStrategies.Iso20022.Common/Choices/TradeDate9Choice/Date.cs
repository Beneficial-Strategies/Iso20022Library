// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate9Choice
{
    /// <summary>
    /// Date expressed as an ISO date.
    /// </summary>
    [IsoId("_qImeC83yEee5nJBZsW8MFQ")]
    [DisplayName("Date")]
    public record Date : TradeDate9Choice_ { }
}
