// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat57Choice
{
    /// <summary>
    /// Date is expressed using a code.
    /// </summary>
    [IsoId("_zBT-BD5-EemPvNTzinB5Vw")]
    [DisplayName("Date Code")]
    public record DateCode : DateFormat57Choice_ { }
}
