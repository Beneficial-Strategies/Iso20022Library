// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to parties in the contract.
/// </summary>
[IsoId("_ne8ZGXg-Eeu3kecHd7QKUQ")]
[DisplayName("Trade Counterparty Report")]
public record TradeCounterpartyReport14
{
    /// <summary>
    /// Identification of the counterparty to a derivative transaction who is fulfilling its reporting obligation in the present report.
    /// </summary>
    [IsoId("_ntOssXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required Counterparty34 ReportingCounterparty { get; init; }

    /// <summary>
    /// Identification of the other counterparty to a derivative transaction.
    /// </summary>
    [IsoId("_ntOss3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required Counterparty31 OtherCounterparty { get; init; }

    /// <summary>
    /// Identification of the broker as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_ntOstXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public OrganisationIdentification10Choice_? Broker { get; init; }

    /// <summary>
    /// Identification of the party that ultimately submits the report to the trade repository.
    /// </summary>
    [IsoId("_ntOst3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Submitting Agent")]
    [IsoXmlTag("SubmitgAgt")]
    public OrganisationIdentification10Choice_? SubmittingAgent { get; init; }

    /// <summary>
    /// Identifies the clearing member through which a derivative transaction is cleared at a central counterparty (CCP).  The element applies to transactions under the agency clearing model and the principal clearing model.
    /// </summary>
    [IsoId("_ntOsuXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public OrganisationIdentification10Choice_? ClearingMember { get; init; }

    /// <summary>
    /// Identification of the beneficiary of a derivative transaction, ie a party that is subject to the rights and obligations arising from the contract.
    /// ||Usage: The first iteration must always be the beneficiary 1 of the counterparty 1 and the second iteration is the beneficiary 2 of the counterparty 2.
    /// </summary>
    [IsoId("_ntOsu3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<PartyIdentification235Choice_> Beneficiary { get; init; } = [];
}
