// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat39Choice
{
    /// <summary>
    /// Date expressed as a calendar date.
    /// </summary>
    [IsoId("_ctmkKZKQEeWHWpTQn1FFVg")]
    [DisplayName("Date")]
    public record Date : DateFormat39Choice_ { }
}
