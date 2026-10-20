// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat34Choice
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_cdSQa5KQEeWHWpTQn1FFVg")]
    [DisplayName("Date Code")]
    public partial record DateCode : DateFormat34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtCd")]
        public required DateCode22Choice_ Value { get; init; }
    }
}
