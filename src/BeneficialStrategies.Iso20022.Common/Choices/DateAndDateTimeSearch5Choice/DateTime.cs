// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTimeSearch5Choice
{
    /// <summary>
    /// Specified date and time.
    /// </summary>
    [IsoId("_VptEkzp9EemwKdP955WBJQ")]
    [DisplayName("Date Time")]
    public record DateTime : DateAndDateTimeSearch5Choice_ { }
}
