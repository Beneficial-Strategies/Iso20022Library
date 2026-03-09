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
[IsoId("_AwznWNokEeC60axPepSq7g_-179869955")]
[DisplayName("Underlying Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingFinancialInstrument1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnderlyingFinancialInstrument1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnderlyingFinancialInstrument1( SecurityIdentification14 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_AwznWdokEeC60axPepSq7g_-1186868251")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 Identification { get; init; } 
    #else
    public SecurityIdentification14 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying financial instrument attributes to which an trade confirmation is related.
    /// </summary>
    [IsoId("_Aw9YUNokEeC60axPepSq7g_1991755167")]
    [DisplayName("Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attrbts")]
    #endif
    [IsoXmlTag("Attrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes31? Attributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes31? Attributes { get; init; } 
    #else
    public FinancialInstrumentAttributes31? Attributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
