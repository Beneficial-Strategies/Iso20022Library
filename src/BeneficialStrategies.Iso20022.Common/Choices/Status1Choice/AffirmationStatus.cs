// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_UU5htNp-Ed-ak6NoX_4Aeg_1993451566")]
    [DisplayName("Affirmation Status")]
    public record AffirmationStatus : Status1Choice_ { }
}
