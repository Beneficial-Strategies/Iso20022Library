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
[IsoId("_LbjN8fo9EeCdeaSQAR2tKw")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDate23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDate23( DateFormat19Choice_ reqPaymentDate )
    {
        PaymentDate = reqPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_LbjN9_o9EeCdeaSQAR2tKw")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat19Choice_ PaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat19Choice_ PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_ PaymentDate { get; init; } 
    #else
    public DateFormat19Choice_ PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_LbjOAfo9EeCdeaSQAR2tKw")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat11Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat11Choice_? ValueDate { get; init; } 
    #else
    public DateFormat11Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_LbjOC_o9EeCdeaSQAR2tKw")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXRateFxgDt")]
    #endif
    [IsoXmlTag("FXRateFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #else
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_LbjOFfo9EeCdeaSQAR2tKw")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat19Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
