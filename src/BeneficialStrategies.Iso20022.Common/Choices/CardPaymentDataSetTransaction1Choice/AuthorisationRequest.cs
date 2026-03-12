// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction1Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation request.
    /// </summary>
    [IsoId("_C46-sC8REeKW5usMQLtzqw")]
    [DisplayName("Authorisation Request")]
    public partial record AuthorisationRequest : CardPaymentDataSetTransaction1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_uBxblS8OEeKW5usMQLtzqw")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
        
        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_uBxbnC8OEeKW5usMQLtzqw")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability1? Traceability { get; init; } 
        
        /// <summary>
        /// Data related to the environment of the card payment transaction to authorise.
        /// </summary>
        [IsoId("_uBxboy8OEeKW5usMQLtzqw")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment14 Environment { get; init; } 
        
        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_gM7JIDVEEeKdge4xeUaMrg")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext4? Context { get; init; } 
        
        /// <summary>
        /// Card payment transaction to authorise.
        /// </summary>
        [IsoId("_uBxbqi8OEeKW5usMQLtzqw")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction19 Transaction { get; init; } 
        
        
        #nullable disable
        
    }
}
