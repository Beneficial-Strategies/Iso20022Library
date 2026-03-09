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
/// Reporting per financial instrument.
/// </summary>
[IsoId("_UB99gQllEeuQ1MenzX1l-g")]
[DisplayName("Financial Instrument Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentDetails38
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentDetails38 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentDetails38( SecurityIdentification19 reqFinancialInstrumentIdentification )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_UPgDMQllEeuQ1MenzX1l-g")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_UPgDNQllEeuQ1MenzX1l-g")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFndsFinInstrmAttrbts")]
    #endif
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument72? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument72? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrument72? InvestmentFundsFinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_UPgDNwllEeuQ1MenzX1l-g")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceInformation21? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceInformation21? PriceDetails { get; init; } 
    #else
    public PriceInformation21? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_UPgDOwllEeuQ1MenzX1l-g")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace3? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_UPgDPwllEeuQ1MenzX1l-g")]
    [DisplayName("Opening Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngBal")]
    #endif
    [IsoXmlTag("OpngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OpeningBalance3? OpeningBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningBalance3? OpeningBalance { get; init; } 
    #else
    public OpeningBalance3? OpeningBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_UPgDQwllEeuQ1MenzX1l-g")]
    [DisplayName("Closing Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgBal")]
    #endif
    [IsoXmlTag("ClsgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosingBalance3? ClosingBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingBalance3? ClosingBalance { get; init; } 
    #else
    public ClosingBalance3? ClosingBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_UPgDRwllEeuQ1MenzX1l-g")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    public ValueList<Transaction114> Transaction { get; init; } = new ValueList<Transaction114>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UPgDRwllEeuQ1MenzX1l-g
    
    
    #nullable disable
    
}
