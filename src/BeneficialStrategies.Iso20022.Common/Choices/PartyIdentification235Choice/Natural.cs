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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification235Choice
{
    /// <summary>
    /// The party is a natural person.
    /// </summary>
    [IsoId("_36SD8O9KEemVGdgB8P8uQQ")]
    [DisplayName("Natural")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Natural : PartyIdentification235Choice_
    #else
    public partial class Natural : PartyIdentification235Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Natural instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Natural( GenericIdentification175 reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the natural person.
        /// </summary>
        [IsoId("_jJtX4S40Eeuxhbw_aW6haw")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericIdentification175 Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericIdentification175 Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification175 Identification { get; init; } 
        #else
        public GenericIdentification175 Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the name of the natural person.
        /// </summary>
        [IsoId("_jJtX4y40Eeuxhbw_aW6haw")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax105Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the domicile of the natural person.
        /// </summary>
        [IsoId("_jJtX5S40Eeuxhbw_aW6haw")]
        [DisplayName("Domicile")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dmcl")]
        #endif
        [IsoXmlTag("Dmcl")]
        [IsoSimpleType(IsoSimpleType.Max500Text)]
        [StringLength(maximumLength: 500 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax500Text? Domicile { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Domicile { get; init; } 
        #else
        public System.String? Domicile { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
