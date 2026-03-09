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
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode5Choice
{
    /// <summary>
    /// Qualifies further the pending status.
    /// </summary>
    [IsoId("_72FYE6MgEeCJ6YNENx4h-w_85947767")]
    [DisplayName("Pending")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Pending : PaymentStatusCode5Choice_
    #else
    public partial class Pending : PaymentStatusCode5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Pending instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Pending( PendingStatus4Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the state of a payment at the clearing agent side is pending.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pdg")]
        #endif
        [IsoXmlTag("Pdg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PendingStatus4Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PendingStatus4Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PendingStatus4Code Value { get; init; } 
        #else
        public PendingStatus4Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
