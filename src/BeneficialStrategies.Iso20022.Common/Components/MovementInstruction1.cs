// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the movement instructions.
/// </summary>
[IsoId("_RirRtdp-Ed-ak6NoX_4Aeg_-1983038422")]
[DisplayName("Movement Instruction")]
public partial record MovementInstruction1
{
    #nullable enable
    
    /// <summary>
    /// Provides general information about the movement.
    /// </summary>
    [IsoId("_RirRttp-Ed-ak6NoX_4Aeg_-1906384163")]
    [DisplayName("Movement General Information")]
    [IsoXmlTag("MvmntGnlInf")]
    public required CorporateActionMovement1 MovementGeneralInformation { get; init; } 
    
    /// <summary>
    /// Provides information about the underlying securities movement.
    /// </summary>
    [IsoId("_RirRt9p-Ed-ak6NoX_4Aeg_-1853745607")]
    [DisplayName("Underlying Securities Movement Details")]
    [IsoXmlTag("UndrlygSctiesMvmntDtls")]
    public UnderlyingSecurityMovement1? UnderlyingSecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the underlying cash movement.
    /// </summary>
    [IsoId("_RirRuNp-Ed-ak6NoX_4Aeg_-1965607200")]
    [DisplayName("Underlying Cash Movement Details")]
    [IsoXmlTag("UndrlygCshMvmntDtls")]
    public CashMovement2? UnderlyingCashMovementDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the proceeds, ie, outturned resources.
    /// </summary>
    [IsoId("_Ri1CsNp-Ed-ak6NoX_4Aeg_-1820497873")]
    [DisplayName("Proceeds Movement Details")]
    [IsoXmlTag("PrcdsMvmntDtls")]
    public ProceedsMovement1? ProceedsMovementDetails { get; init; } 
    
    
    #nullable disable
    
}
