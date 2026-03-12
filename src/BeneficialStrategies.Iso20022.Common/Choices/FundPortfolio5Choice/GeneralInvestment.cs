// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio5Choice
{
    /// <summary>
    /// Portfolio is a general investment.
    /// </summary>
    [IsoId("_nxCyo5NMEemQB_8XA98K0Q")]
    [DisplayName("General Investment")]
    public partial record GeneralInvestment : FundPortfolio5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of investment.
        /// </summary>
        [IsoId("_h9fnMZNuEembCsVG-3f_AA")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public GeneralInvestmentAccountType2Choice_? Type { get; init; } 
        
        /// <summary>
        /// Specifies whether the account is, for example, in a nominee name or own name.
        /// </summary>
        [IsoId("_J7IRsDOQEeqjy7_SkdcoGg")]
        [DisplayName("Ownership Type")]
        [IsoXmlTag("OwnrshTp")]
        public AccountOwnershipType6Code? OwnershipType { get; init; } 
        
        /// <summary>
        /// Amount of money invested.
        /// </summary>
        [IsoId("_h9fnM5NuEembCsVG-3f_AA")]
        [DisplayName("Current Investment Amount")]
        [IsoXmlTag("CurInvstmtAmt")]
        public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
        
        /// <summary>
        /// Estimated value of the assets.
        /// </summary>
        [IsoId("_h9fnNZNuEembCsVG-3f_AA")]
        [DisplayName("Estimated Value")]
        [IsoXmlTag("EstmtdVal")]
        public DateAndAmount2? EstimatedValue { get; init; } 
        
        /// <summary>
        /// Additional information about the portfolio.
        /// </summary>
        [IsoId("_h9fnN5NuEembCsVG-3f_AA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
