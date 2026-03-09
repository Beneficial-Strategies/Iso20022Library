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
/// Specifies corporate action dates.
/// </summary>
[IsoId("_TfjOFNp-Ed-ak6NoX_4Aeg_1806455399")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_TfjOFdp-Ed-ak6NoX_4Aeg_1920050127")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXRateFxgDt")]
    #endif
    [IsoXmlTag("FXRateFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #else
    public DateFormat4Choice_? ForeignExchangeRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_TfjOFtp-Ed-ak6NoX_4Aeg_-1783188999")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? ValueDate { get; init; } 
    #else
    public DateFormat4Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TfjOF9p-Ed-ak6NoX_4Aeg_104425986")]
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
    /// Date/time at which a payment can be made, eg, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_TfjOGNp-Ed-ak6NoX_4Aeg_-19325862")]
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
