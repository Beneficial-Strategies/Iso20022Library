// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Audit Trail2.
/// </summary>
[IsoId("_YtaCdTE_Ee62xuUQ2zyZww")]
[DisplayName("Party Audit Trail2")]
public partial record PartyAuditTrail2
{
    #nullable enable

    /// <summary>
    /// Approving User.
    /// </summary>
    [DisplayName("Approving User")]
    [IsoXmlTag("ApprvgUsr")]
    public IsoMax256Text? ApprovingUser { get; init; } 

    /// <summary>
    /// Instructing User.
    /// </summary>
    [DisplayName("Instructing User")]
    [IsoXmlTag("InstgUsr")]
    public required IsoMax256Text InstructingUser { get; init; } 

    /// <summary>
    /// Operation Time Stamp.
    /// </summary>
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    public required IsoISODateTime OperationTimeStamp { get; init; } 

    /// <summary>
    /// Record.
    /// </summary>
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<UpdateLogPartyRecord2Choice_> Record { get; init; } = [];

    
    #nullable disable
    
}
