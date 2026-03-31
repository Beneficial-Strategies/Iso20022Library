// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides status information related to a instruction cancellation request completed.
    /// </summary>
    [IsoId("_QyGwY9p-Ed-ak6NoX_4Aeg_-1849748181")]
    [DisplayName("Cancellation Completed")]
    public record CancellationCompleted : InstructionCancellationRequestStatus1Choice_ { }
}
