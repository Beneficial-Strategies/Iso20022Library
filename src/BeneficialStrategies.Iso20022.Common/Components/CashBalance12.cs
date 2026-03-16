// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance details for a cash account.
/// </summary>
[IsoId("_6nhacX3sEeibM9CPDGCw0g")]
[DisplayName("Cash Balance")]
public record CashBalance12
{
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_6yG5133sEeibM9CPDGCw0g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<BalanceType11Choice_> Type { get; init; } = [];

    /// <summary>
    /// Specifies the type of counterparty for which the balance is calculated.
    /// </summary>
    [IsoId("_6yG52X3sEeibM9CPDGCw0g")]
    [DisplayName("Counterparty Type")]
    [IsoXmlTag("CtrPtyTp")]
    public required BalanceCounterparty1Code CounterpartyType { get; init; }

    /// <summary>
    /// Specifies the counterparty for which the balance is calculated.
    /// </summary>
    [IsoId("_6yG5233sEeibM9CPDGCw0g")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public ValueList<BranchAndFinancialInstitutionIdentification6> CounterpartyIdentification { get; init; } =
        [];

    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    [IsoId("_6yG53X3sEeibM9CPDGCw0g")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public ValueList<DateAndDateTimeSearch4Choice_> ValueDate { get; init; } = [];

    /// <summary>
    /// Date or date time when the balance was last updated following an entry posted to the account, in the books of the account servicing institution.
    /// </summary>
    [IsoId("_HyosAbwWEeioUZ07TzVRmA")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeSearch4Choice_? ProcessingDate { get; init; }
}
