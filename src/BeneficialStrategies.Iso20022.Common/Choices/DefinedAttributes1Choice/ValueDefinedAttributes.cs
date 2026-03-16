// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DefinedAttributes1Choice
{
    /// <summary>
    /// Value defined attributes for derivatives where the terms of the contract define the value of payable per unit of a move in some published index. This includes the floating leg of interest rate swaps which implicitly are payments proportional to the change in the index.
    /// </summary>
    [IsoId("__F7tMePJEea7_eMQH225xA")]
    [DisplayName("Value Defined Attributes")]
    [IsoXmlTag("ValDfndAttrbts")]
    public record ValueDefinedAttributes : DefinedAttributes1Choice_
    {
        /// <summary>
        /// Reference notional amount of the contract.
        /// </summary>
        [IsoId("_jjd08chlEeadgvwNGwK05w")]
        [DisplayName("Notional")]
        [IsoXmlTag("Ntnl")]
        public ActiveCurrencyAndAmount? Notional { get; init; }

        /// <summary>
        /// Value of unit move in index if fixed in contract terms, and currency of payments relating to changes in the amount of the underlying.
        /// </summary>
        [IsoId("_jjd088hlEeadgvwNGwK05w")]
        [DisplayName("Unit Value")]
        [IsoXmlTag("UnitVal")]
        public required ActiveCurrencyAndAmount UnitValue { get; init; }

        /// <summary>
        /// Unique identifier for underlying index on which final settlement price or periodic payments are calculated.
        /// </summary>
        [IsoId("_jjd09chlEeadgvwNGwK05w")]
        [DisplayName("Index Identification")]
        [IsoXmlTag("IndxId")]
        public required GenericIdentification168 IndexIdentification { get; init; }

        /// <summary>
        /// Unit index, typically ‘Points’, or for interest rate and CDS products, ‘Bps’.
        /// </summary>
        [IsoId("_HF0BMMhoEeadgvwNGwK05w")]
        [DisplayName("Index Unit")]
        [IsoXmlTag("IndxUnit")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text IndexUnit { get; init; }

        /// <summary>
        /// Day count convention for interest payments. Interest rate products only.
        /// </summary>
        [IsoId("_NMr40MhoEeadgvwNGwK05w")]
        [DisplayName("Interest Rate Terms")]
        [IsoXmlTag("IntrstRateTerms")]
        public InterestComputationMethod2Code? InterestRateTerms { get; init; }
    }
}
