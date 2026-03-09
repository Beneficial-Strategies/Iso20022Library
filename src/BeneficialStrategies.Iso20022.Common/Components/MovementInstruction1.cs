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
/// Details of the movement instructions.
/// </summary>
[IsoId("_RirRtdp-Ed-ak6NoX_4Aeg_-1983038422")]
[DisplayName("Movement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MovementInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MovementInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MovementInstruction1( CorporateActionMovement1 reqMovementGeneralInformation )
    {
        MovementGeneralInformation = reqMovementGeneralInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides general information about the movement.
    /// </summary>
    [IsoId("_RirRttp-Ed-ak6NoX_4Aeg_-1906384163")]
    [DisplayName("Movement General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntGnlInf")]
    #endif
    [IsoXmlTag("MvmntGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMovement1 MovementGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMovement1 MovementGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovement1 MovementGeneralInformation { get; init; } 
    #else
    public CorporateActionMovement1 MovementGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the underlying securities movement.
    /// </summary>
    [IsoId("_RirRt9p-Ed-ak6NoX_4Aeg_-1853745607")]
    [DisplayName("Underlying Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("UndrlygSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingSecurityMovement1? UnderlyingSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingSecurityMovement1? UnderlyingSecuritiesMovementDetails { get; init; } 
    #else
    public UnderlyingSecurityMovement1? UnderlyingSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the underlying cash movement.
    /// </summary>
    [IsoId("_RirRuNp-Ed-ak6NoX_4Aeg_-1965607200")]
    [DisplayName("Underlying Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygCshMvmntDtls")]
    #endif
    [IsoXmlTag("UndrlygCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMovement2? UnderlyingCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMovement2? UnderlyingCashMovementDetails { get; init; } 
    #else
    public CashMovement2? UnderlyingCashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the proceeds, ie, outturned resources.
    /// </summary>
    [IsoId("_Ri1CsNp-Ed-ak6NoX_4Aeg_-1820497873")]
    [DisplayName("Proceeds Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdsMvmntDtls")]
    #endif
    [IsoXmlTag("PrcdsMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProceedsMovement1? ProceedsMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProceedsMovement1? ProceedsMovementDetails { get; init; } 
    #else
    public ProceedsMovement1? ProceedsMovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
