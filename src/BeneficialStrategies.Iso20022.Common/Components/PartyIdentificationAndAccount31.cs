// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_PWdRx9p-Ed-ak6NoX_4Aeg_1767078833")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount31
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_PWdRyNp-Ed-ak6NoX_4Aeg_1653239767")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification33Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PWdRydp-Ed-ak6NoX_4Aeg_770006480")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification4? AlternateIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_PWnCwNp-Ed-ak6NoX_4Aeg_1076684364")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }

    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_PWnCwdp-Ed-ak6NoX_4Aeg_-516061372")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public SecuritiesAccount18? ClearingAccount { get; init; }
}
