// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionOrError3Choice
{
    /// <summary>
    /// Requested information on the payment transaction.
    /// </summary>
    [IsoId("_NRCCc5lPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction")]
    public partial record Transaction : TransactionOrError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Destination of the payment (be it a member or a system or both).
        /// </summary>
        [IsoId("_NZNuF5lPEee-Zps0fZQaFQ")]
        [DisplayName("Payment To")]
        [IsoXmlTag("PmtTo")]
        public System1? PaymentTo { get; init; } 
        
        /// <summary>
        /// Origin of the payment (be it a member or a system or both).
        /// </summary>
        [IsoId("_NZNuGZlPEee-Zps0fZQaFQ")]
        [DisplayName("Payment From")]
        [IsoXmlTag("PmtFr")]
        public System1? PaymentFrom { get; init; } 
        
        /// <summary>
        /// Indicates whether the payment transaction is a debit or credit transaction. |.
        /// </summary>
        [IsoId("_NZNuG5lPEee-Zps0fZQaFQ")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        
        /// <summary>
        /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
        /// </summary>
        [IsoId("_NZNuHZlPEee-Zps0fZQaFQ")]
        [DisplayName("Payment")]
        [IsoXmlTag("Pmt")]
        public PaymentInstruction26? Payment { get; init; } 
        
        /// <summary>
        /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
        /// </summary>
        [IsoId("_NZNuH5lPEee-Zps0fZQaFQ")]
        [DisplayName("Account Entry")]
        [IsoXmlTag("AcctNtry")]
        public CashAccountAndEntry2? AccountEntry { get; init; } 
        
        /// <summary>
        /// Provides the references of the underlying securities transaction.
        /// </summary>
        [IsoId("_4cW5kJoSEeeGTuCFfgzOFw")]
        [DisplayName("Securities Transaction References")]
        [IsoXmlTag("SctiesTxRefs")]
        public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; init; } 
        
        
        #nullable disable
        
    }
}
