// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status39Choice
{
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_gEIFfDi8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Status")]
    public record SettlementStatus : Status39Choice_ { }
}
