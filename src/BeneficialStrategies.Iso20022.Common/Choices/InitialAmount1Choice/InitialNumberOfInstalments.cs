// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InitialAmount1Choice
{
    /// <summary>
    /// Number of pre-paid instalment periods at the time the investment plan is created.
    /// </summary>
    [IsoId("_XuNrcSDaEeWCLu74WLgP4w")]
    [DisplayName("Initial Number Of Instalments")]
    public record InitialNumberOfInstalments : InitialAmount1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("InitlNbOfInstlmts")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
