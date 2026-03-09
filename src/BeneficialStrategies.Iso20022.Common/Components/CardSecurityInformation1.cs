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
/// Card security code (CSC) associated with the card performing the transaction.
/// </summary>
[IsoId("_SqR5xAEcEeCQm6a_G2yO_w_383431093")]
[DisplayName("Card Security Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardSecurityInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardSecurityInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardSecurityInformation1( CSCManagement1Code reqCSCManagement )
    {
        CSCManagement = reqCSCManagement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Card security code (CSC) management associated with the transaction.
    /// </summary>
    [IsoId("_SqR5xQEcEeCQm6a_G2yO_w_-2115154942")]
    [DisplayName("CSC Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSCMgmt")]
    #endif
    [IsoXmlTag("CSCMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CSCManagement1Code CSCManagement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CSCManagement1Code CSCManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CSCManagement1Code CSCManagement { get; init; } 
    #else
    public CSCManagement1Code CSCManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Card security code (CSC).
    /// </summary>
    [IsoId("_SqR5xgEcEeCQm6a_G2yO_w_494973003")]
    [DisplayName("CSC Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSCVal")]
    #endif
    [IsoXmlTag("CSCVal")]
    [IsoSimpleType(IsoSimpleType.Min3Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin3Max4NumericText? CSCValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CSCValue { get; init; } 
    #else
    public System.String? CSCValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
