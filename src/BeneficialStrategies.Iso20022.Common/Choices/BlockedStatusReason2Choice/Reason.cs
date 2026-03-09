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
namespace BeneficialStrategies.Iso20022.Choices.BlockedStatusReason2Choice
{
    /// <summary>
    /// Transaction type for which the account is blocked and the underlying reason.
    /// </summary>
    [IsoId("_8t7ZA11LEeagR5I1rq5oaw")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : BlockedStatusReason2Choice_
    #else
    public partial class Reason : BlockedStatusReason2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( TransactionType5Choice_ reqTransactionType,System.String reqBlocked,System.String reqAdditionalInformation )
        {
            TransactionType = reqTransactionType;
            Blocked = reqBlocked;
            AdditionalInformation = reqAdditionalInformation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of transaction for which the account has a blocked status.
        /// </summary>
        [IsoId("__4jh8V1LEeagR5I1rq5oaw")]
        [DisplayName("Transaction Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxTp")]
        #endif
        [IsoXmlTag("TxTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TransactionType5Choice_ TransactionType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TransactionType5Choice_ TransactionType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionType5Choice_ TransactionType { get; init; } 
        #else
        public TransactionType5Choice_ TransactionType { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the account is blocked.
        /// </summary>
        [IsoId("_E6gY4V1MEeagR5I1rq5oaw")]
        [DisplayName("Blocked")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Blckd")]
        #endif
        [IsoXmlTag("Blckd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoYesNoIndicator Blocked { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Blocked { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Blocked { get; init; } 
        #else
        public System.String Blocked { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for the blocked status.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BlockedReason2Choice_? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BlockedReason2Choice_? Value { get; init; } 
        #else
        public BlockedReason2Choice_? Value { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the blocked account status.
        /// </summary>
        [IsoId("__4jh9V1LEeagR5I1rq5oaw")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text AdditionalInformation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String AdditionalInformation { get; init; } 
        #else
        public System.String AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
