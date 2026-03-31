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
[IsoId("_F0ZysQ4zEeKVsZQr6J31Tg")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation50
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_GMPrAQ4zEeKVsZQr6J31Tg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_GMPrCw4zEeKVsZQr6J31Tg")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_GMPrFQ4zEeKVsZQr6J31Tg")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_GMPrHw4zEeKVsZQr6J31Tg")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType12Choice_ EventType { get; init; }

    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    [IsoId("_GMPrKQ4zEeKVsZQr6J31Tg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Indicates that the additional business process relates to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_GMPrMw4zEeKVsZQr6J31Tg")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public AdditionalBusinessProcessFormat7Choice_? AdditionalBusinessProcessIndicator { get; init; }

    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_GMPrPQ4zEeKVsZQr6J31Tg")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat6Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Fractional quantity resulting from an event which will be paid with cash in lieu.
    /// </summary>
    [IsoId("_i6ANQBOAEeKyONjZVQUqzg")]
    [DisplayName("Fractional Quantity")]
    [IsoXmlTag("FrctnlQty")]
    public FinancialInstrumentQuantity1Choice_? FractionalQuantity { get; init; }
}
