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
namespace BeneficialStrategies.Iso20022.Choices.Proxy5Choice
{
    /// <summary>
    /// Proxy assignment and registration information.
    /// </summary>
    [IsoId("_iTU-wRrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Proxy : Proxy5Choice_
    #else
    public partial class Proxy : Proxy5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies how to register the proxy.
        /// </summary>
        [IsoId("_ioMbgxrfEeyhRdHRjakS2w")]
        [DisplayName("Registration Method")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RegnMtd")]
        #endif
        [IsoXmlTag("RegnMtd")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? RegistrationMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? RegistrationMethod { get; init; } 
        #else
        public System.String? RegistrationMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the intermediary.
        /// </summary>
        [IsoId("_ioMbhRrfEeyhRdHRjakS2w")]
        [DisplayName("Deadline")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ddln")]
        #endif
        [IsoXmlTag("Ddln")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateFormat58Choice_? Deadline { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateFormat58Choice_? Deadline { get; init; } 
        #else
        public DateFormat58Choice_? Deadline { get; set; } 
        #endif
        
        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the issuer.
        /// </summary>
        [IsoId("_ioMbhxrfEeyhRdHRjakS2w")]
        [DisplayName("Market Deadline")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MktDdln")]
        #endif
        [IsoXmlTag("MktDdln")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateFormat58Choice_? MarketDeadline { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateFormat58Choice_? MarketDeadline { get; init; } 
        #else
        public DateFormat58Choice_? MarketDeadline { get; set; } 
        #endif
        
        /// <summary>
        /// Proxy person that is authorised by the issuer.
        /// </summary>
        [IsoId("_ioMbiRrfEeyhRdHRjakS2w")]
        [DisplayName("Authorised Proxy")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AuthrsdPrxy")]
        #endif
        [IsoXmlTag("AuthrsdPrxy")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Proxy11> AuthorisedProxy { get; init; } = new ValueList<Proxy11>(){};
        
        
        #nullable disable
        
    }
}
