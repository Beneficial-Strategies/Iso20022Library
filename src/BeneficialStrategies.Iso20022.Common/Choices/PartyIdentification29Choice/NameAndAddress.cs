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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification29Choice
{
    /// <summary>
    /// Identifies the name and address of a non-financial institution.
    /// </summary>
    [IsoId("_QFGgctp-Ed-ak6NoX_4Aeg_196915523")]
    [DisplayName("Name And Address")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NameAndAddress : PartyIdentification29Choice_
    #else
    public partial class NameAndAddress : PartyIdentification29Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NameAndAddress instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NameAndAddress( System.String reqName,PostalAddress5 reqPostalAddress )
        {
            Name = reqName;
            PostalAddress = reqPostalAddress;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PcH05Np-Ed-ak6NoX_4Aeg_-1219999063")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax70Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier assigned to a party using a proprietary identification scheme.
        /// </summary>
        [IsoId("_PcH05dp-Ed-ak6NoX_4Aeg_53536454")]
        [DisplayName("Proprietary Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryId")]
        #endif
        [IsoXmlTag("PrtryId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericIdentification4? ProprietaryIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification4? ProprietaryIdentification { get; init; } 
        #else
        public GenericIdentification4? ProprietaryIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_PcH05tp-Ed-ak6NoX_4Aeg_-1219998601")]
        [DisplayName("Postal Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstlAdr")]
        #endif
        [IsoXmlTag("PstlAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PostalAddress5 PostalAddress { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PostalAddress5 PostalAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostalAddress5 PostalAddress { get; init; } 
        #else
        public PostalAddress5 PostalAddress { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
