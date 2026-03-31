// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDataRate1Choice
{
    /// <summary>
    /// Specifies the rate of settlement fails, based either on the number of settlement instructions or on the value of settlement instructions, is lower than the ceiling rate as specified in the local regulation.
    /// </summary>
    [IsoId("_yFQMBMs0EemSav3hRKzWyg")]
    [DisplayName("Number Of Instructions")]
    public record NumberOfInstructions : SettlementDataRate1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
        /// </summary>
        [IsoXmlTag("NbOfInstrs")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; }
    }
}
