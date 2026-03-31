// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus1Choice
{
    /// <summary>
    /// Instruction/Request is accepted but in repair.
    /// </summary>
    [IsoId("_UW_MYdp-Ed-ak6NoX_4Aeg_-1491508132")]
    [DisplayName("Repair")]
    public record Repair : IntraPositionProcessingStatus1Choice_ { }
}
