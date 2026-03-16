// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature15Choice
{
    /// <summary>
    /// Indicates that counterparty is a non financial institution.
    /// </summary>
    [IsoId("_1z1A8wz1Ee2YoLD-1vFj0g")]
    [DisplayName("Non Financial Institution")]
    public record NonFinancialInstitution : CounterpartyTradeNature15Choice_
    {
        /// <summary>
        /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
        /// </summary>
        [IsoId("_ygiOwQz2Ee2YoLD-1vFj0g")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        public ValueList<GenericIdentification175> Sector { get; init; } = [];

        // ID for the above is _ygiOwQz2Ee2YoLD-1vFj0g

        /// <summary>
        /// Information whether the counterparty is above the clearing threshold.
        /// Usage: If the element is not present, the ClearingThreshold is False.
        /// </summary>
        [IsoId("_ygiOxQz2Ee2YoLD-1vFj0g")]
        [DisplayName("Clearing Threshold")]
        [IsoXmlTag("ClrThrshld")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? ClearingThreshold { get; init; }

        /// <summary>
        /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the counterparty&apos;s commercial or treasury financing activity.
        /// Usage: If the element is not present, the DirectlyLinkedActivity is False.
        /// </summary>
        [IsoId("_ygiOxwz2Ee2YoLD-1vFj0g")]
        [DisplayName("Directly Linked Activity")]
        [IsoXmlTag("DrctlyLkdActvty")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? DirectlyLinkedActivity { get; init; }

        /// <summary>
        /// Indicates whether the counterparty is an entity established pursuant to federal law like for example a federal authority or a government corporation.
        /// Usage: If the element is not present, the FederalInstitution is False.
        /// </summary>
        [IsoId("_2Oz3UAz2Ee2YoLD-1vFj0g")]
        [DisplayName("Federal Institution")]
        [IsoXmlTag("FdrlInstn")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? FederalInstitution { get; init; }
    }
}
