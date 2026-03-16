// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionChannelType1Choice
{
    /// <summary>
    /// Type of transaction channel expressed as a code.
    /// </summary>
    [IsoId("_aT1UIBRGEeOKWo1NF21OVw")]
    [DisplayName("Code")]
    public record Code : TransactionChannelType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of communication channel.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionChannel2Code Value { get; init; }
    }
}
