// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction6Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation request.
    /// </summary>
    [IsoId("_aCXvZdpoEeearpaEPXv9UA")]
    [DisplayName("Authorisation Request")]
    public record AuthorisationRequest : CardPaymentDataSetTransaction6Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("__8gZwdpnEeearpaEPXv9UA")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("__8gZw9pnEeearpaEPXv9UA")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction to authorise.
        /// </summary>
        [IsoId("__8gZxdpnEeearpaEPXv9UA")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment68 Environment { get; init; }

        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("__8gZx9pnEeearpaEPXv9UA")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext26? Context { get; init; }

        /// <summary>
        /// Card payment transaction to authorise.
        /// </summary>
        [IsoId("__8gZydpnEeearpaEPXv9UA")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction80 Transaction { get; init; }
    }
}
