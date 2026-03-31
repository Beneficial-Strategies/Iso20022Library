// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesLendingType3Choice
{
    /// <summary>
    /// Name of the identification scheme, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_MZG3cMkcEeeiAIB1i4AlQw")]
    [DisplayName("Code")]
    public record Code : SecuritiesLendingType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a securities lending contract, as published in an external  type of a securities lending type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSecuritiesLendingType1Code Value { get; init; }
    }
}
