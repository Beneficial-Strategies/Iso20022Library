// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementFailsDailyCSD1Choice
{
    /// <summary>
    /// Aggregated data of settlement instructions.
    /// </summary>
    [IsoId("_Umrp4zOaEeqBfed1bmSPqg")]
    [DisplayName("Data")]
    public record Data : SettlementFailsDailyCSD1Choice_
    {
        /// <summary>
        /// Intra-CSD settlement instructions data.
        /// </summary>
        [IsoId("_MUG5QTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Intra CSD")]
        [IsoXmlTag("IntraCSD")]
        public required SettlementFailsDailyInstructionType1Choice_ IntraCSD { get; init; }

        /// <summary>
        /// Cross-CSD settlement instructions data.
        /// </summary>
        [IsoId("_MUG5QzOmEeqX8uoQQ3KffQ")]
        [DisplayName("Cross CSD")]
        [IsoXmlTag("CrossCSD")]
        public required SettlementFailsDailyInstructionType1Choice_ CrossCSD { get; init; }
    }
}
