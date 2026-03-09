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
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_qZQIYMhiEeadgvwNGwK05w")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes88
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributes88 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributes88( Frequency11Code reqPaymentFrequency )
    {
        PaymentFrequency = reqPaymentFrequency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies fixed contract term, or the maximum contract term cleared.
    /// </summary>
    [IsoId("_1U8Z4MhiEeadgvwNGwK05w")]
    [DisplayName("Contract Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTerm")]
    #endif
    [IsoXmlTag("CtrctTerm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateContractTerm1? ContractTerm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateContractTerm1? ContractTerm { get; init; } 
    #else
    public InterestRateContractTerm1? ContractTerm { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether certain terms of the derivative are defined purely according to exchange specifications or can be user defined.
    /// </summary>
    [IsoId("_4ICzoMhiEeadgvwNGwK05w")]
    [DisplayName("Standardisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stdstn")]
    #endif
    [IsoXmlTag("Stdstn")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<Standardisation1Code> Standardisation { get; init; } = new SimpleValueList<Standardisation1Code>(){};
    
    /// <summary>
    /// Schedule for leg payments.
    /// </summary>
    [IsoId("_aY0VMMhjEeadgvwNGwK05w")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency11Code PaymentFrequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency11Code PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency11Code PaymentFrequency { get; init; } 
    #else
    public Frequency11Code PaymentFrequency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
