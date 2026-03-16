// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat3Choice
{
    /// <summary>
    /// Indicates that date is unknown.
    /// </summary>
    [IsoId("_RVtzwdp-Ed-ak6NoX_4Aeg_1324481735")]
    [DisplayName("Date Code")]
    public record DateCode : DateFormat3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is unknown.
        /// </summary>
        [IsoXmlTag("DtCd")]
        public required DateType1Code Value { get; init; }
    }
}
