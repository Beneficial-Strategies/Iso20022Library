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
    /// Indicates that counterparty is a financial institution.
    /// </summary>
    [IsoId("_1z1A8Qz1Ee2YoLD-1vFj0g")]
    [DisplayName("Financial Institution")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FinancialInstitution : CounterpartyTradeNature15Choice_
    #else
    public partial class FinancialInstitution : CounterpartyTradeNature15Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the nature of the counterparty business activities. 
        /// </summary>
        [IsoId("_UgEEwAz2Ee2YoLD-1vFj0g")]
        [DisplayName("Sector")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sctr")]
        #endif
        [IsoXmlTag("Sctr")]
        public ValueList<FinancialPartyClassification2Choice_> Sector { get; init; } = new ValueList<FinancialPartyClassification2Choice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _UgEEwAz2Ee2YoLD-1vFj0g
        
        /// <summary>
        /// Information whether the counterparty is above the clearing threshold.
        /// Usage: If the element is not present, the ClearingThreshold is False.
        /// </summary>
        [IsoId("_W7SxEAz2Ee2YoLD-1vFj0g")]
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
        
        
        #nullable disable
        
    }
}
