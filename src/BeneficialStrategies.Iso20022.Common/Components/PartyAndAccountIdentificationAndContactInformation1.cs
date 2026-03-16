// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_Pb-D4Np-Ed-ak6NoX_4Aeg_1550606090")]
[DisplayName("Party And Account Identification And Contact Information")]
public record PartyAndAccountIdentificationAndContactInformation1
{
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [IsoId("_Pb-D4dp-Ed-ak6NoX_4Aeg_1550606183")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification8 PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_Pb-D4tp-Ed-ak6NoX_4Aeg_1550606461")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public CashAccount7? AccountIdentification { get; init; }

    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_Pb-D49p-Ed-ak6NoX_4Aeg_-620262996")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactIdentification1? ContactInformation { get; init; }
}
