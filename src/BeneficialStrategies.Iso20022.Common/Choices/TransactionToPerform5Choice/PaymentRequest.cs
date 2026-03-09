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
namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform5Choice
{
    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [IsoId("_Xt0vEXGwEe2TbaNWBpRZpQ")]
    [DisplayName("Payment Request")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PaymentRequest : TransactionToPerform5Choice_
    #else
    public partial class PaymentRequest : TransactionToPerform5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Data associated with the Transaction.
        /// </summary>
        [IsoId("_kd-koXGsEe2TbaNWBpRZpQ")]
        [DisplayName("Payment Transaction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtTx")]
        #endif
        [IsoXmlTag("PmtTx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardPaymentTransaction127? PaymentTransaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentTransaction127? PaymentTransaction { get; init; } 
        #else
        public CardPaymentTransaction127? PaymentTransaction { get; set; } 
        #endif
        
        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_kd-ko3GsEe2TbaNWBpRZpQ")]
        [DisplayName("Loyalty Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LltyData")]
        #endif
        [IsoXmlTag("LltyData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LoyaltyRequestData3? LoyaltyData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LoyaltyRequestData3? LoyaltyData { get; init; } 
        #else
        public LoyaltyRequestData3? LoyaltyData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
