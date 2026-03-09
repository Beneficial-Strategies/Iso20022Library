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
/// Specifies security date details.
/// </summary>
[IsoId("_k9sTqc3xEee5nJBZsW8MFQ")]
[DisplayName("Security Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityDate18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityDate18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityDate18( DateFormat49Choice_ reqPaymentDate )
    {
        PaymentDate = reqPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_k9sTrc3xEee5nJBZsW8MFQ")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat49Choice_ PaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat49Choice_ PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_ PaymentDate { get; init; } 
    #else
    public DateFormat49Choice_ PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [IsoId("_k9sTtc3xEee5nJBZsW8MFQ")]
    [DisplayName("Available Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblDt")]
    #endif
    [IsoXmlTag("AvlblDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? AvailableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? AvailableDate { get; init; } 
    #else
    public DateFormat49Choice_? AvailableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_k9sTvc3xEee5nJBZsW8MFQ")]
    [DisplayName("Dividend Ranking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddRnkgDt")]
    #endif
    [IsoXmlTag("DvddRnkgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? DividendRankingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? DividendRankingDate { get; init; } 
    #else
    public DateFormat49Choice_? DividendRankingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_k9sTxc3xEee5nJBZsW8MFQ")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat49Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_k9sTzc3xEee5nJBZsW8MFQ")]
    [DisplayName("Pari Passu Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrpssDt")]
    #endif
    [IsoXmlTag("PrpssDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? PariPassuDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? PariPassuDate { get; init; } 
    #else
    public DateFormat49Choice_? PariPassuDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the securities to be reorganised will cease to be tradeable.
    /// </summary>
    [IsoId("_k9sT1c3xEee5nJBZsW8MFQ")]
    [DisplayName("Last Trading Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastTradgDt")]
    #endif
    [IsoXmlTag("LastTradgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? LastTradingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? LastTradingDate { get; init; } 
    #else
    public DateFormat49Choice_? LastTradingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
