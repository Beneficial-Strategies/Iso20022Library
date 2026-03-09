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
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature15Choice
{
    /// <summary>
    /// Indicates that counterparty is a non financial institution.
    /// </summary>
    [IsoId("_1z1A8wz1Ee2YoLD-1vFj0g")]
    [DisplayName("Non Financial Institution")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NonFinancialInstitution : CounterpartyTradeNature15Choice_
    #else
    public partial class NonFinancialInstitution : CounterpartyTradeNature15Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
        /// </summary>
        [IsoId("_ygiOwQz2Ee2YoLD-1vFj0g")]
        [DisplayName("Sector")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sctr")]
        #endif
        [IsoXmlTag("Sctr")]
        public ValueList<GenericIdentification175> Sector { get; init; } = new ValueList<GenericIdentification175>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _ygiOwQz2Ee2YoLD-1vFj0g
        
        /// <summary>
        /// Information whether the counterparty is above the clearing threshold.
        /// Usage: If the element is not present, the ClearingThreshold is False.
        /// </summary>
        [IsoId("_ygiOxQz2Ee2YoLD-1vFj0g")]
        [DisplayName("Clearing Threshold")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrThrshld")]
        #endif
        [IsoXmlTag("ClrThrshld")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? ClearingThreshold { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ClearingThreshold { get; init; } 
        #else
        public System.String? ClearingThreshold { get; set; } 
        #endif
        
        /// <summary>
        /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the counterparty&apos;s commercial or treasury financing activity.
        /// Usage: If the element is not present, the DirectlyLinkedActivity is False.
        /// </summary>
        [IsoId("_ygiOxwz2Ee2YoLD-1vFj0g")]
        [DisplayName("Directly Linked Activity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrctlyLkdActvty")]
        #endif
        [IsoXmlTag("DrctlyLkdActvty")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? DirectlyLinkedActivity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DirectlyLinkedActivity { get; init; } 
        #else
        public System.String? DirectlyLinkedActivity { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the counterparty is an entity established pursuant to federal law like for example a federal authority or a government corporation.
        /// Usage: If the element is not present, the FederalInstitution is False.
        /// </summary>
        [IsoId("_2Oz3UAz2Ee2YoLD-1vFj0g")]
        [DisplayName("Federal Institution")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FdrlInstn")]
        #endif
        [IsoXmlTag("FdrlInstn")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? FederalInstitution { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? FederalInstitution { get; init; } 
        #else
        public System.String? FederalInstitution { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
