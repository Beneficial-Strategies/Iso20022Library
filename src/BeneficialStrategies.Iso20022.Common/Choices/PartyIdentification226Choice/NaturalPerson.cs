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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification226Choice
{
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_nbVCNa-kEemJ1NnLPsTFaw")]
    [DisplayName("Natural Person")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NaturalPerson : PartyIdentification226Choice_
    #else
    public partial class NaturalPerson : PartyIdentification226Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NaturalPerson instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NaturalPerson( PersonName1 reqNameAndAddress,NaturalPersonIdentification1 reqIdentification )
        {
            NameAndAddress = reqNameAndAddress;
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_e_o11a-EEemJ1NnLPsTFaw")]
        [DisplayName("Name And Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmAndAdr")]
        #endif
        [IsoXmlTag("NmAndAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PersonName1 NameAndAddress { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PersonName1 NameAndAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PersonName1 NameAndAddress { get; init; } 
        #else
        public PersonName1 NameAndAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_oP6HUa-EEemJ1NnLPsTFaw")]
        [DisplayName("Email Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EmailAdr")]
        #endif
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax256Text? EmailAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EmailAddress { get; init; } 
        #else
        public System.String? EmailAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Natural person local identification and type.
        /// </summary>
        [IsoId("_e_o11K-EEemJ1NnLPsTFaw")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NaturalPersonIdentification1 Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NaturalPersonIdentification1 Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NaturalPersonIdentification1 Identification { get; init; } 
        #else
        public NaturalPersonIdentification1 Identification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
