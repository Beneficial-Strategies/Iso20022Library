// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardTransaction2Choice
{
    /// <summary>
    /// Card transaction details, based on card transaction aggregated data performed by the card acquirer.
    /// </summary>
    [IsoId("_0jmr8Tj3EeSz-s1QOUJaOg")]
    [DisplayName("Aggregated")]
    public partial record Aggregated : CardTransaction2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Service in addition to the main service.
        /// </summary>
        [IsoId("_t5ypwlkyEeGeoaLUQk__nA_1601198627")]
        [DisplayName("Additional Service")]
        [IsoXmlTag("AddtlSvc")]
        public CardPaymentServiceType2Code? AdditionalService { get; init; } 
        
        /// <summary>
        /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
        /// </summary>
        [IsoId("_t5ypw1kyEeGeoaLUQk__nA_-749758771")]
        [DisplayName("Transaction Category")]
        [IsoXmlTag("TxCtgy")]
        public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; } 
        
        /// <summary>
        /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
        /// </summary>
        [IsoId("_t5ypxFkyEeGeoaLUQk__nA_-684903817")]
        [DisplayName("Sale Reconciliation Identification")]
        [IsoXmlTag("SaleRcncltnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
        
        /// <summary>
        /// Range of sequence numbers on which the globalisation applies.
        /// </summary>
        [IsoId("_t58awFkyEeGeoaLUQk__nA_1907876511")]
        [DisplayName("Sequence Number Range")]
        [IsoXmlTag("SeqNbRg")]
        public CardSequenceNumberRange1? SequenceNumberRange { get; init; } 
        
        /// <summary>
        /// Date range on which the globalisation applies.
        /// </summary>
        [IsoId("_t58awVkyEeGeoaLUQk__nA_-1040964172")]
        [DisplayName("Transaction Date Range")]
        [IsoXmlTag("TxDtRg")]
        public DateOrDateTimePeriodChoice_? TransactionDateRange { get; init; } 
        
        
        #nullable disable
        
    }
}
