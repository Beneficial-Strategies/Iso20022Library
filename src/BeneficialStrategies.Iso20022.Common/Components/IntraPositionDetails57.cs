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
[IsoId("_6TYZeygPEeym1_Zp1BTvEw")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails57
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_6o1sAygPEeym1_Zp1BTvEw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [IsoId("_6o1sBSgPEeym1_Zp1BTvEw")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType6Choice_ BalanceFrom { get; init; } 
    
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    [IsoId("_6o1sBygPEeym1_Zp1BTvEw")]
    [DisplayName("Intra Position Movement")]
    [IsoXmlTag("IntraPosMvmnt")]
    public ValueList<IntraPositionMovementDetails19> IntraPositionMovement { get; init; } = new ValueList<IntraPositionMovementDetails19>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6o1sBygPEeym1_Zp1BTvEw
    
    
    #nullable disable
    
}
