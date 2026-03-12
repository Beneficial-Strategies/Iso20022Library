// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of maintenance delegations.
/// </summary>
[IsoId("_z6jy4XJmEe299ZbWCkdR_w")]
[DisplayName("Maintenance Delegation Request")]
public partial record MaintenanceDelegationRequest9
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_0A9V0XJmEe299ZbWCkdR_w")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification176 TMIdentification { get; init; } 
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_0A9V03JmEe299ZbWCkdR_w")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification176? MasterTMIdentification { get; init; } 
    
    /// <summary>
    /// Date and Time of the TMS.
    /// </summary>
    [IsoId("_cXlbUHJnEe299ZbWCkdR_w")]
    [DisplayName("TM Date Time")]
    [IsoXmlTag("TMDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TMDateTime { get; init; } 
    
    /// <summary>
    /// Challenge value sends by the POI to be received back in a message response.
    /// </summary>
    [IsoId("_IzKkAHJoEe299ZbWCkdR_w")]
    [DisplayName("TM Challenge Value")]
    [IsoXmlTag("TMChllngVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary TMChallengeValue { get; init; } 
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_0A9V1XJmEe299ZbWCkdR_w")]
    [DisplayName("Requested Delegation")]
    [IsoXmlTag("ReqdDlgtn")]
    public ValueList<MaintenanceDelegation15> RequestedDelegation { get; init; } = new ValueList<MaintenanceDelegation15>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _0A9V1XJmEe299ZbWCkdR_w
    
    
    #nullable disable
    
}
