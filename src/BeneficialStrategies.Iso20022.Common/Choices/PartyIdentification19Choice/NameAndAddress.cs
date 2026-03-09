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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification19Choice
{
    /// <summary>
    /// Identification of the party expressed as name and address and an alternative identifier.
    /// </summary>
    [IsoId("_Sp1N6wEcEeCQm6a_G2yO_w_-1343447231")]
    [DisplayName("Name And Address")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NameAndAddress : PartyIdentification19Choice_
    #else
    public partial class NameAndAddress : PartyIdentification19Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NameAndAddress instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NameAndAddress( System.String reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PZvPQdp-Ed-ak6NoX_4Aeg_-611452364")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Postal address of a party.
        /// </summary>
        [IsoId("_PZvPQtp-Ed-ak6NoX_4Aeg_-611452322")]
        [DisplayName("Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Adr")]
        #endif
        [IsoXmlTag("Adr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PostalAddress1? Address { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostalAddress1? Address { get; init; } 
        #else
        public PostalAddress1? Address { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
        /// </summary>
        [IsoId("_PZvPQ9p-Ed-ak6NoX_4Aeg_-106286787")]
        [DisplayName("Alternative Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AltrntvIdr")]
        #endif
        [IsoXmlTag("AltrntvIdr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(10)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public SimpleValueList<System.String> AlternativeIdentifier { get; init; } = new SimpleValueList<System.String>(){};
        
        
        #nullable disable
        
    }
}
