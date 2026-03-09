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
/// Underlying financial instrument to which an trade confirmation is related.
/// </summary>
[IsoId("_2C-80QhLEe2fOITqoTnSLQ")]
[DisplayName("Underlying Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingFinancialInstrument7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnderlyingFinancialInstrument7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnderlyingFinancialInstrument7( SecurityIdentification19 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_2VwH0QhLEe2fOITqoTnSLQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 Identification { get; init; } 
    #else
    public SecurityIdentification19 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying financial instrument attributes to which an trade confirmation is related.
    /// </summary>
    [IsoId("_2VwH2QhLEe2fOITqoTnSLQ")]
    [DisplayName("Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attrbts")]
    #endif
    [IsoXmlTag("Attrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes124? Attributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes124? Attributes { get; init; } 
    #else
    public FinancialInstrumentAttributes124? Attributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
