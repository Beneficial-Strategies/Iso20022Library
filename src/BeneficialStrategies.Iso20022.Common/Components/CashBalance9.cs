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
[IsoId("_ylymkZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Cash Balance")]
public record CashBalance9
{
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_yttMZ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<BalanceType8Choice_> Type { get; init; } = [];

    /// <summary>
    /// Specifies the type of counterparty for which the balance is calculated.
    /// </summary>
    [IsoId("_yttMaZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Counterparty Type")]
    [IsoXmlTag("CtrPtyTp")]
    public required BalanceCounterparty1Code CounterpartyType { get; init; }

    /// <summary>
    /// Specifies the counterparty for which the balance is calculated.
    /// </summary>
    [IsoId("_yttMa5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public ValueList<BranchAndFinancialInstitutionIdentification5> CounterpartyIdentification { get; init; } =
        [];

    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    [IsoId("_yttMbZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public ValueList<DateAndDateTimeSearch3Choice_> ValueDate { get; init; } = [];
}
