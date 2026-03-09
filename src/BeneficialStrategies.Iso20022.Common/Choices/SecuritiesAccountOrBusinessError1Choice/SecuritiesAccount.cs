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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrBusinessError1Choice
{
    /// <summary>
    /// Choice between data concerning securities account retrieved or business error.
    /// </summary>
    [IsoId("_hjB2cmliEeGaMcKyqKNRfQ_-884179545")]
    [DisplayName("Securities Account")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesAccount : SecuritiesAccountOrBusinessError1Choice_
    #else
    public partial class SecuritiesAccount : SecuritiesAccountOrBusinessError1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesAccount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesAccount( SystemPartyIdentification3 reqAccountOwner )
        {
            AccountOwner = reqAccountOwner;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Legal opening date for the securities account.
        /// </summary>
        [IsoId("_hiu7eGliEeGaMcKyqKNRfQ_-383671976")]
        [DisplayName("Opening Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OpngDt")]
        #endif
        [IsoXmlTag("OpngDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? OpeningDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? OpeningDate { get; init; } 
        #else
        public System.DateOnly? OpeningDate { get; set; } 
        #endif
        
        /// <summary>
        /// Legal closing date for the securities account.
        /// </summary>
        [IsoId("_hiu7eWliEeGaMcKyqKNRfQ_1428226249")]
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
        [IsoId("_hiu7emliEeGaMcKyqKNRfQ_27345752")]
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
        [IsoId("_hiu7e2liEeGaMcKyqKNRfQ_-1011362976")]
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
        /// Specifies the type of the securities account.
        /// </summary>
        [IsoId("_hiu7fGliEeGaMcKyqKNRfQ_-568374484")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemSecuritiesAccountType1Code? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemSecuritiesAccountType1Code? Type { get; init; } 
        #else
        public SystemSecuritiesAccountType1Code? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_hiu7fWliEeGaMcKyqKNRfQ_-118201799")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SystemPartyIdentification3 AccountOwner { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SystemPartyIdentification3 AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyIdentification3 AccountOwner { get; init; } 
        #else
        public SystemPartyIdentification3 AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the type of the party owning the account.
        /// </summary>
        [IsoId("_hiu7fmliEeGaMcKyqKNRfQ_230359997")]
        [DisplayName("Party Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PtyTp")]
        #endif
        [IsoXmlTag("PtyTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemPartyType1Code? PartyType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyType1Code? PartyType { get; init; } 
        #else
        public SystemPartyType1Code? PartyType { get; set; } 
        #endif
        
        /// <summary>
        /// Additional attributes defined by a central security depositary for a party.
        /// </summary>
        [IsoId("_hiu7f2liEeGaMcKyqKNRfQ_-1676748336")]
        [DisplayName("Market Specific Attribute")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MktSpcfcAttr")]
        #endif
        [IsoXmlTag("MktSpcfcAttr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
        #else
        public MarketSpecificAttribute1? MarketSpecificAttribute { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
        /// </summary>
        [IsoId("_hiu7gGliEeGaMcKyqKNRfQ_954256058")]
        [DisplayName("Restriction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rstrctn")]
        #endif
        [IsoXmlTag("Rstrctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemRestriction1? Restriction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemRestriction1? Restriction { get; init; } 
        #else
        public SystemRestriction1? Restriction { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies information to identify securities accounts where allocation instructions are posted.
        /// </summary>
        [IsoId("_hiu7gWliEeGaMcKyqKNRfQ_-162553441")]
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
        [IsoId("_hiu7gmliEeGaMcKyqKNRfQ_1190269281")]
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
