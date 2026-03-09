// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.CardTransaction2Choice
{
    /// <summary>
    /// Card transaction details, based on card transaction aggregated data performed by the card acquirer.
    /// </summary>
    [IsoId("_0jmr8Tj3EeSz-s1QOUJaOg")]
    [DisplayName("Aggregated")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Aggregated : CardTransaction2Choice_
    #else
    public partial class Aggregated : CardTransaction2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Service in addition to the main service.
        /// </summary>
        [IsoId("_t5ypwlkyEeGeoaLUQk__nA_1601198627")]
        [DisplayName("Additional Service")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlSvc")]
        #endif
        [IsoXmlTag("AddtlSvc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardPaymentServiceType2Code? AdditionalService { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentServiceType2Code? AdditionalService { get; init; } 
        #else
        public CardPaymentServiceType2Code? AdditionalService { get; set; } 
        #endif
        
        /// <summary>
        /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
        /// </summary>
        [IsoId("_t5ypw1kyEeGeoaLUQk__nA_-749758771")]
        [DisplayName("Transaction Category")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxCtgy")]
        #endif
        [IsoXmlTag("TxCtgy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? TransactionCategory { get; init; } 
        #else
        public string? TransactionCategory { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
        /// </summary>
        [IsoId("_t5ypxFkyEeGeoaLUQk__nA_-684903817")]
        [DisplayName("Sale Reconciliation Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SaleRcncltnId")]
        #endif
        [IsoXmlTag("SaleRcncltnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SaleReconciliationIdentification { get; init; } 
        #else
        public System.String? SaleReconciliationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Range of sequence numbers on which the globalisation applies.
        /// </summary>
        [IsoId("_t58awFkyEeGeoaLUQk__nA_1907876511")]
        [DisplayName("Sequence Number Range")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SeqNbRg")]
        #endif
        [IsoXmlTag("SeqNbRg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardSequenceNumberRange1? SequenceNumberRange { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardSequenceNumberRange1? SequenceNumberRange { get; init; } 
        #else
        public CardSequenceNumberRange1? SequenceNumberRange { get; set; } 
        #endif
        
        /// <summary>
        /// Date range on which the globalisation applies.
        /// </summary>
        [IsoId("_t58awVkyEeGeoaLUQk__nA_-1040964172")]
        [DisplayName("Transaction Date Range")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxDtRg")]
        #endif
        [IsoXmlTag("TxDtRg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateOrDateTimePeriodChoice_? TransactionDateRange { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateOrDateTimePeriodChoice_? TransactionDateRange { get; init; } 
        #else
        public DateOrDateTimePeriodChoice_? TransactionDateRange { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
