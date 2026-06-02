// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
[IsoId("_iICQoakgEfCG_LQaXOxwew")]
[DisplayName("Corporate Action General Information197")]
public record CorporateActionGeneralInformation197
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_iPvbJakgEfCG_LQaXOxwew")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_iPvbLakgEfCG_LQaXOxwew")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_iPvbNakgEfCG_LQaXOxwew")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    public IsoMax35Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Buyer Protection instruction identification assigned by the CSD when an instruction has been entered by the buyer.
    /// </summary>
    [IsoId("_LF3YsKkkEfCG_LQaXOxwew")]
    [DisplayName("Buyer Protection Instruction Identification")]
    [IsoXmlTag("BuyrPrtcnInstrId")]
    public IsoMax35Text? BuyerProtectionInstructionIdentification { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_iPvbPakgEfCG_LQaXOxwew")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType112Choice EventType { get; init; }
}
