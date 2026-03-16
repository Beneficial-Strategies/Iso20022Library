// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingPartyAndTime22Choice
{
    /// <summary>
    /// Indicates that the contract is intended to be cleared and provides detailes of such clearing.
    /// </summary>
    [IsoId("_mlkJoxZOEe2QNcZTDeoKnQ")]
    [DisplayName("Details")]
    public record Details : ClearingPartyAndTime22Choice_
    {
        /// <summary>
        /// Identifies the central counterparty (CCP) that cleared the transaction.
        /// </summary>
        [IsoId("_vmHkIxZOEe2QNcZTDeoKnQ")]
        [DisplayName("CCP")]
        [IsoXmlTag("CCP")]
        public OrganisationIdentification15Choice_? CCP { get; init; }

        /// <summary>
        /// Time and date when the original derivative was received by the central counterparty for clearing.
        /// </summary>
        [IsoId("_vmHkJRZOEe2QNcZTDeoKnQ")]
        [DisplayName("Clearing Receipt Date Time")]
        [IsoXmlTag("ClrRctDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ClearingReceiptDateTime { get; init; }

        /// <summary>
        /// Time and date when clearing took place.
        /// </summary>
        [IsoId("_vmHkJxZOEe2QNcZTDeoKnQ")]
        [DisplayName("Clearing Date Time")]
        [IsoXmlTag("ClrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ClearingDateTime { get; init; }

        /// <summary>
        /// Unique identifier of each clearing derivative that replaces the original derivative that was submitted for clearing to the central counterparty, other than the identifier for the transaction being reported.
        /// </summary>
        [IsoId("_vmHkKRZOEe2QNcZTDeoKnQ")]
        [DisplayName("Clearing Identifier")]
        [IsoXmlTag("ClrIdr")]
        public UniqueTransactionIdentifier1Choice_? ClearingIdentifier { get; init; }

        /// <summary>
        /// Unique identifier of the original derivative submitted for clearing to the central counterparty that is replaced by the clearing derivative.
        /// </summary>
        [IsoId("_vmHkKxZOEe2QNcZTDeoKnQ")]
        [DisplayName("Original Identifier")]
        [IsoXmlTag("OrgnlIdr")]
        public UniqueTransactionIdentifier1Choice_? OriginalIdentifier { get; init; }

        /// <summary>
        /// Identifies the trade repository to which the original derivative was reported.
        /// </summary>
        [IsoId("_vmHkLRZOEe2QNcZTDeoKnQ")]
        [DisplayName("Original Trade Repository Identifier")]
        [IsoXmlTag("OrgnlTradRpstryIdr")]
        public OrganisationIdentification15Choice_? OriginalTradeRepositoryIdentifier { get; init; }
    }
}
