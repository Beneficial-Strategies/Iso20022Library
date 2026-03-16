// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification236Choice
{
    /// <summary>
    /// Party is a legal person.
    /// </summary>
    [IsoId("_lqGRMMgoEeuGrNSsxk3B0A")]
    [DisplayName("Legal")]
    public record Legal : PartyIdentification236Choice_ { }
}
