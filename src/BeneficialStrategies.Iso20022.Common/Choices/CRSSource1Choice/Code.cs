// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CRSSource1Choice
{
    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status expressed as a code.
    /// </summary>
    [IsoId("_J3oBAUNfEeamLdeYEZm56w")]
    [DisplayName("Code")]
    public record Code : CRSSource1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the source of Common Reporting Standard (CRS) status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CRSSourceStatus1Code Value { get; init; }
    }
}
