// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementParties35Choice
{
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_TgtUwyqSEeyR9JrVGfaMKw")]
    [DisplayName("Receiving Settlement Parties")]
    public partial record ReceivingSettlementParties : SettlementParties35Choice_
    {
        #nullable enable
        
        /// <summary>
        /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
        /// </summary>
        [IsoId("_T4ZcBSqSEeyR9JrVGfaMKw")]
        [DisplayName("Depository")]
        [IsoXmlTag("Dpstry")]
        public required PartyIdentification239Choice_ Depository { get; init; } 
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the depository.
        /// </summary>
        [IsoId("_T4ZcByqSEeyR9JrVGfaMKw")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty1")]
        public required PartyIdentificationAndAccount200 Party1 { get; init; } 
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the party 1.
        /// </summary>
        [IsoId("_T4ZcCSqSEeyR9JrVGfaMKw")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty2")]
        public PartyIdentificationAndAccount201? Party2 { get; init; } 
        
        
        #nullable disable
        
    }
}
