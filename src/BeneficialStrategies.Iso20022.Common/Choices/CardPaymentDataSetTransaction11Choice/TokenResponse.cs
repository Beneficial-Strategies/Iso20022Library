// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction11Choice
{
    /// <summary>
    /// Response to a token computation.
    /// </summary>
    [IsoId("_1ylO23JCEe299ZbWCkdR_w")]
    [DisplayName("Token Response")]
    public partial record TokenResponse : CardPaymentDataSetTransaction11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of an element in a sequence.
        /// </summary>
        [IsoId("_-2bqYXJBEe299ZbWCkdR_w")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
        
        /// <summary>
        /// Environment of the transaction.
        /// </summary>
        [IsoId("_-2bqY3JBEe299ZbWCkdR_w")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment79 Environment { get; init; } 
        
        
        #nullable disable
        
    }
}
