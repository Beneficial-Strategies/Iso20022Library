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
[IsoId("_LTE32QVVEeqjd8n6wD9JVw")]
[DisplayName("Intra Position Details")]
public partial record IntraPositionDetails54
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_LTE33QVVEeqjd8n6wD9JVw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat39Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [IsoId("_LTE33wVVEeqjd8n6wD9JVw")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType8Choice_ BalanceFrom { get; init; } 
    
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    [IsoId("_LTE34QVVEeqjd8n6wD9JVw")]
    [DisplayName("Intra Position Movement")]
    [IsoXmlTag("IntraPosMvmnt")]
    public ValueList<IntraPositionMovementDetails18> IntraPositionMovement { get; init; } = [];
    // ID for the above is _LTE34QVVEeqjd8n6wD9JVw
    
    
    #nullable disable
    
}
