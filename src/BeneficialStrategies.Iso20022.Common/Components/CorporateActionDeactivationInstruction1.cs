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
/// Provides information about the deactivation.
/// </summary>
[IsoId("_UJuMddp-Ed-ak6NoX_4Aeg_-1685692105")]
[DisplayName("Corporate Action Deactivation Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDeactivationInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDeactivationInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDeactivationInstruction1( System.DateTime reqDeactivationDateAndTime )
    {
        DeactivationDateAndTime = reqDeactivationDateAndTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the CSD must deactivate the corporate action event or the option.
    /// </summary>
    [IsoId("_UJuMdtp-Ed-ak6NoX_4Aeg_1692268967")]
    [DisplayName("Deactivation Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeactvtnDtAndTm")]
    #endif
    [IsoXmlTag("DeactvtnDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DeactivationDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DeactivationDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DeactivationDateAndTime { get; init; } 
    #else
    public System.DateTime DeactivationDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the option, when the deactivation instruction applies at the level of a corporate action option.
    /// </summary>
    [IsoId("_UJuMd9p-Ed-ak6NoX_4Aeg_972006480")]
    [DisplayName("Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtls")]
    #endif
    [IsoXmlTag("OptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption2? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption2? OptionDetails { get; init; } 
    #else
    public CorporateActionOption2? OptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
