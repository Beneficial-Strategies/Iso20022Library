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
namespace BeneficialStrategies.Iso20022.Choices.ResponseProcessingStatus1Choice
{
    /// <summary>
    /// The received message or the multipart received report (sent with pagination in multiple messages) is accepted.
    /// </summary>
    [IsoId("_lOZu8IeUEemJ1cSJJmVYRQ")]
    [DisplayName("Accepted")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Accepted : ResponseProcessingStatus1Choice_
    #else
    public partial class Accepted : ResponseProcessingStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Accepted instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Accepted( NoReasonCode reqNoSpecifiedReason )
        {
            NoSpecifiedReason = reqNoSpecifiedReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason not specified.
        /// </summary>
        [IsoId("_6xuti4eUEemJ1cSJJmVYRQ")]
        [DisplayName("No Specified Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NoSpcfdRsn")]
        #endif
        [IsoXmlTag("NoSpcfdRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoReasonCode NoSpecifiedReason { get; init; } 
        #else
        public NoReasonCode NoSpecifiedReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
