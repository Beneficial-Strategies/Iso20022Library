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
namespace BeneficialStrategies.Iso20022.Choices.Party10Choice
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_PWwzw9p-Ed-ak6NoX_4Aeg_-128365670")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OrganisationIdentification : Party10Choice_
    #else
    public partial class OrganisationIdentification : Party10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Code allocated to an institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoId("_QPrYxNp-Ed-ak6NoX_4Aeg_386164856")]
        [DisplayName("Any BIC")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AnyBIC")]
        #endif
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoAnyBICIdentifier? AnyBIC { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AnyBIC { get; init; } 
        #else
        public System.String? AnyBIC { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_QPrYxdp-Ed-ak6NoX_4Aeg_-540824728")]
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
