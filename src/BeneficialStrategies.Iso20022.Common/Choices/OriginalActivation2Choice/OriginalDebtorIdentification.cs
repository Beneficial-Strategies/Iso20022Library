// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalActivation2Choice
{
    /// <summary>
    /// Provides the identification to unambiguously identify the debtor as defined in the original request.
    /// Usage:
    /// This element must be identical to the debtor identification in the original debtor activation request.
    /// </summary>
    [IsoId("_UPBU8eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Debtor Identification")]
    public record OriginalDebtorIdentification : OriginalActivation2Choice_ { }
}
