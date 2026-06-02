// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to be used to extract.
/// </summary>
[IsoId("_U3jIcQzWEemZov7BpFCU4Q")]
[DisplayName("Billing Search Criteria3")]
public record BillingSearchCriteria3
{
    /// <summary>
    /// Identification of the service or system for which the billing information must be returned.
    /// </summary>
    [IsoId("_Z4hH8AzWEemZov7BpFCU4Q")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public SystemAndCurrency1? Service { get; init; }

    /// <summary>
    /// Identification of the billing report.
    /// </summary>
    [IsoId("_VDLwsQzWEemZov7BpFCU4Q")]
    [DisplayName("Billing Identification")]
    [IsoXmlTag("BllgId")]
    public IsoMax35Text? BillingIdentification { get; init; }

    /// <summary>
    /// General information for each invoice invoicing request or month end billing event is stored.
    /// </summary>
    [IsoId("_VDLwswzWEemZov7BpFCU4Q")]
    [DisplayName("Billing Period")]
    [IsoXmlTag("BllgPrd")]
    public DatePeriod2? BillingPeriod { get; init; }

    /// <summary>
    /// Unique identification of the party responsible for the referenced party.
    /// </summary>
    [IsoId("_eR8u0SiMEemPd6Dm9NW2Ig")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the billed party.
    /// </summary>
    [IsoId("_eR8u0CiMEemPd6Dm9NW2Ig")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public PartyIdentification136? PartyIdentification { get; init; }

    /// <summary>
    /// Either securities account or dedicated cash account number.
    /// </summary>
    [IsoId("_VDLwuQzWEemZov7BpFCU4Q")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification38Choice? AccountIdentification { get; init; }
}
