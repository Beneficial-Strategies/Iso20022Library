// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice
{
    /// <summary>
    /// Parameters to be used by the configuration update command.
    /// </summary>
    [IsoId("_qAYftYtHEeSxlKlAGYErFg")]
    [DisplayName("Required Configuration Parameter")]
    public record RequiredConfigurationParameter : ATMCommandParameters2Choice_
    {
        /// <summary>
        /// Type of the ATM configuration.
        /// </summary>
        [IsoId("_MrLhwIn-EeShMpas3885ww")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required DataSetCategory7Code Type { get; init; }

        /// <summary>
        /// Active version of the configuration.
        /// </summary>
        [IsoId("_TcxKUIn-EeShMpas3885ww")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Version { get; init; }
    }
}
