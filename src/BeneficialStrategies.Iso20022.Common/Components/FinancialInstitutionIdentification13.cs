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
/// Set of elements used to identify a financial institution.
/// </summary>
[IsoId("_Lrc52QZpEeSPjINWZdMmvg")]
[DisplayName("Financial Institution Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionIdentification13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstitutionIdentification13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstitutionIdentification13( System.String reqBICFI )
    {
        BICFI = reqBICFI;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_Lrc52wZpEeSPjINWZdMmvg")]
    [DisplayName("BICFI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BICFI")]
    #endif
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBICFIIdentifier BICFI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BICFI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BICFI { get; init; } 
    #else
    public System.String BICFI { get; set; } 
    #endif
    
    
    #nullable disable
    
}
