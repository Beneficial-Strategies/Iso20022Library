// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
/// </summary>
[IsoId("_RUSFwKprEeamNLogr5TkIQ")]
[DisplayName("End Of Day Requirement")]
public partial record EndOfDayRequirement2
{
    #nullable enable
    
    /// <summary>
    /// Liability and assets that arise for a clearing member with respect to a central counterparty.
    /// </summary>
    [IsoId("_c5B7UKprEeamNLogr5TkIQ")]
    [DisplayName("Initial Margin Requirements")]
    [IsoXmlTag("InitlMrgnRqrmnts")]
    public required InitialMarginRequirement1 InitialMarginRequirements { get; init; } 
    
    /// <summary>
    /// Total change in the mark-to-market value of the margin account from the previous day, net of changes in mark-to-market relating to the entry or exit of derivative positions not entered into at zero mark-to-market (such as option premiums and upsettled upfront fees). Indicates whether the variation margin is paid to clearing members.
    /// </summary>
    [IsoId("_lUoOoKprEeamNLogr5TkIQ")]
    [DisplayName("Variation Margin Requirements")]
    [IsoXmlTag("VartnMrgnRqrmnts")]
    public required AmountAndDirection102 VariationMarginRequirements { get; init; } 
    
    /// <summary>
    /// Identification of account used to calculate margin requirements. Usage: In the context of a central counterparty, if reported at the client level (expected for gross omnibus and individual segregated accounts), will report the Client ID in the Internal ID field and choose &apos;ClientID&apos; for the CCP Participant ID Type. If reported at the clearing member account level will report the account ID in the Internal ID field and choose &apos;AccountID&apos; for the CCP Participant ID Type.
    /// </summary>
    [IsoId("_lQt8gPnfEeaQh_7a05rSJQ")]
    [DisplayName("Margin Account Identification")]
    [IsoXmlTag("MrgnAcctId")]
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
