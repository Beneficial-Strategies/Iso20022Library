// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the trade counterparties in the contract.
/// </summary>
[IsoId("_B0JdkZQEEeiILOjNP8ro1w")]
[DisplayName("Trade Counterparty Report")]
public record TradeCounterpartyReport8
{
    /// <summary>
    /// Identification of the reporting counterparty.
    /// </summary>
    [IsoId("_CBU98ZQEEeiILOjNP8ro1w")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required Counterparty25 ReportingCounterparty { get; init; }

    /// <summary>
    /// Identification of the other counterparty in the transaction.
    /// </summary>
    [IsoId("_CBU985QEEeiILOjNP8ro1w")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required Counterparty28 OtherCounterparty { get; init; }

    /// <summary>
    /// Identification of the broker as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_CBU99ZQEEeiILOjNP8ro1w")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public OrganisationIdentification9Choice_? Broker { get; init; }

    /// <summary>
    /// Identification of the submitting agent in the case where the reporting counterparty has delegated the submission of the report to a third party or to the other counterparty.
    /// </summary>
    [IsoId("_CBU995QEEeiILOjNP8ro1w")]
    [DisplayName("Submitting Agent")]
    [IsoXmlTag("SubmitgAgt")]
    public OrganisationIdentification9Choice_? SubmittingAgent { get; init; }

    /// <summary>
    /// Identification of the clearing member in the case where the trade is cleared.
    /// </summary>
    [IsoId("_CBU9-ZQEEeiILOjNP8ro1w")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public OrganisationIdentification9Choice_? ClearingMember { get; init; }

    /// <summary>
    /// Identification of the beneficiary who is subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_CBU9-5QEEeiILOjNP8ro1w")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public OrganisationIdentification9Choice_? Beneficiary { get; init; }
}
