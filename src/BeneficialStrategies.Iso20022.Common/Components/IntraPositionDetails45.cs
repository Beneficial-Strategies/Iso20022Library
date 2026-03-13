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
[IsoId("_yklEC6OAEeeDTpy0mhI4TQ")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails45
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_yzmXY6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [IsoId("_yzmXZaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType6Choice_ BalanceFrom { get; init; } 
    
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    [IsoId("_yzmXZ6OAEeeDTpy0mhI4TQ")]
    [DisplayName("Intra Position Movement")]
    [IsoXmlTag("IntraPosMvmnt")]
    public ValueList<IntraPositionMovementDetails15> IntraPositionMovement { get; init; } = [];
    // ID for the above is _yzmXZ6OAEeeDTpy0mhI4TQ
    
    
    #nullable disable
    
}
