// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat7Choice
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_Q237pNp-Ed-ak6NoX_4Aeg_1802797297")]
    [DisplayName("Date Code")]
    public record DateCode : DateFormat7Choice_ { }
}
