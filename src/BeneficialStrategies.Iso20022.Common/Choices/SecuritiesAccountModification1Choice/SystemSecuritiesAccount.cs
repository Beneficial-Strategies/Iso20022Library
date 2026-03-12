// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountModification1Choice
{
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_hjLna2liEeGaMcKyqKNRfQ_1200956850")]
    [DisplayName("System Securities Account")]
    public partial record SystemSecuritiesAccount : SecuritiesAccountModification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Legal closing date for the securities account.
        /// </summary>
        [IsoId("_hi4shmliEeGaMcKyqKNRfQ_-1276235554")]
        [DisplayName("Closing Date")]
        [IsoXmlTag("ClsgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ClosingDate { get; init; } 
        
        /// <summary>
        /// Meaning when true: Account is in Hold status.
        /// Meaning when false: Account is in Release status.
        /// </summary>
        [IsoId("_hi4sh2liEeGaMcKyqKNRfQ_-553977920")]
        [DisplayName("Hold Indicator")]
        [IsoXmlTag("HldInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? HoldIndicator { get; init; } 
        
        /// <summary>
        /// Specifies whether the securities account can hold a negative position in a security.
        /// </summary>
        [IsoId("_hjB2YGliEeGaMcKyqKNRfQ_-1625982979")]
        [DisplayName("Negative Position")]
        [IsoXmlTag("NegPos")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? NegativePosition { get; init; } 
        
        /// <summary>
        /// Specifies information to identify securities accounts where allocation instructions are posted.
        /// </summary>
        [IsoId("_hjB2YWliEeGaMcKyqKNRfQ_1482724284")]
        [DisplayName("End Investor Flag")]
        [IsoXmlTag("EndInvstrFlg")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; } 
        
        /// <summary>
        /// Defines how the price is applied to the securities account.
        /// </summary>
        [IsoId("_hjB2YmliEeGaMcKyqKNRfQ_-694614118")]
        [DisplayName("Pricing Scheme")]
        [IsoXmlTag("PricgSchme")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public IsoExact4AlphaNumericText? PricingScheme { get; init; } 
        
        
        #nullable disable
        
    }
}
