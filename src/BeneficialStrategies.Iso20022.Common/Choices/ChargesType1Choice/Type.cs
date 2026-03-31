// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargesType1Choice
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_yW81UBrdEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    public record Type : ChargesType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies charges linked to the conveyance of goods.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required ChargeType8Code Value { get; init; }
    }
}
