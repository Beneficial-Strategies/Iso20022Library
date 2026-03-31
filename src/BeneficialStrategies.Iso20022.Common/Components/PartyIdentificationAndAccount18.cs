// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification and account of the party.
/// </summary>
[IsoId("_PY_ocNp-Ed-ak6NoX_4Aeg_1735397677")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount18
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_PZJZYNp-Ed-ak6NoX_4Aeg_1735397713")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification30Choice_ Identification { get; init; }

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_PZJZYdp-Ed-ak6NoX_4Aeg_1735397832")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_PZJZYtp-Ed-ak6NoX_4Aeg_1735397927")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_PZJZY9p-Ed-ak6NoX_4Aeg_1735398281")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PZJZZNp-Ed-ak6NoX_4Aeg_1735398779")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification2? AlternateIdentification { get; init; }
}
