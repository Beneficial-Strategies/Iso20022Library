// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties36Choice
{
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_WKI1ISqSEeyR9JrVGfaMKw")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public record DeliveringSettlementParties : SettlementParties36Choice_
    {
        /// <summary>
        /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
        /// </summary>
        [IsoId("_UpuLRyqSEeyR9JrVGfaMKw")]
        [DisplayName("Depository")]
        [IsoXmlTag("Dpstry")]
        public required PartyIdentification239Choice_ Depository { get; init; }

        /// <summary>
        /// Party that, in a settlement chain interacts with the depository.
        /// </summary>
        [IsoId("_UpuLSSqSEeyR9JrVGfaMKw")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty1")]
        public required PartyIdentificationAndAccount200 Party1 { get; init; }

        /// <summary>
        /// Party that, in a settlement chain interacts with the party 1.
        /// </summary>
        [IsoId("_UpuLSyqSEeyR9JrVGfaMKw")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty2")]
        public PartyIdentificationAndAccount201? Party2 { get; init; }
    }
}
