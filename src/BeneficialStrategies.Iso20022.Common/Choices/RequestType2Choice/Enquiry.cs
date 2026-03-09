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
namespace BeneficialStrategies.Iso20022.Choices.RequestType2Choice
{
    /// <summary>
    /// Request type is an enquiry on a position or a transaction.
    /// </summary>
    [IsoId("_76G8dKMgEeCJ6YNENx4h-w_-1836773968")]
    [DisplayName("Enquiry")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Enquiry : RequestType2Choice_
    #else
    public partial class Enquiry : RequestType2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Enquiry instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Enquiry( RequestType2Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the request used to further detail the type of information that will be queried.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Enqry")]
        #endif
        [IsoXmlTag("Enqry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RequestType2Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RequestType2Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RequestType2Code Value { get; init; } 
        #else
        public RequestType2Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
