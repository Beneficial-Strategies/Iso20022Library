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
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice
{
    /// <summary>
    /// Reason why the payment status is pending (failing settlement).
    /// </summary>
    [IsoId("_Ny9Dx5lPEee-Zps0fZQaFQ")]
    [DisplayName("Pending Failing Settlement")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PendingFailingSettlement : PaymentStatusReasonCode7Choice_
    #else
    public partial class PendingFailingSettlement : PaymentStatusReasonCode7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PendingFailingSettlement instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PendingFailingSettlement( PendingFailingSettlement1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PdgFlngSttlm")]
        #endif
        [IsoXmlTag("PdgFlngSttlm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PendingFailingSettlement1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PendingFailingSettlement1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PendingFailingSettlement1Code Value { get; init; } 
        #else
        public PendingFailingSettlement1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
