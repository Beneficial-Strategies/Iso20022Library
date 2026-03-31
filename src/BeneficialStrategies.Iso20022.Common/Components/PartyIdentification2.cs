// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_PXWpodp-Ed-ak6NoX_4Aeg_2084212157")]
[DisplayName("Party Identification")]
public record PartyIdentification2
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_PXWpotp-Ed-ak6NoX_4Aeg_-2032636467")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification12Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PXWpo9p-Ed-ak6NoX_4Aeg_1970373091")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification2? AlternateIdentification { get; init; }

    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    [IsoId("_PXWppNp-Ed-ak6NoX_4Aeg_1265258476")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeChoice_? ProcessingDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_PXWppdp-Ed-ak6NoX_4Aeg_268186123")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_PXWpptp-Ed-ak6NoX_4Aeg_-728886230")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }
}
