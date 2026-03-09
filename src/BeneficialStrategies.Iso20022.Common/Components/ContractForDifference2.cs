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
/// Transparency calculation specific details on a contract for difference, spread betting derivatives.
/// </summary>
[IsoId("_MStLwWlQEeaLAKoEUNsD9g")]
[DisplayName("Contract For Difference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractForDifference2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractForDifference2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractForDifference2( UnderlyingContractForDifferenceType3Code reqUnderlyingType )
    {
        UnderlyingType = reqUnderlyingType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Underlying type of the contract for difference.
    /// </summary>
    [IsoId("_Mb3u0WlQEeaLAKoEUNsD9g")]
    [DisplayName("Underlying Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygTp")]
    #endif
    [IsoXmlTag("UndrlygTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; } 
    #else
    public UnderlyingContractForDifferenceType3Code UnderlyingType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency 1 of the underlying currency pair.
    /// </summary>
    [IsoId("_Mb3u02lQEeaLAKoEUNsD9g")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy1")]
    #endif
    [IsoXmlTag("NtnlCcy1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? NotionalCurrency1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NotionalCurrency1 { get; init; } 
    #else
    public string? NotionalCurrency1 { get; set; } 
    #endif
    
    /// <summary>
    /// Currency 2 of the underlying currency pair.
    /// </summary>
    [IsoId("_Mb3u1WlQEeaLAKoEUNsD9g")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy2")]
    #endif
    [IsoXmlTag("NtnlCcy2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? NotionalCurrency2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NotionalCurrency2 { get; init; } 
    #else
    public string? NotionalCurrency2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
