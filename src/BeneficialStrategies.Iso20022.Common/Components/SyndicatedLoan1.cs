// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loan offered by a group of lenders (called a syndicate) who work together to lend an amount of money to a single borrower.
/// </summary>
[IsoId("_0lm3AdOKEeSQ_-lmj1tzfw")]
[DisplayName("Syndicated Loan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SyndicatedLoan1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SyndicatedLoan1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SyndicatedLoan1( TradeParty2 reqBorrower )
    {
        Borrower = reqBorrower;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party which obtains the loan.
    /// </summary>
    [IsoId("_DsfWkNOLEeSQ_-lmj1tzfw")]
    [DisplayName("Borrower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brrwr")]
    #endif
    [IsoXmlTag("Brrwr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeParty2 Borrower { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeParty2 Borrower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty2 Borrower { get; init; } 
    #else
    public TradeParty2 Borrower { get; set; } 
    #endif
    
    /// <summary>
    /// Party which provides an amount of money available to others to borrow.
    /// </summary>
    [IsoId("_OmeSE-AnEeS-z4mncO1qQg")]
    [DisplayName("Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lndr")]
    #endif
    [IsoXmlTag("Lndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty2? Lender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty2? Lender { get; init; } 
    #else
    public TradeParty2? Lender { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the part in the syndicated loan.
    /// </summary>
    [IsoId("_zxakgNOLEeSQ_-lmj1tzfw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Share of the part in the syndicated loan.
    /// </summary>
    [IsoId("_4p1sAtOLEeSQ_-lmj1tzfw")]
    [DisplayName("Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Shr")]
    #endif
    [IsoXmlTag("Shr")]
    [IsoSimpleType(IsoSimpleType.Percentage)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentage? Share { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Share { get; init; } 
    #else
    public System.Decimal? Share { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_sLJEwdONEeSQ_-lmj1tzfw")]
    [DisplayName("Exchange Rate Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateInf")]
    #endif
    [IsoXmlTag("XchgRateInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    #else
    public ExchangeRate1? ExchangeRateInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
