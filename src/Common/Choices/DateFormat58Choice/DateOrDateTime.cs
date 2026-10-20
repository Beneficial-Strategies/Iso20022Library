// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat58Choice
{
    /// <summary>
    /// Date expressed as a calendar date.
    /// </summary>
    [IsoId("_k8fcsa09EemDtrWpq90Ckg")]
    [DisplayName("Date Or Date Time")]
    public partial record DateOrDateTime : DateFormat58Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtOrDtTm")]
        public required DateAndDateTime2Choice_ Value { get; init; }
    }
}
