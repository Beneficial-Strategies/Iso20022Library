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
namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus9Choice
{
    /// <summary>
    /// Provides a proprietary status and a proprietary reason of the processing status of the trade.
    /// </summary>
    [IsoId("_A4aEJ9okEeC60axPepSq7g_1828723592")]
    [DisplayName("Proprietary Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ProprietaryStatus : MatchingStatus9Choice_
    #else
    public partial class ProprietaryStatus : MatchingStatus9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ProprietaryStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ProprietaryStatus( GenericIdentification20 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the status related to an instruction.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtrySts")]
        #endif
        [IsoXmlTag("PrtrySts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification20 Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification20 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification20 Value { get; init; } 
        #else
        public GenericIdentification20 Value { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary identification of the reason related to a proprietary status.
        /// </summary>
        [IsoId("_UatOw9p-Ed-ak6NoX_4Aeg_-1512024757")]
        [DisplayName("Proprietary Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryRsn")]
        #endif
        [IsoXmlTag("PrtryRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ProprietaryReason1? ProprietaryReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ProprietaryReason1? ProprietaryReason { get; init; } 
        #else
        public ProprietaryReason1? ProprietaryReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
