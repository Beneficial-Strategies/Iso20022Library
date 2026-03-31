// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_UVDSudp-Ed-ak6NoX_4Aeg_-136649163")]
    [DisplayName("Settlement Status")]
    public record SettlementStatus : Status1Choice_ { }
}
