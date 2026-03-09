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
/// Identifies the market and purpose for the settlement.
/// </summary>
[IsoId("_ZkmIMNTPEeKvJeoOII0e7w")]
[DisplayName("Market Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarketIdentification87
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarketIdentification87 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarketIdentification87( string reqCountry,ClassificationType1Choice_ reqClassificationType )
    {
        Country = reqCountry;
        ClassificationType = reqClassificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country in which the financial instrument is to be settled.
    /// </summary>
    [IsoId("_hzs3oNTPEeKvJeoOII0e7w")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Type of instrument covered by the SSI instruction.
    /// </summary>
    [IsoId("_rmMscNTPEeKvJeoOII0e7w")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClassificationType1Choice_ ClassificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClassificationType1Choice_ ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType1Choice_ ClassificationType { get; init; } 
    #else
    public ClassificationType1Choice_ ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the instruction, for example, whether for regular payments, margin payments related to a collateral movement, securities settlements, securities lending.
    /// </summary>
    [IsoId("_FcKBEtQQEeKSSosHwGnjNw")]
    [DisplayName("Settlement Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPurp")]
    #endif
    [IsoXmlTag("SttlmPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Purpose3Choice_? SettlementPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Purpose3Choice_? SettlementPurpose { get; init; } 
    #else
    public Purpose3Choice_? SettlementPurpose { get; set; } 
    #endif
    
    
    #nullable disable
    
}
