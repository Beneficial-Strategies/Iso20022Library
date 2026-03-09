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
namespace BeneficialStrategies.Iso20022.Choices.Status31Choice
{
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    [IsoId("_ym2jwZM6EemKz5EOjv82iQ")]
    [DisplayName("Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Status : Status31Choice_
    #else
    public partial class Status : Status31Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Status instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Status( CancellationStatus5Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Status of the transfer cancellation is accepted or sent to next party.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sts")]
        #endif
        [IsoXmlTag("Sts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CancellationStatus5Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CancellationStatus5Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CancellationStatus5Code Value { get; init; } 
        #else
        public CancellationStatus5Code Value { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for the status.
        /// </summary>
        [IsoId("_6UCR5ZM6EemKz5EOjv82iQ")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Reason { get; init; } 
        #else
        public System.String? Reason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
