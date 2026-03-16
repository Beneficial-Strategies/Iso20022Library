// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralAccountIdentificationType2Choice
{
    /// <summary>
    /// Indicates the type of collateral account expressed as a code.
    /// </summary>
    [IsoId("_ZUDu8YFxEeWtPe6Crjmeug")]
    [DisplayName("Type")]
    public record Type : CollateralAccountIdentificationType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the collateral account type.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required CollateralAccountType1Code Value { get; init; }
    }
}
