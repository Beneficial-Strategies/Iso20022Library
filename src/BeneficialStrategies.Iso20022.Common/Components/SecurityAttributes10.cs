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
/// Tangible items of value to a business.
/// </summary>
[IsoId("_PxlM8ZJKEeuAlLVx8pyt3w")]
[DisplayName("Security Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityAttributes10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityAttributes10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityAttributes10( SecurityIdentification39 reqFinancialInstrumentIdentification )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_PzlYEZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification39 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details about the financial instrument.
    /// </summary>
    [IsoId("_PzlYE5JKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmTp")]
    #endif
    [IsoXmlTag("FinInstrmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument97? FinancialInstrumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument97? FinancialInstrumentType { get; init; } 
    #else
    public FinancialInstrument97? FinancialInstrumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_PzlYFZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommonFinancialInstrumentAttributes10? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommonFinancialInstrumentAttributes10? FinancialInstrumentAttributes { get; init; } 
    #else
    public CommonFinancialInstrumentAttributes10? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
