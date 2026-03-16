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
[IsoId("_TdxFY9p-Ed-ak6NoX_4Aeg_1155832018")]
[DisplayName("Corporate Action Information")]
public record CorporateActionInformation1
{
    /// <summary>
    /// Identification of the issuer agent.
    /// </summary>
    [IsoId("_TdxFZNp-Ed-ak6NoX_4Aeg_-2004583146")]
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    public required PartyIdentification2Choice_ AgentIdentification { get; init; }

    /// <summary>
    /// Reference given to the event by the CA event issuer (agent).
    /// </summary>
    [IsoId("_TdxFZdp-Ed-ak6NoX_4Aeg_2012826333")]
    [DisplayName("Issuer Corporate Action Identification")]
    [IsoXmlTag("IssrCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerCorporateActionIdentification { get; init; }

    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_TdxFZtp-Ed-ak6NoX_4Aeg_1187231640")]
    [DisplayName("Corporate Action Processing Identification")]
    [IsoXmlTag("CorpActnPrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CorporateActionProcessingIdentification { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_TdxFZ9p-Ed-ak6NoX_4Aeg_1187231671")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType2FormatChoice_ EventType { get; init; }

    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_TdxFaNp-Ed-ak6NoX_4Aeg_1497013693")]
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; init; }

    /// <summary>
    /// Type of processing involved by a Corporate Action.
    /// </summary>
    [IsoId("_Td6PUNp-Ed-ak6NoX_4Aeg_-1661033303")]
    [DisplayName("Event Processing Type")]
    [IsoXmlTag("EvtPrcgTp")]
    public CorporateActionEventProcessingType1FormatChoice_? EventProcessingType { get; init; }

    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    [IsoId("_Td6PUdp-Ed-ak6NoX_4Aeg_-1593018755")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required FinancialInstrumentDescription3 UnderlyingSecurity { get; init; }
}
