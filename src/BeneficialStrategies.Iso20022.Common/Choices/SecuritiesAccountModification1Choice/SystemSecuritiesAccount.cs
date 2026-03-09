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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountModification1Choice
{
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_hjLna2liEeGaMcKyqKNRfQ_1200956850")]
    [DisplayName("System Securities Account")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SystemSecuritiesAccount : SecuritiesAccountModification1Choice_
    #else
    public partial class SystemSecuritiesAccount : SecuritiesAccountModification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Legal closing date for the securities account.
        /// </summary>
        [IsoId("_hi4shmliEeGaMcKyqKNRfQ_-1276235554")]
        [DisplayName("Closing Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClsgDt")]
        #endif
        [IsoXmlTag("ClsgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ClosingDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ClosingDate { get; init; } 
        #else
        public System.DateOnly? ClosingDate { get; set; } 
        #endif
        
        /// <summary>
        /// Meaning when true: Account is in Hold status.
        /// Meaning when false: Account is in Release status.
        /// </summary>
        [IsoId("_hi4sh2liEeGaMcKyqKNRfQ_-553977920")]
        [DisplayName("Hold Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HldInd")]
        #endif
        [IsoXmlTag("HldInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? HoldIndicator { get; init; } 
        #else
        public System.String? HoldIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the securities account can hold a negative position in a security.
        /// </summary>
        [IsoId("_hjB2YGliEeGaMcKyqKNRfQ_-1625982979")]
        [DisplayName("Negative Position")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NegPos")]
        #endif
        [IsoXmlTag("NegPos")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? NegativePosition { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? NegativePosition { get; init; } 
        #else
        public System.String? NegativePosition { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies information to identify securities accounts where allocation instructions are posted.
        /// </summary>
        [IsoId("_hjB2YWliEeGaMcKyqKNRfQ_1482724284")]
        [DisplayName("End Investor Flag")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EndInvstrFlg")]
        #endif
        [IsoXmlTag("EndInvstrFlg")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EndInvestorFlag { get; init; } 
        #else
        public System.String? EndInvestorFlag { get; set; } 
        #endif
        
        /// <summary>
        /// Defines how the price is applied to the securities account.
        /// </summary>
        [IsoId("_hjB2YmliEeGaMcKyqKNRfQ_-694614118")]
        [DisplayName("Pricing Scheme")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PricgSchme")]
        #endif
        [IsoXmlTag("PricgSchme")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PricingScheme { get; init; } 
        #else
        public System.String? PricingScheme { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
