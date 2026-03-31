// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnerIdentification1Choice
{
    /// <summary>
    /// Identification of an individual person.
    /// </summary>
    [IsoId("_qe1hwggrEeSqp5OpJ0aMmw")]
    [DisplayName("Individual Owner Identification")]
    public record IndividualOwnerIdentification : OwnerIdentification1Choice_ { }
}
