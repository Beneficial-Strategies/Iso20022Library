// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LocationFormat1Choice
{
    /// <summary>
    /// Indicates that the location is unknown.
    /// </summary>
    [IsoId("_RXD3mdp-Ed-ak6NoX_4Aeg_33853992")]
    [DisplayName("Location Code")]
    public record LocationCode : LocationFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of date.
        /// </summary>
        [IsoXmlTag("LctnCd")]
        public required PlaceType1Code Value { get; init; }
    }
}
