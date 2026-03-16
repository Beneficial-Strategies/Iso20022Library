// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus1Choice
{
    /// <summary>
    /// Provides status information related to an instruction request accepted for further processing.
    /// </summary>
    [IsoId("_Qy_hMdp-Ed-ak6NoX_4Aeg_1677583360")]
    [DisplayName("Accepted")]
    public record Accepted : InstructionProcessingStatus1Choice_ { }
}
