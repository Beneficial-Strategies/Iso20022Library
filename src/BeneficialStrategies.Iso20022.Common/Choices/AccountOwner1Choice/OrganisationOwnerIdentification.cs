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
namespace BeneficialStrategies.Iso20022.Choices.AccountOwner1Choice
{
    /// <summary>
    /// Identification of the organisation that legally owns the account.
    /// </summary>
    [IsoId("_3SysEyFUEeWgV9SQSyaAog")]
    [DisplayName("Organisation Owner Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OrganisationOwnerIdentification : AccountOwner1Choice_
    #else
    public partial class OrganisationOwnerIdentification : AccountOwner1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the organisation.
        /// </summary>
        [IsoId("_f2C84SGYEeWKAaDJcYGKLw")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification96Choice_? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification96Choice_? Identification { get; init; } 
        #else
        public PartyIdentification96Choice_? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_f2C84yGYEeWKAaDJcYGKLw")]
        [DisplayName("Legal Entity Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LglNttyIdr")]
        #endif
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LegalEntityIdentifier { get; init; } 
        #else
        public System.String? LegalEntityIdentifier { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
