// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat15Choice
{
    /// <summary>
    /// Date is expressed using a code.
    /// </summary>
    [IsoId("_QmL0Qtp-Ed-ak6NoX_4Aeg_1184238779")]
    [DisplayName("Date Code")]
    public record DateCode : DateFormat15Choice_ { }
}
