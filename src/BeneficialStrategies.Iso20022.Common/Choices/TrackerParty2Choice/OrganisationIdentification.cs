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
namespace BeneficialStrategies.Iso20022.Choices.TrackerParty2Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_dtxow2OTEeq5Ar_w98FvsA")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OrganisationIdentification : TrackerParty2Choice_
    #else
    public partial class OrganisationIdentification : TrackerParty2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Business identification code of the organisation.
        /// </summary>
        [IsoId("_6emK0248EeiU9cctagi5ow")]
        [DisplayName("Any BIC")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AnyBIC")]
        #endif
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoAnyBICDec2014Identifier? AnyBIC { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AnyBIC { get; init; } 
        #else
        public System.String? AnyBIC { get; set; } 
        #endif
        
        /// <summary>
        /// Legal entity identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_XzdQ4XRwEeiH1ZOt2UD8vQ")]
        [DisplayName("LEI")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LEI")]
        #endif
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? LEI { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LEI { get; init; } 
        #else
        public System.String? LEI { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_6emK1W48EeiU9cctagi5ow")]
        [DisplayName("Other")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Othr")]
        #endif
        [IsoXmlTag("Othr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericOrganisationIdentification1? Other { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericOrganisationIdentification1? Other { get; init; } 
        #else
        public GenericOrganisationIdentification1? Other { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
