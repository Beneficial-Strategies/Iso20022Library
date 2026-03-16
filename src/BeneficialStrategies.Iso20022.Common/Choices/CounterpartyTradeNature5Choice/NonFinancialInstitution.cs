// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature5Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_97ZDE7sAEea-m5tPqiasmQ")]
    [DisplayName("Non Financial Institution")]
    public record NonFinancialInstitution : CounterpartyTradeNature5Choice_
    {
        /// <summary>
        /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
        /// </summary>
        [IsoId("_Q2aJAcDyEeW6TPUXKSV6dQ")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
        public IsoNACEDomainIdentifier? Sector { get; init; }

        /// <summary>
        /// Information whether the reporting counterparty is above the clearing threshold.
        /// </summary>
        [IsoId("_Q2aJBcDyEeW6TPUXKSV6dQ")]
        [DisplayName("Clearing Threshold")]
        [IsoXmlTag("ClrThrshld")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? ClearingThreshold { get; init; }

        /// <summary>
        /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the reporting counterparty&apos;s commercial or treasury financing activity.
        /// </summary>
        [IsoId("_Q2aJB8DyEeW6TPUXKSV6dQ")]
        [DisplayName("Directly Linked Activity")]
        [IsoXmlTag("DrctlyLkdActvty")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? DirectlyLinkedActivity { get; init; }
    }
}
