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
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature4Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_6j9NM7sAEea-m5tPqiasmQ")]
    [DisplayName("Non Financial Institution")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NonFinancialInstitution : CounterpartyTradeNature4Choice_
    #else
    public partial class NonFinancialInstitution : CounterpartyTradeNature4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NonFinancialInstitution instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NonFinancialInstitution( System.String reqClearingThreshold,System.String reqDirectlyLinkedActivity )
        {
            ClearingThreshold = reqClearingThreshold;
            DirectlyLinkedActivity = reqDirectlyLinkedActivity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
        /// </summary>
        [IsoId("_oNJQcIOdEeW2EdhfKzeL1w")]
        [DisplayName("Sector")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sctr")]
        #endif
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNACEDomainIdentifier? Sector { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Sector { get; init; } 
        #else
        public System.String? Sector { get; set; } 
        #endif
        
        /// <summary>
        /// Information whether the reporting counterparty is above the clearing threshold referred to the regulation.
        /// </summary>
        [IsoId("_88jHAfP7EeS_qLctCs2aRQa")]
        [DisplayName("Clearing Threshold")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrThrshld")]
        #endif
        [IsoXmlTag("ClrThrshld")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator ClearingThreshold { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ClearingThreshold { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ClearingThreshold { get; init; } 
        #else
        public System.String ClearingThreshold { get; set; } 
        #endif
        
        /// <summary>
        /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the reporting counterparty&apos;s commercial or treasury financing activity.
        /// </summary>
        [IsoId("_HsMfAIOjEeWqmeP8QNJBew")]
        [DisplayName("Directly Linked Activity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrctlyLkdActvty")]
        #endif
        [IsoXmlTag("DrctlyLkdActvty")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator DirectlyLinkedActivity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String DirectlyLinkedActivity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String DirectlyLinkedActivity { get; init; } 
        #else
        public System.String DirectlyLinkedActivity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
