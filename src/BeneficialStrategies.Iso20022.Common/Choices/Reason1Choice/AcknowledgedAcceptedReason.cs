// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_UXlCQ9p-Ed-ak6NoX_4Aeg_-1428913797")]
    [DisplayName("Acknowledged Accepted Reason")]
    public record AcknowledgedAcceptedReason : Reason1Choice_ { }
}
