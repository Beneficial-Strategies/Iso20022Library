// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction1Choice
{
    /// <summary>
    /// Completed card payment transaction to be captured.
    /// </summary>
    [IsoId("_yNBpIC8QEeKW5usMQLtzqw")]
    [DisplayName("Completion")]
    public partial record Completion : CardPaymentDataSetTransaction1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_W7eJ4QvZEeKzJ69IWwzB9Q")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
        
        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_W7eJ5QvZEeKzJ69IWwzB9Q")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability1? Traceability { get; init; } 
        
        /// <summary>
        /// Data related to the environment of the transaction in a transaction captured in batch.
        /// </summary>
        [IsoId("_W7eJ6QvZEeKzJ69IWwzB9Q")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment14 Environment { get; init; } 
        
        /// <summary>
        /// Data related to the context of the transaction.
        /// </summary>
        [IsoId("_W7eJ7QvZEeKzJ69IWwzB9Q")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext4? Context { get; init; } 
        
        /// <summary>
        /// Transaction information to be captured.
        /// </summary>
        [IsoId("_W7eJ8QvZEeKzJ69IWwzB9Q")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction14 Transaction { get; init; } 
        
        
        #nullable disable
        
    }
}
