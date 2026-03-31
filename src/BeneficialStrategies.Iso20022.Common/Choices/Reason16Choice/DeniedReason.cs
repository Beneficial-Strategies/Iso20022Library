// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason16Choice
{
    /// <summary>
    /// Specifies the reason why the request was denied.
    /// </summary>
    [IsoId("_kYkAeznvEeWfSKvvZlhRKg")]
    [DisplayName("Denied Reason")]
    public record DeniedReason : Reason16Choice_ { }
}
