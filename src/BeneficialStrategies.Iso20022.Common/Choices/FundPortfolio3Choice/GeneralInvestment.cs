// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio3Choice
{
    /// <summary>
    /// Portfolio is a general investment.
    /// </summary>
    [IsoId("_U5MVg07cEeifNrXGwadPmg")]
    [DisplayName("General Investment")]
    public partial record GeneralInvestment : FundPortfolio3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of investment.
        /// </summary>
        [IsoId("_lboOIE4NEeiQHa-q1Uephw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public GeneralInvestmentAccountType1Choice_? Type { get; init; } 
        
        /// <summary>
        /// Amount of money invested.
        /// </summary>
        [IsoId("_JnLksqqwEeirN7VYUwRpeQ")]
        [DisplayName("Current Investment Amount")]
        [IsoXmlTag("CurInvstmtAmt")]
        public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
        
        /// <summary>
        /// Estimated value of the assets.
        /// </summary>
        [IsoId("_JnLks6qwEeirN7VYUwRpeQ")]
        [DisplayName("Estimated Value")]
        [IsoXmlTag("EstmtdVal")]
        public DateAndAmount2? EstimatedValue { get; init; } 
        
        /// <summary>
        /// Additional information about the portfolio.
        /// </summary>
        [IsoId("_yHL6wE4NEeiQHa-q1Uephw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
