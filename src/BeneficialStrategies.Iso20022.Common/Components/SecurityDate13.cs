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
[IsoId("_ckAjV5KQEeWHWpTQn1FFVg")]
[DisplayName("Security Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityDate13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityDate13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityDate13( DateAndDateTimeChoice_ reqPostingDate )
    {
        PostingDate = reqPostingDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_ckAjWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDt")]
    #endif
    [IsoXmlTag("PstngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ PostingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ PostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ PostingDate { get; init; } 
    #else
    public DateAndDateTimeChoice_ PostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [IsoId("_ckAjYZKQEeWHWpTQn1FFVg")]
    [DisplayName("Available Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblDt")]
    #endif
    [IsoXmlTag("AvlblDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat34Choice_? AvailableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_? AvailableDate { get; init; } 
    #else
    public DateFormat34Choice_? AvailableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_ckAjaZKQEeWHWpTQn1FFVg")]
    [DisplayName("Pari Passu Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrpssDt")]
    #endif
    [IsoXmlTag("PrpssDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat34Choice_? PariPassuDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_? PariPassuDate { get; init; } 
    #else
    public DateFormat34Choice_? PariPassuDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_ckAjcZKQEeWHWpTQn1FFVg")]
    [DisplayName("Dividend Ranking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddRnkgDt")]
    #endif
    [IsoXmlTag("DvddRnkgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat34Choice_? DividendRankingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_? DividendRankingDate { get; init; } 
    #else
    public DateFormat34Choice_? DividendRankingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_ckAjeZKQEeWHWpTQn1FFVg")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat34Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat34Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_ckAjgZKQEeWHWpTQn1FFVg")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat34Choice_? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_? PaymentDate { get; init; } 
    #else
    public DateFormat34Choice_? PaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
