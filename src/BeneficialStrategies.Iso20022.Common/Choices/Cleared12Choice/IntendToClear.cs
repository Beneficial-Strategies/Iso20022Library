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
namespace BeneficialStrategies.Iso20022.Choices.Cleared12Choice
{
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_Bemz8-xYEemioJdkOVFBdw")]
    [DisplayName("Intend To Clear")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IntendToClear : Cleared12Choice_
    #else
    public partial class IntendToClear : Cleared12Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates that the contract is intended to be cleared.
        /// </summary>
        [IsoId("_9bAboexXEemioJdkOVFBdw")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NoReasonCode? Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoReasonCode? Reason { get; init; } 
        #else
        public NoReasonCode? Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the central counterparty (CCP) that cleared the transaction.
        /// </summary>
        [IsoId("_BpsCk-xYEemioJdkOVFBdw")]
        [DisplayName("CCP")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CCP")]
        #endif
        [IsoXmlTag("CCP")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationIdentification10Choice_? CCP { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification10Choice_? CCP { get; init; } 
        #else
        public OrganisationIdentification10Choice_? CCP { get; set; } 
        #endif
        
        /// <summary>
        /// Time and date when clearing took place.
        /// </summary>
        [IsoId("_BpsClexYEemioJdkOVFBdw")]
        [DisplayName("Clearing Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrDtTm")]
        #endif
        [IsoXmlTag("ClrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? ClearingDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? ClearingDateTime { get; init; } 
        #else
        public System.DateTime? ClearingDateTime { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
