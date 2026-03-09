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
/// Commercial agreement in which the buyer agrees to pay the seller an amount of cash. Some aspects of the payment may be defined in the agreement, eg, the method of the payment.
/// </summary>
[IsoId("_TJMjkNp-Ed-ak6NoX_4Aeg_-1139165617")]
[DisplayName("Premium Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PremiumAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PremiumAmount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PremiumAmount2( ActiveOrHistoricCurrencyAndAmount reqAmount,System.DateOnly reqSettlementDate )
    {
        Amount = reqAmount;
        SettlementDate = reqSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the calculation method of the premium amount.
    /// </summary>
    [IsoId("_TJMjkdp-Ed-ak6NoX_4Aeg_822493926")]
    [DisplayName("Premium Quote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmQt")]
    #endif
    [IsoXmlTag("PrmQt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PremiumQuote1Choice_? PremiumQuote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PremiumQuote1Choice_? PremiumQuote { get; init; } 
    #else
    public PremiumQuote1Choice_? PremiumQuote { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the calculation of the premium amount on the basis of the premium quote and one of the amounts of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_TJMjktp-Ed-ak6NoX_4Aeg_-1139165615")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the premium must be settled.
    /// </summary>
    [IsoId("_TJMjk9p-Ed-ak6NoX_4Aeg_-1139165592")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SettlementDate { get; init; } 
    #else
    public System.DateOnly SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party that settles the premium amount on behalf of the paying party. It may contain the BIC of a central settlement system, eg. CLSBUS33.
    /// </summary>
    [IsoId("_TJMjlNp-Ed-ak6NoX_4Aeg_-1139165531")]
    [DisplayName("Settlement Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPty")]
    #endif
    [IsoXmlTag("SttlmPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8Choice_? SettlementParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_? SettlementParty { get; init; } 
    #else
    public PartyIdentification8Choice_? SettlementParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
