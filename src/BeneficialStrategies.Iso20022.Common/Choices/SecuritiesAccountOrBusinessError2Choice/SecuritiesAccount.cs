// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrBusinessError2Choice
{
    /// <summary>
    /// Choice between data concerning securities account retrieved or business error.
    /// </summary>
    [IsoId("_AKfxAfA0EeWPfa2xBhBfLQ")]
    [DisplayName("Securities Account")]
    public partial record SecuritiesAccount : SecuritiesAccountOrBusinessError2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Legal opening date for the securities account.
        /// </summary>
        [IsoId("_hiu7eGliEeGaMcKyqKNRfQ_-383671976")]
        [DisplayName("Opening Date")]
        [IsoXmlTag("OpngDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? OpeningDate { get; init; } 
        
        /// <summary>
        /// Legal closing date for the securities account.
        /// </summary>
        [IsoId("_hiu7eWliEeGaMcKyqKNRfQ_1428226249")]
        [DisplayName("Closing Date")]
        [IsoXmlTag("ClsgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ClosingDate { get; init; } 
        
        /// <summary>
        /// Meaning when true: Account is in Hold status.
        /// Meaning when false: Account is in Release status.
        /// </summary>
        [IsoId("_hiu7emliEeGaMcKyqKNRfQ_27345752")]
        [DisplayName("Hold Indicator")]
        [IsoXmlTag("HldInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
        
        /// <summary>
        /// Specifies whether the securities account can hold a negative position in a security.
        /// </summary>
        [IsoId("_hiu7e2liEeGaMcKyqKNRfQ_-1011362976")]
        [DisplayName("Negative Position")]
        [IsoXmlTag("NegPos")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? NegativePosition { get; init; } 
        
        /// <summary>
        /// Specifies the type of the securities account.
        /// </summary>
        [IsoId("_hiu7fGliEeGaMcKyqKNRfQ_-568374484")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public SystemSecuritiesAccountType1Code? Type { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_hiu7fWliEeGaMcKyqKNRfQ_-118201799")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public required SystemPartyIdentification3 AccountOwner { get; init; } 
        
        /// <summary>
        /// Specifies the type of the party owning the account.
        /// </summary>
        [IsoId("_hiu7fmliEeGaMcKyqKNRfQ_230359997")]
        [DisplayName("Party Type")]
        [IsoXmlTag("PtyTp")]
        public SystemPartyType1Code? PartyType { get; init; } 
        
        /// <summary>
        /// Additional attributes defined by a central security depositary for a party.
        /// </summary>
        [IsoId("_hiu7f2liEeGaMcKyqKNRfQ_-1676748336")]
        [DisplayName("Market Specific Attribute")]
        [IsoXmlTag("MktSpcfcAttr")]
        public MarketSpecificAttribute1? MarketSpecificAttribute { get; init; } 
        
        /// <summary>
        /// Defines the specific processing characteristics for a securities account to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
        /// </summary>
        [IsoId("_hiu7gGliEeGaMcKyqKNRfQ_954256058")]
        [DisplayName("Restriction")]
        [IsoXmlTag("Rstrctn")]
        public SystemRestriction1? Restriction { get; init; } 
        
        /// <summary>
        /// Specifies information to identify securities accounts where allocation instructions are posted.
        /// </summary>
        [IsoId("_hiu7gWliEeGaMcKyqKNRfQ_-162553441")]
        [DisplayName("End Investor Flag")]
        [IsoXmlTag("EndInvstrFlg")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
        
        /// <summary>
        /// Defines how the price is applied to the securities account.
        /// </summary>
        [IsoId("_hiu7gmliEeGaMcKyqKNRfQ_1190269281")]
        [DisplayName("Pricing Scheme")]
        [IsoXmlTag("PricgSchme")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
        
        
        #nullable disable
        
    }
}
