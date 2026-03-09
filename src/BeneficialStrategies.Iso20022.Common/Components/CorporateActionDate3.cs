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
/// Specifies coprorate action dates.
/// </summary>
[IsoId("_TfQTJNp-Ed-ak6NoX_4Aeg_901406419")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time at which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TfQTJdp-Ed-ak6NoX_4Aeg_93344284")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? PaymentDate { get; init; } 
    #else
    public DateFormat4Choice_? PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which securities become available for sale.
    /// </summary>
    [IsoId("_TfQTJtp-Ed-ak6NoX_4Aeg_-1737531965")]
    [DisplayName("Available Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblDt")]
    #endif
    [IsoXmlTag("AvlblDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? AvailableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? AvailableDate { get; init; } 
    #else
    public DateFormat4Choice_? AvailableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_TfQTJ9p-Ed-ak6NoX_4Aeg_1745390082")]
    [DisplayName("Dividend Ranking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddRnkgDt")]
    #endif
    [IsoXmlTag("DvddRnkgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? DividendRankingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? DividendRankingDate { get; init; } 
    #else
    public DateFormat4Choice_? DividendRankingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_TfQTKNp-Ed-ak6NoX_4Aeg_538944912")]
    [DisplayName("Pari Passu Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrpssDt")]
    #endif
    [IsoXmlTag("PrpssDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? PariPassuDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? PariPassuDate { get; init; } 
    #else
    public DateFormat4Choice_? PariPassuDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which new securities begin trading.
    /// </summary>
    [IsoId("_TfQTKdp-Ed-ak6NoX_4Aeg_-1737531873")]
    [DisplayName("First Dealing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstDealgDt")]
    #endif
    [IsoXmlTag("FrstDealgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? FirstDealingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? FirstDealingDate { get; init; } 
    #else
    public DateFormat4Choice_? FirstDealingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a payment can be made, eg, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_TfaEINp-Ed-ak6NoX_4Aeg_21312129")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat4Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
