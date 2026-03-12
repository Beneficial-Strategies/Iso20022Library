// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction2Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation request.
    /// </summary>
    [IsoId("_RPup9TKQEeOqyZqt0rCZLg")]
    [DisplayName("Authorisation Request")]
    public partial record AuthorisationRequest : CardPaymentDataSetTransaction2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_aU3w4TKNEeOqyZqt0rCZLg")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
        
        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_aU3w4zKNEeOqyZqt0rCZLg")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability1? Traceability { get; init; } 
        
        /// <summary>
        /// Data related to the environment of the card payment transaction to authorise.
        /// </summary>
        [IsoId("_aU3w5TKNEeOqyZqt0rCZLg")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment27 Environment { get; init; } 
        
        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_aU3w5zKNEeOqyZqt0rCZLg")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext7? Context { get; init; } 
        
        /// <summary>
        /// Card payment transaction to authorise.
        /// </summary>
        [IsoId("_aU3w6TKNEeOqyZqt0rCZLg")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction31 Transaction { get; init; } 
        
        
        #nullable disable
        
    }
}
