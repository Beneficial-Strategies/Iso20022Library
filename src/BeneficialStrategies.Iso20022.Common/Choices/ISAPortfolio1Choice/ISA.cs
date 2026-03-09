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
namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio1Choice
{
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. 
    /// The Individual Savings Account (ISA) is provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_Ku_xm_pfEeCLMa5EIHtDrg")]
    [DisplayName("ISA")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ISA : ISAPortfolio1Choice_
    #else
    public partial class ISA : ISAPortfolio1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ISA instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ISA( System.String reqCashComponentIndicator )
        {
            CashComponentIndicator = reqCashComponentIndicator;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Current year of the Investment Saving Plan (ISA) that was issued during the current fiscal year.
        /// </summary>
        [IsoId("_3gENY0XfEeGY6MkiuzuPOA_1731435670")]
        [DisplayName("Current Year")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurYr")]
        #endif
        [IsoXmlTag("CurYr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CurrentYearType1Choice_? CurrentYear { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CurrentYearType1Choice_? CurrentYear { get; init; } 
        #else
        public CurrentYearType1Choice_? CurrentYear { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the ISA contains a cash component asset for transfer.
        /// </summary>
        [IsoId("_3gENZEXfEeGY6MkiuzuPOA_271903704")]
        [DisplayName("Cash Component Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshCmpntInd")]
        #endif
        [IsoXmlTag("CshCmpntInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String CashComponentIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String CashComponentIndicator { get; init; } 
        #else
        public System.String CashComponentIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Selection of investment plans issued during previous years.
        /// </summary>
        [IsoId("_3gNXUEXfEeGY6MkiuzuPOA_-611329583")]
        [DisplayName("Previous Years")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrvsYrs")]
        #endif
        [IsoXmlTag("PrvsYrs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PreviousYear2? PreviousYears { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PreviousYear2? PreviousYears { get; init; } 
        #else
        public PreviousYear2? PreviousYears { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the amounts already subscribed for the current year.
        /// </summary>
        [IsoId("_3gNXUUXfEeGY6MkiuzuPOA_-1608401936")]
        [DisplayName("Current Year Subscription Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurYrSbcptDtls")]
        #endif
        [IsoXmlTag("CurYrSbcptDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SubscriptionInformation1? CurrentYearSubscriptionDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SubscriptionInformation1? CurrentYearSubscriptionDetails { get; init; } 
        #else
        public SubscriptionInformation1? CurrentYearSubscriptionDetails { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
