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
/// Cash premium made available if the securities holder consents or participates to an event.
/// </summary>
[IsoId("_TjIGidp-Ed-ak6NoX_4Aeg_590255137")]
[DisplayName("Incentive Premium")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IncentivePremium3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IncentivePremium3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IncentivePremium3( PriceRateOrAmountChoice_ reqAmount,IncentivePremiumType1Choice_ reqType )
    {
        Amount = reqAmount;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Description of the premium.
    /// </summary>
    [IsoId("_TjIGitp-Ed-ak6NoX_4Aeg_590255168")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Cash premium paid per security, per vote or per attendee.
    /// </summary>
    [IsoId("_TjIGi9p-Ed-ak6NoX_4Aeg_590255198")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmountChoice_ Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmountChoice_ Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmountChoice_ Amount { get; init; } 
    #else
    public PriceRateOrAmountChoice_ Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Type of incentive premium.
    /// </summary>
    [IsoId("_TjIGjNp-Ed-ak6NoX_4Aeg_590255477")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IncentivePremiumType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IncentivePremiumType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncentivePremiumType1Choice_ Type { get; init; } 
    #else
    public IncentivePremiumType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time for the payment of the premium.
    /// </summary>
    [IsoId("_TjIGjdp-Ed-ak6NoX_4Aeg_591175570")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat3Choice_? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat3Choice_? PaymentDate { get; init; } 
    #else
    public DateFormat3Choice_? PaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
