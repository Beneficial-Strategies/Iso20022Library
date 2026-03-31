// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTradeTransactionType1Choice
{
    /// <summary>
    /// Type of commercial contract.
    /// </summary>
    [IsoId("_93QOxHltEeG7BsjMvd1mEw_-1518978028")]
    [DisplayName("Code")]
    public record Code : UnderlyingTradeTransactionType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external commercial reference type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalUnderlyingTradeTransactionType1Code Value { get; init; }
    }
}
