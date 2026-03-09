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
/// Identification of a financial instrument.
/// </summary>
[IsoId("__Z0PQE3dEeidB49bWZiS0g")]
[DisplayName("Conversion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Conversion1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Conversion1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Conversion1( FinancialInstrumentIdentification1 reqTargetSecurity )
    {
        TargetSecurity = reqTargetSecurity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the target security.
    /// </summary>
    [IsoId("_LKm8wU3eEeidB49bWZiS0g")]
    [DisplayName("Target Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtScty")]
    #endif
    [IsoXmlTag("TrgtScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentIdentification1 TargetSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentIdentification1 TargetSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentIdentification1 TargetSecurity { get; init; } 
    #else
    public FinancialInstrumentIdentification1 TargetSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the conversion.
    /// </summary>
    [IsoId("_V7oZ4E3fEeidB49bWZiS0g")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
