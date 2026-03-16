// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BusinessProcessType2Choice
{
    /// <summary>
    /// Business process type is identified using a code.
    /// </summary>
    [IsoId("_0w-KU5BgEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : BusinessProcessType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of business process model used to carry out the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BusinessProcessType1Code Value { get; init; }
    }
}
