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
/// Specifies the debit instrument.
/// </summary>
[IsoId("_u39RcSQTEeWXFu0Jt0z3Xw")]
[DisplayName("Debt Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebtInstrument2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebtInstrument2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebtInstrument2( ActiveOrHistoricCurrencyAndAmount reqTotalIssuedNominalAmount,ActiveOrHistoricCurrencyAndAmount reqNominalValuePerUnit,InterestRate6Choice_ reqInterestRate )
    {
        TotalIssuedNominalAmount = reqTotalIssuedNominalAmount;
        NominalValuePerUnit = reqNominalValuePerUnit;
        InterestRate = reqInterestRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total issued nominal amount in monetary value.
    /// </summary>
    [IsoId("_vhWMmyQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Total Issued Nominal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlIssdNmnlAmt")]
    #endif
    [IsoXmlTag("TtlIssdNmnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount TotalIssuedNominalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount TotalIssuedNominalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount TotalIssuedNominalAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount TotalIssuedNominalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Maturity date of the financial instrument.
    /// </summary>
    [IsoId("_vhWMmSQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Nominal value of each instrument. If not available, the minimum traded value should be populated.
    /// </summary>
    [IsoId("_vhWMlyQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Nominal Value Per Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmnlValPerUnit")]
    #endif
    [IsoXmlTag("NmnlValPerUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount NominalValuePerUnit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount NominalValuePerUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount NominalValuePerUnit { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount NominalValuePerUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate of the debt instrument.
    /// </summary>
    [IsoId("_vhWMkyQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestRate6Choice_ InterestRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestRate6Choice_ InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate6Choice_ InterestRate { get; init; } 
    #else
    public InterestRate6Choice_ InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Seniority for a specific debt instrument.
    /// </summary>
    [IsoId("_vhWMlSQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Debt Seniority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DebtSnrty")]
    #endif
    [IsoXmlTag("DebtSnrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrumentSeniorityType1Code? DebtSeniority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrumentSeniorityType1Code? DebtSeniority { get; init; } 
    #else
    public DebtInstrumentSeniorityType1Code? DebtSeniority { get; set; } 
    #endif
    
    
    #nullable disable
    
}
