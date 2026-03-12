// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the party and owner type.
/// </summary>
[IsoId("_l5A6kC_9EeOKib24wnHaFg")]
[DisplayName("Account Role")]
public partial record AccountRole1
{
    #nullable enable
    
    /// <summary>
    /// Account owner/user identification and contact information.
    /// </summary>
    [IsoId("_rnEpkC_9EeOKib24wnHaFg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification41 Party { get; init; } 
    
    /// <summary>
    /// Defines account owners/users relation to the account.
    /// </summary>
    [IsoId("_BjRlsC__EeOKib24wnHaFg")]
    [DisplayName("Owner Type")]
    [IsoXmlTag("OwnrTp")]
    public required OwnerType1 OwnerType { get; init; } 
    
    /// <summary>
    /// Start date related to the role.
    /// </summary>
    [IsoId("_vT_nQC_9EeOKib24wnHaFg")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// End date related to the role.
    /// </summary>
    [IsoId("_1cJRQC_9EeOKib24wnHaFg")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    
    #nullable disable
    
}
