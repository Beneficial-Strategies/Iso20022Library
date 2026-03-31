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
[IsoId("_DuVq8Rn5EeyroI8qKgB7Mg")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation162
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_EEF4hRn5EeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_EEF4jRn5EeyroI8qKgB7Mg")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_EEF4lRn5EeyroI8qKgB7Mg")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_EEF4nRn5EeyroI8qKgB7Mg")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType87Choice_ EventType { get; init; }

    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    [IsoId("_EEF4pRn5EeyroI8qKgB7Mg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Fractional quantity resulting from an event which will be paid with cash in lieu.
    /// </summary>
    [IsoId("_EEF4rxn5EeyroI8qKgB7Mg")]
    [DisplayName("Fractional Quantity")]
    [IsoXmlTag("FrctnlQty")]
    public FinancialInstrumentQuantity33Choice_? FractionalQuantity { get; init; }
}
