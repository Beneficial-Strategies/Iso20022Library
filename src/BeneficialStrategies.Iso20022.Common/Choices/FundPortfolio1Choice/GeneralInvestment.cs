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
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio1Choice
{
    /// <summary>
    /// Portfolio is a general investment.
    /// </summary>
    [IsoId("_ibqr004HEeiQHa-q1Uephw")]
    [DisplayName("General Investment")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record GeneralInvestment : FundPortfolio1Choice_
    #else
    public partial class GeneralInvestment : FundPortfolio1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of investment.
        /// </summary>
        [IsoId("_lboOIE4NEeiQHa-q1Uephw")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GeneralInvestmentAccountType1Choice_? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GeneralInvestmentAccountType1Choice_? Type { get; init; } 
        #else
        public GeneralInvestmentAccountType1Choice_? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money invested.
        /// </summary>
        [IsoId("_JnLksqqwEeirN7VYUwRpeQ")]
        [DisplayName("Current Investment Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurInvstmtAmt")]
        #endif
        [IsoXmlTag("CurInvstmtAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
        #else
        public ActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Estimated value of the assets.
        /// </summary>
        [IsoId("_JnLks6qwEeirN7VYUwRpeQ")]
        [DisplayName("Estimated Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EstmtdVal")]
        #endif
        [IsoXmlTag("EstmtdVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndAmount2? EstimatedValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndAmount2? EstimatedValue { get; init; } 
        #else
        public DateAndAmount2? EstimatedValue { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the portfolio.
        /// </summary>
        [IsoId("_yHL6wE4NEeiQHa-q1Uephw")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #else
        public AdditionalInformation15? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
