// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TerminationDate2Choice
{
    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_QurB4tp-Ed-ak6NoX_4Aeg_1846150555")]
    [DisplayName("Date")]
    public record Date : TerminationDate2Choice_ { }
}
