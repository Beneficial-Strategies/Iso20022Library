// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NameOrSector1Choice
{
    /// <summary>
    /// Represents the counterparty institutional section (such as non-financial corporation, central bank.).
    /// </summary>
    [IsoId("_6URv4YInEeWA9fc11zJf1Q")]
    [DisplayName("Sector")]
    public record Sector : NameOrSector1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// System of National Accounts (SNA) Sector. Hierarchical classification of the sectors, as defined in the System of National Accounts 2008, as published by the United Nations.
        /// </summary>
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        public required IsoSNA2008SectorIdentifier Value { get; init; }
    }
}
