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
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_2nJhkZidEe2f7NHvXATP5g")]
[DisplayName("Security Instrument Description")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityInstrumentDescription22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityInstrumentDescription22 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityInstrumentDescription22( SecurityInstrumentDescription23 reqFinancialInstrumentGeneralAttributes,DerivativeInstrument6 reqDerivativeInstrumentAttributes )
    {
        FinancialInstrumentGeneralAttributes = reqFinancialInstrumentGeneralAttributes;
        DerivativeInstrumentAttributes = reqDerivativeInstrumentAttributes;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Attributes and characteristics of the financial instrument.
    /// </summary>
    [IsoId("_2oQU0ZidEe2f7NHvXATP5g")]
    [DisplayName("Financial Instrument General Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmGnlAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmGnlAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
    #else
    public SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes specific to debt instruments.
    /// </summary>
    [IsoId("_2oQU05idEe2f7NHvXATP5g")]
    [DisplayName("Debt Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DebtInstrmAttrbts")]
    #endif
    [IsoXmlTag("DebtInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
    #else
    public DebtInstrument4? DebtInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes specific to derivative instruments.
    /// </summary>
    [IsoId("_2oQU1ZidEe2f7NHvXATP5g")]
    [DisplayName("Derivative Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivInstrmAttrbts")]
    #endif
    [IsoXmlTag("DerivInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
    #else
    public DerivativeInstrument6 DerivativeInstrumentAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
