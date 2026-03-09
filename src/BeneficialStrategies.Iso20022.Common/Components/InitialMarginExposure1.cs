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
/// Liability a clearing member has to a central counterparty with respect to potential future exposures.
/// </summary>
[IsoId("_XCK8BapzEeamNLogr5TkIQ")]
[DisplayName("Initial Margin Exposure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InitialMarginExposure1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InitialMarginExposure1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InitialMarginExposure1( Amount3 reqAmount,MarginType2Choice_ reqType,System.String reqCoreIndicator )
    {
        Amount = reqAmount;
        Type = reqType;
        CoreIndicator = reqCoreIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Initial margin requirement for margin account.
    /// </summary>
    [IsoId("_XCK8B6pzEeamNLogr5TkIQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount3 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount3 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount3 Amount { get; init; } 
    #else
    public Amount3 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of component used in the calculation of the total initial margin requirement.
    /// </summary>
    [IsoId("_XCK8CKpzEeamNLogr5TkIQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginType2Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarginType2Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginType2Choice_ Type { get; init; } 
    #else
    public MarginType2Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the component is considered a core part of the margin model. Usage: In the context of European central counterparties, if the component is included in backtesting procedures in order to assess the performance of the initial margin model as required by EMIR RTS Article (49)(1).
    /// </summary>
    [IsoId("_XCK8CapzEeamNLogr5TkIQ")]
    [DisplayName("Core Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoreInd")]
    #endif
    [IsoXmlTag("CoreInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator CoreIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CoreIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CoreIndicator { get; init; } 
    #else
    public System.String CoreIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
