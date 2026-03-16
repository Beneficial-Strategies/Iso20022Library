// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat47Choice
{
    /// <summary>
    /// Date expressed as an ISO Date.
    /// </summary>
    [IsoId("_Hnn64ckbEee7W-rN1yqPMg")]
    [DisplayName("Date")]
    public record Date : DateFormat47Choice_ { }
}
