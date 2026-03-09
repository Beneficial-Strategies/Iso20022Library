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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification248Choice
{
    /// <summary>
    /// Party is a natural person.
    /// </summary>
    [IsoId("_WAhpkz3YEe2uHKhHp3bXyA")]
    [DisplayName("Natural")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Natural : PartyIdentification248Choice_
    #else
    public partial class Natural : PartyIdentification248Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Natural instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Natural( NaturalPersonIdentification2 reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the natural person.
        /// </summary>
        [IsoId("_kMVykT3ZEe2uHKhHp3bXyA")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NaturalPersonIdentification2 Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NaturalPersonIdentification2 Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NaturalPersonIdentification2 Identification { get; init; } 
        #else
        public NaturalPersonIdentification2 Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Code of country of residence of a natural person.
        /// </summary>
        [IsoId("_P8TLYD3aEe2uHKhHp3bXyA")]
        [DisplayName("Country")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ctry")]
        #endif
        [IsoXmlTag("Ctry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? Country { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? Country { get; init; } 
        #else
        public string? Country { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
