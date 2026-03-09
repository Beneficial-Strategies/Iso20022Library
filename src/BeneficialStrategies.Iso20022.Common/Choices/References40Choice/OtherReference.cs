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
namespace BeneficialStrategies.Iso20022.Choices.References40Choice
{
    /// <summary>
    /// Reference to a linked proprietary message or reference of a system that was previously received.
    /// </summary>
    [IsoId("_SqCIIyGiEeONGJioFgcMDw")]
    [DisplayName("Other Reference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherReference : References40Choice_
    #else
    public partial class OtherReference : References40Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherReference instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherReference( System.String reqReference )
        {
            Reference = reqReference;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
        /// </summary>
        [IsoId("_Q6vvAtp-Ed-ak6NoX_4Aeg_2103248321")]
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
        [IsoId("_Q6vvA9p-Ed-ak6NoX_4Aeg_2103249887")]
        [DisplayName("Reference Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RefIssr")]
        #endif
        [IsoXmlTag("RefIssr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification2Choice_? ReferenceIssuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_? ReferenceIssuer { get; init; } 
        #else
        public PartyIdentification2Choice_? ReferenceIssuer { get; set; } 
        #endif
        
        /// <summary>
        /// Name of a message.
        /// </summary>
        [IsoId("_Q6vvBNp-Ed-ak6NoX_4Aeg_2103249905")]
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
