// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LevelOfControl1Choice
{
    /// <summary>
    /// Level of control expressed as a code.
    /// </summary>
    [IsoId("_RhNOECDDEeWPMvNwVtiMsA")]
    [DisplayName("Code")]
    public record Code : LevelOfControl1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the level of control.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LevelOfControl1Code Value { get; init; }
    }
}
