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
    /// Content of the Loyalty Request message.
    /// </summary>
    [IsoId("_Xt0vE3GwEe2TbaNWBpRZpQ")]
    [DisplayName("Loyalty Request")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record LoyaltyRequest : TransactionToPerform5Choice_
    #else
    public partial class LoyaltyRequest : TransactionToPerform5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a LoyaltyRequest instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public LoyaltyRequest( LoyaltyTransaction5 reqTransaction )
        {
            Transaction = reqTransaction;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// To retrieve Card Acquisition Data.
        /// </summary>
        [IsoId("_fE1OUXGvEe2TbaNWBpRZpQ")]
        [DisplayName("Customer Order")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CstmrOrdr")]
        #endif
        [IsoXmlTag("CstmrOrdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CustomerOrder1? CustomerOrder { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CustomerOrder1? CustomerOrder { get; init; } 
        #else
        public CustomerOrder1? CustomerOrder { get; set; } 
        #endif
        
        /// <summary>
        /// Data related to the loyalty transaction.
        /// </summary>
        [IsoId("_fE1OU3GvEe2TbaNWBpRZpQ")]
        [DisplayName("Transaction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tx")]
        #endif
        [IsoXmlTag("Tx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required LoyaltyTransaction5 Transaction { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required LoyaltyTransaction5 Transaction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LoyaltyTransaction5 Transaction { get; init; } 
        #else
        public LoyaltyTransaction5 Transaction { get; set; } 
        #endif
        
        /// <summary>
        /// Data related to a Loyalty program or account.
        /// </summary>
        [IsoId("_fE1OVXGvEe2TbaNWBpRZpQ")]
        [DisplayName("Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Data")]
        #endif
        [IsoXmlTag("Data")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LoyaltyRequestData3? Data { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LoyaltyRequestData3? Data { get; init; } 
        #else
        public LoyaltyRequestData3? Data { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
