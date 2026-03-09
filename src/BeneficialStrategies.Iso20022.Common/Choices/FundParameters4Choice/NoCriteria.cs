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
namespace BeneficialStrategies.Iso20022.Choices.FundParameters4Choice
{
    /// <summary>
    /// Specifies that there is no criteria for the report. The request is a request for all reports, rather than reports attributed to a specific fund manager, date or financial instrument.
    /// </summary>
    [IsoId("_KQCmFWomEeipaMTLlhaKMQ")]
    [DisplayName("No Criteria")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NoCriteria : FundParameters4Choice_
    #else
    public partial class NoCriteria : FundParameters4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NoCriteria instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NoCriteria( NoCriteria1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no criteria.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NoCrit")]
        #endif
        [IsoXmlTag("NoCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NoCriteria1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NoCriteria1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoCriteria1Code Value { get; init; } 
        #else
        public NoCriteria1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
