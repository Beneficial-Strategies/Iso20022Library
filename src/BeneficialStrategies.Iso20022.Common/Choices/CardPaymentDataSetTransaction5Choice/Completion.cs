// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction5Choice
{
    /// <summary>
    /// Completed card payment transaction to be captured.
    /// </summary>
    [IsoId("_Cc4WMap3EeanIZ10Ka8PnA")]
    [DisplayName("Completion")]
    public partial record Completion : CardPaymentDataSetTransaction5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_gOrAcap2EeanIZ10Ka8PnA")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
        
        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_gOrAc6p2EeanIZ10Ka8PnA")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; } 
        
        /// <summary>
        /// Data related to the environment of the transaction in a transaction captured in batch.
        /// </summary>
        [IsoId("_gOrAdap2EeanIZ10Ka8PnA")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment61 Environment { get; init; } 
        
        /// <summary>
        /// Data related to the context of the transaction.
        /// </summary>
        [IsoId("_gOrAd6p2EeanIZ10Ka8PnA")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext24? Context { get; init; } 
        
        /// <summary>
        /// Transaction information to be captured.
        /// </summary>
        [IsoId("_gOrAeap2EeanIZ10Ka8PnA")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction70 Transaction { get; init; } 
        
        
        #nullable disable
        
    }
}
