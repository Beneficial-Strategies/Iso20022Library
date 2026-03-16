// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_UXlCQdp-Ed-ak6NoX_4Aeg_-1474168343")]
    [DisplayName("Generated Reason")]
    public record GeneratedReason : Reason1Choice_ { }
}
