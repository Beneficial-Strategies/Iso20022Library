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
namespace BeneficialStrategies.Iso20022.Choices.References68Choice
{
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_HVRNUZGrEem-9Y6mq5ZH3Q")]
    [DisplayName("Previous Reference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PreviousReference : References68Choice_
    #else
    public partial class PreviousReference : References68Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PreviousReference instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PreviousReference( System.String reqReference )
        {
            Reference = reqReference;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference issued by a party to identify an instruction, transaction or a message.
        /// </summary>
        [IsoId("_ZSms42pTEeipaMTLlhaKMQ")]
        [DisplayName("Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ref")]
        #endif
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Reference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Reference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Reference { get; init; } 
        #else
        public System.String Reference { get; set; } 
        #endif
        
        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_ZSms5WpTEeipaMTLlhaKMQ")]
        [DisplayName("Reference Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RefIssr")]
        #endif
        [IsoXmlTag("RefIssr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification139? ReferenceIssuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification139? ReferenceIssuer { get; init; } 
        #else
        public PartyIdentification139? ReferenceIssuer { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the message.
        /// </summary>
        [IsoId("_ZSms52pTEeipaMTLlhaKMQ")]
        [DisplayName("Message Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MsgNm")]
        #endif
        [IsoXmlTag("MsgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MessageName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MessageName { get; init; } 
        #else
        public System.String? MessageName { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
