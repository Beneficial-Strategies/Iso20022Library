// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason17Choice
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_8Qc12ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Generated Reason")]
    public record GeneratedReason : Reason17Choice_ { }
}
