// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat7Choice
{
    /// <summary>
    /// Date expressed as a calendar date.
    /// </summary>
    [IsoId("_Q237otp-Ed-ak6NoX_4Aeg_-834882492")]
    [DisplayName("Date")]
    public record Date : DateFormat7Choice_ { }
}
