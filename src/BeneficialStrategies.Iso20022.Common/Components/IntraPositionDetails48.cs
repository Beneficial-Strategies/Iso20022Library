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
[IsoId("_er-B-83yEee5nJBZsW8MFQ")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails48
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_er-B_83yEee5nJBZsW8MFQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [IsoId("_er-CAc3yEee5nJBZsW8MFQ")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType8Choice_ BalanceFrom { get; init; } 
    
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    [IsoId("_er-CA83yEee5nJBZsW8MFQ")]
    [DisplayName("Intra Position Movement")]
    [IsoXmlTag("IntraPosMvmnt")]
    public ValueList<IntraPositionMovementDetails16> IntraPositionMovement { get; init; } = new ValueList<IntraPositionMovementDetails16>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _er-CA83yEee5nJBZsW8MFQ
    
    
    #nullable disable
    
}
