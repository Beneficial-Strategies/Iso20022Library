// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_SCROdRQ0EeKOSJdKMJK1cg")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails28
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_SX4R9RQ0EeKOSJdKMJK1cg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [IsoId("_SX4R-RQ0EeKOSJdKMJK1cg")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType3Choice_ BalanceFrom { get; init; } 
    
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    [IsoId("_SX4R_RQ0EeKOSJdKMJK1cg")]
    [DisplayName("Intra Position Movement")]
    [IsoXmlTag("IntraPosMvmnt")]
    public ValueList<IntraPositionMovementDetails9> IntraPositionMovement { get; init; } = [];
    // ID for the above is _SX4R_RQ0EeKOSJdKMJK1cg
    
    
    #nullable disable
    
}
