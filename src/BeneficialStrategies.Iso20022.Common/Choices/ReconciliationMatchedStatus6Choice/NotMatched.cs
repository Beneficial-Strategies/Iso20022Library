// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReconciliationMatchedStatus6Choice
{
    /// <summary>
    /// Indication that the reports subject of reconciliation do not match.
    /// </summary>
    [IsoId("_C44f8__oEemm3skPVSMJQg")]
    [DisplayName("Not Matched")]
    [IsoXmlTag("NotMtchd")]
    public record NotMatched : ReconciliationMatchedStatus6Choice_
    {
        /// <summary>
        /// First side of the contract that needs to be matched.
        /// </summary>
        [IsoId("_C9D1Uf_oEemm3skPVSMJQg")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty1")]
        public required OrganisationIdentification9Choice_ Counterparty1 { get; init; }

        /// <summary>
        /// Second side of the contract that needs to be matched.
        /// </summary>
        [IsoId("_C9D1U__oEemm3skPVSMJQg")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty2")]
        public required OrganisationIdentification9Choice_ Counterparty2 { get; init; }

        /// <summary>
        /// Criteria used to match the sides of the contract.
        /// </summary>
        [IsoId("_C9D1Vf_oEemm3skPVSMJQg")]
        [DisplayName("Matching Criteria")]
        [IsoXmlTag("MtchgCrit")]
        public required MatchingCriteria7 MatchingCriteria { get; init; }
    }
}
