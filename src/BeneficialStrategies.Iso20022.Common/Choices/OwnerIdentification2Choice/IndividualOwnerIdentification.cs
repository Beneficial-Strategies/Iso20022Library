// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnerIdentification2Choice
{
    /// <summary>
    /// Identification of the individual person.
    /// </summary>
    [IsoId("_FJYQgSGZEeWKAaDJcYGKLw")]
    [DisplayName("Individual Owner Identification")]
    public record IndividualOwnerIdentification : OwnerIdentification2Choice_ { }
}
