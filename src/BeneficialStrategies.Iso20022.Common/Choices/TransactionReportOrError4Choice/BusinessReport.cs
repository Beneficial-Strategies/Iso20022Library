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
namespace BeneficialStrategies.Iso20022.Choices.TransactionReportOrError4Choice
{
    /// <summary>
    /// Reports on payment transactions.
    /// </summary>
    [IsoId("_WnqHQW49EeiU9cctagi5ow")]
    [DisplayName("Business Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BusinessReport : TransactionReportOrError4Choice_
    #else
    public partial class BusinessReport : TransactionReportOrError4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Common detailed payment instruction information.
        /// </summary>
        [IsoId("_WxDT2W49EeiU9cctagi5ow")]
        [DisplayName("Payment Common Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtCmonInf")]
        #endif
        [IsoXmlTag("PmtCmonInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PaymentCommon4? PaymentCommonInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentCommon4? PaymentCommonInformation { get; init; } 
        #else
        public PaymentCommon4? PaymentCommonInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the total number and sum of the transactions.
        /// </summary>
        [IsoId("_WxDT2249EeiU9cctagi5ow")]
        [DisplayName("Transactions Summary")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxsSummry")]
        #endif
        [IsoXmlTag("TxsSummry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
        #else
        public NumberAndSumOfTransactions2? TransactionsSummary { get; set; } 
        #endif
        
        /// <summary>
        /// Reports either on the transaction information or on a business error.
        /// </summary>
        [IsoId("_WxDT3W49EeiU9cctagi5ow")]
        [DisplayName("Transaction Report")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxRpt")]
        #endif
        [IsoXmlTag("TxRpt")]
        public ValueList<TransactionReport5> TransactionReport { get; init; } = new ValueList<TransactionReport5>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _WxDT3W49EeiU9cctagi5ow
        
        
        #nullable disable
        
    }
}
