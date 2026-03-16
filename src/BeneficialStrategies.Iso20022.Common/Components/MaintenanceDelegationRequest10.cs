// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance Delegation Request10.
/// </summary>
[IsoId("_vwwpAZRKEe6mHLZGMDWxvg")]
[DisplayName("Maintenance Delegation Request10")]
public partial record MaintenanceDelegationRequest10
{
    #nullable enable

    /// <summary>
    /// Master TM Identification.
    /// </summary>
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification176? MasterTMIdentification { get; init; } 

    /// <summary>
    /// Requested Delegation.
    /// </summary>
    [DisplayName("Requested Delegation")]
    [IsoXmlTag("ReqdDlgtn")]
    public ValueList<MaintenanceDelegation18> RequestedDelegation { get; init; } = [];

    /// <summary>
    /// TM Challenge Value.
    /// </summary>
    [DisplayName("TM Challenge Value")]
    [IsoXmlTag("TMChllngVal")]
    public required IsoMax140Binary TMChallengeValue { get; init; } 

    /// <summary>
    /// TM Date Time.
    /// </summary>
    [DisplayName("TM Date Time")]
    [IsoXmlTag("TMDtTm")]
    public required IsoISODateTime TMDateTime { get; init; } 

    /// <summary>
    /// TM Identification.
    /// </summary>
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification176 TMIdentification { get; init; } 

    
    #nullable disable
    
}
