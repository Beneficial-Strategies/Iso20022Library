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
[IsoId("_vZ_skSqiEeObprHJy8Zrxg")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation70
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_vw5wuSqiEeObprHJy8Zrxg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_vw5wwSqiEeObprHJy8Zrxg")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_vw5wySqiEeObprHJy8Zrxg")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    [IsoId("_vw5w0SqiEeObprHJy8Zrxg")]
    [DisplayName("Event Processing Type")]
    [IsoXmlTag("EvtPrcgTp")]
    public CorporateActionEventProcessingTypeChoice_? EventProcessingType { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_vw5w2SqiEeObprHJy8Zrxg")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType13Choice_ EventType { get; init; }

    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_vw5w4SqiEeObprHJy8Zrxg")]
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary1Choice_ MandatoryVoluntaryEventType { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_vw5w6SqiEeObprHJy8Zrxg")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required FinancialInstrumentAttributes48 UnderlyingSecurity { get; init; }
}
