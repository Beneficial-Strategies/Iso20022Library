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
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
[IsoId("_g7QKsRRfEeOKWo1NF21OVw")]
[DisplayName("Payment Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstrument12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstrument12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstrument12( string reqSettlementCurrency,PaymentInstrument16Choice_ reqPaymentInstrument )
    {
        SettlementCurrency = reqSettlementCurrency;
        PaymentInstrument = reqPaymentInstrument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_hTMwoxRfEeOKWo1NF21OVw")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SettlementCurrency { get; init; } 
    #else
    public string SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [IsoId("_hTMwpRRfEeOKWo1NF21OVw")]
    [DisplayName("Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrm")]
    #endif
    [IsoXmlTag("PmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentInstrument16Choice_ PaymentInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentInstrument16Choice_ PaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument16Choice_ PaymentInstrument { get; init; } 
    #else
    public PaymentInstrument16Choice_ PaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    [IsoId("_hTMwpxRfEeOKWo1NF21OVw")]
    [DisplayName("Dividend Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddPctg")]
    #endif
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageBoundedRate? DividendPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DividendPercentage { get; init; } 
    #else
    public System.Decimal? DividendPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
