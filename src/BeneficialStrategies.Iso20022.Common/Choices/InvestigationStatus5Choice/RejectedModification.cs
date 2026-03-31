// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus5Choice
{
    /// <summary>
    /// Reason for the rejection of a modification request, in a coded form.
    /// </summary>
    [IsoId("_NRkhpW49EeiU9cctagi5ow")]
    [DisplayName("Rejected Modification")]
    public record RejectedModification : InvestigationStatus5Choice_ { }
}
