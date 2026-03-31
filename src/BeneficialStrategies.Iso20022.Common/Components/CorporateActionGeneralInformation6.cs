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
[IsoId("_TX8xQtp-Ed-ak6NoX_4Aeg_1117765512")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation6
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_TX8xQ9p-Ed-ak6NoX_4Aeg_1117765530")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_TX8xRNp-Ed-ak6NoX_4Aeg_1117765555")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_TX8xRdp-Ed-ak6NoX_4Aeg_1117765573")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType3Choice_ EventType { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_TX8xRtp-Ed-ak6NoX_4Aeg_1117765618")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributes6? UnderlyingSecurity { get; init; }
}
