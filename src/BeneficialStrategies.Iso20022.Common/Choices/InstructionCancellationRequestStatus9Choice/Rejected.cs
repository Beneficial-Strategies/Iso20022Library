// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus9Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.
    /// </summary>
    [IsoId("_8rhp80GWEeWqy4niLuXETA")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionCancellationRequestStatus9Choice_ { }
}
