// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionOrError5Choice
{
    /// <summary>
    /// Requested information on the payment transaction.
    /// </summary>
    [IsoId("_dnujsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction")]
    public partial record Transaction : TransactionOrError5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Destination of the payment (be it a member or a system or both).
        /// </summary>
        [IsoId("_dqPFJdcZEeqRFcf2R4bPBw")]
        [DisplayName("Payment To")]
        [IsoXmlTag("PmtTo")]
        public System2? PaymentTo { get; init; } 
        
        /// <summary>
        /// Origin of the payment (be it a member or a system or both).
        /// </summary>
        [IsoId("_dqPFJ9cZEeqRFcf2R4bPBw")]
        [DisplayName("Payment From")]
        [IsoXmlTag("PmtFr")]
        public System2? PaymentFrom { get; init; } 
        
        /// <summary>
        /// Indicates whether the payment transaction is a debit or credit transaction. |.
        /// </summary>
        [IsoId("_dqPFKdcZEeqRFcf2R4bPBw")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public CreditDebitCode? CreditDebitIndicator { get; init; } 
        
        /// <summary>
        /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.
        /// </summary>
        [IsoId("_dqPFK9cZEeqRFcf2R4bPBw")]
        [DisplayName("Payment")]
        [IsoXmlTag("Pmt")]
        public PaymentInstruction32? Payment { get; init; } 
        
        /// <summary>
        /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
        /// </summary>
        [IsoId("_dqPFLdcZEeqRFcf2R4bPBw")]
        [DisplayName("Account Entry")]
        [IsoXmlTag("AcctNtry")]
        public CashAccountAndEntry4? AccountEntry { get; init; } 
        
        /// <summary>
        /// Provides the references of the underlying securities transaction.
        /// </summary>
        [IsoId("_dqPFL9cZEeqRFcf2R4bPBw")]
        [DisplayName("Securities Transaction References")]
        [IsoXmlTag("SctiesTxRefs")]
        public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; init; } 
        
        
        #nullable disable
        
    }
}
