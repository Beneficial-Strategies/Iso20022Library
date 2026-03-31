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
[IsoId("_ahjfQYr-EeaNFeVGetd6Xw")]
[DisplayName("Corporate Action General Information")]
public record CorporateActionGeneralInformation111
{
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_a4eKd4r-EeaNFeVGetd6Xw")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_a4eKf4r-EeaNFeVGetd6Xw")]
    [DisplayName("Official Corporate Action Event Identification")]
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_a4eKh4r-EeaNFeVGetd6Xw")]
    [DisplayName("Class Action Number")]
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassActionNumber { get; init; }

    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_a4eKj4r-EeaNFeVGetd6Xw")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType53Choice_ EventType { get; init; }

    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    [IsoId("_a4eKl4r-EeaNFeVGetd6Xw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_a4eKn4r-EeaNFeVGetd6Xw")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat16Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Fractional quantity resulting from an event which will be paid with cash in lieu.
    /// </summary>
    [IsoId("_a4eKoYr-EeaNFeVGetd6Xw")]
    [DisplayName("Fractional Quantity")]
    [IsoXmlTag("FrctnlQty")]
    public FinancialInstrumentQuantity1Choice_? FractionalQuantity { get; init; }
}
