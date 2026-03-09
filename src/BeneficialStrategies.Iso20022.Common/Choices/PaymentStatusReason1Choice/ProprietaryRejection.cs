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
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice
{
    /// <summary>
    /// Defines the reason that has been used by the system to reject the transaction.
    /// </summary>
    [IsoId("_QWOzu9EdEei798TPbKJMuw")]
    [DisplayName("Proprietary Rejection")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProprietaryRejection : PaymentStatusReason1Choice_
    #else
    public partial class ProprietaryRejection : PaymentStatusReason1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProprietaryRejection instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProprietaryRejection( System.String reqProprietaryStatusReason,System.String reqReason )
        {
            ProprietaryStatusReason = reqProprietaryStatusReason;
            Reason = reqReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Defines the reason why the system has rejected the transaction.
        /// </summary>
        [IsoId("_hU5UQdEdEei798TPbKJMuw")]
        [DisplayName("Proprietary Status Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryStsRsn")]
        #endif
        [IsoXmlTag("PrtryStsRsn")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax4AlphaNumericText ProprietaryStatusReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ProprietaryStatusReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ProprietaryStatusReason { get; init; } 
        #else
        public System.String ProprietaryStatusReason { get; set; } 
        #endif
        
        /// <summary>
        /// Provides detailed information about the reason why the  system has rejected the transaction.
        /// </summary>
        [IsoId("_hU5UQ9EdEei798TPbKJMuw")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax256Text Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Reason { get; init; } 
        #else
        public System.String Reason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
