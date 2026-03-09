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
namespace BeneficialStrategies.Iso20022.Choices.CentralisedAndAuthorisedBranchIdentification1Choice
{
    /// <summary>
    /// Identifier of the authorised branch.
    /// </summary>
    [IsoId("_K7PY4B9qEeapDZRA0Hb6ow")]
    [DisplayName("Authorised Branch Identifier")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AuthorisedBranchIdentifier : CentralisedAndAuthorisedBranchIdentification1Choice_
    #else
    public partial class AuthorisedBranchIdentifier : CentralisedAndAuthorisedBranchIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoId("_6T-oF5qlEeGSON8vddiWzQ_-1460045446")]
        [DisplayName("BICFI")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BICFI")]
        #endif
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoBICFIIdentifier? BICFI { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BICFI { get; init; } 
        #else
        public System.String? BICFI { get; set; } 
        #endif
        
        /// <summary>
        /// Information used to identify a member within a clearing system.
        /// </summary>
        [IsoId("_6T-oGJqlEeGSON8vddiWzQ_700420690")]
        [DisplayName("Clearing System Member Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSysMmbId")]
        #endif
        [IsoXmlTag("ClrSysMmbId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
        #else
        public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_6T-oGZqlEeGSON8vddiWzQ_1934580671")]
        [DisplayName("Other")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Othr")]
        #endif
        [IsoXmlTag("Othr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericFinancialIdentification1? Other { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericFinancialIdentification1? Other { get; init; } 
        #else
        public GenericFinancialIdentification1? Other { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
