// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDate19Choice
{
    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_q6augbPwEeelzbgsFa3sqQ")]
    [DisplayName("Date")]
    public record Date : SettlementDate19Choice_ { }
}
