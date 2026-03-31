// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnerIdentification3Choice
{
    /// <summary>
    /// Identification of the individual person.
    /// </summary>
    [IsoId("_CKjZsZTREemC09f0MxYkRg")]
    [DisplayName("Individual Owner Identification")]
    public record IndividualOwnerIdentification : OwnerIdentification3Choice_ { }
}
