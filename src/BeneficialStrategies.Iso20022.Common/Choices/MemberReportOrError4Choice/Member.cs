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
namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError4Choice
{
    /// <summary>
    /// Requested member data when found in the system.
    /// </summary>
    [IsoId("_jEyVkZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Member : MemberReportOrError4Choice_
    #else
    public partial class Member : MemberReportOrError4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Word by which something is called or known or the family name of a person.
        /// </summary>
        [IsoId("_jNHLIZlCEee-Zps0fZQaFQ")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
        /// </summary>
        [IsoId("_jNHLI5lCEee-Zps0fZQaFQ")]
        [DisplayName("Return Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RtrAdr")]
        #endif
        [IsoXmlTag("RtrAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MemberIdentification2Choice_? ReturnAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MemberIdentification2Choice_? ReturnAddress { get; init; } 
        #else
        public MemberIdentification2Choice_? ReturnAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Account to or from which a cash entry is made.
        /// </summary>
        [IsoId("_jNHLJZlCEee-Zps0fZQaFQ")]
        [DisplayName("Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Acct")]
        #endif
        [IsoXmlTag("Acct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount24? Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount24? Account { get; init; } 
        #else
        public CashAccount24? Account { get; set; } 
        #endif
        
        /// <summary>
        /// Nature of the relationship a member has with a system.
        /// </summary>
        [IsoId("_jNHLJ5lCEee-Zps0fZQaFQ")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MemberType1Code? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MemberType1Code? Type { get; init; } 
        #else
        public MemberType1Code? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Status of a member in a system, for example enabled or deleted.
        /// </summary>
        [IsoId("_jNHLKZlCEee-Zps0fZQaFQ")]
        [DisplayName("Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sts")]
        #endif
        [IsoXmlTag("Sts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MemberStatus1Code? Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MemberStatus1Code? Status { get; init; } 
        #else
        public MemberStatus1Code? Status { get; set; } 
        #endif
        
        /// <summary>
        /// Person to be contacted in a given organisation.
        /// </summary>
        [IsoId("_jNHLK5lCEee-Zps0fZQaFQ")]
        [DisplayName("Contact Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtctRef")]
        #endif
        [IsoXmlTag("CtctRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ContactIdentificationAndAddress1? ContactReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContactIdentificationAndAddress1? ContactReference { get; init; } 
        #else
        public ContactIdentificationAndAddress1? ContactReference { get; set; } 
        #endif
        
        /// <summary>
        /// Number, or virtual address, used for communication.
        /// </summary>
        [IsoId("_jNHLLZlCEee-Zps0fZQaFQ")]
        [DisplayName("Communication Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ComAdr")]
        #endif
        [IsoXmlTag("ComAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommunicationAddress8? CommunicationAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommunicationAddress8? CommunicationAddress { get; init; } 
        #else
        public CommunicationAddress8? CommunicationAddress { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
