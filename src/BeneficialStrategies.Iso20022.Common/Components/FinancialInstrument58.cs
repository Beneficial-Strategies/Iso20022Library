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
/// Specifies underlying instruments or index a derivative has.
/// </summary>
[IsoId("_HYrJV35aEea2k7EBUopqxw")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument58
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument58 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument58( FloatingInterestRate8 reqName )
    {
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_HhTg4X5aEea2k7EBUopqxw")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISIN { get; init; } 
    #else
    public System.String? ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_HhTg435aEea2k7EBUopqxw")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FloatingInterestRate8 Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FloatingInterestRate8 Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FloatingInterestRate8 Name { get; init; } 
    #else
    public FloatingInterestRate8 Name { get; set; } 
    #endif
    
    
    #nullable disable
    
}
