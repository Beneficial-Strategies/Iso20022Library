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
/// Represents different types of derivative.
/// </summary>
[IsoId("_PDS2gWp7EemmaZLSPtWX5A")]
[DisplayName("Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Derivative4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price.
    /// </summary>
    [IsoId("_PPMkgWp7EemmaZLSPtWX5A")]
    [DisplayName("Future")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Futr")]
    #endif
    [IsoXmlTag("Futr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Future4? Future { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Future4? Future { get; init; } 
    #else
    public Future4? Future { get; set; } 
    #endif
    
    /// <summary>
    /// Contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
    /// </summary>
    [IsoId("_PPMkg2p7EemmaZLSPtWX5A")]
    [DisplayName("Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Optn")]
    #endif
    [IsoXmlTag("Optn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Option15? Option { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Option15? Option { get; init; } 
    #else
    public Option15? Option { get; set; } 
    #endif
    
    
    #nullable disable
    
}
