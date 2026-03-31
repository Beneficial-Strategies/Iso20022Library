// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat64Choice
{
    /// <summary>
    /// Date is expressed using a code.
    /// </summary>
    [IsoId("_TtBUj199Ee262vCSVgjImg")]
    [DisplayName("Date Code")]
    public record DateCode : DateFormat64Choice_ { }
}
