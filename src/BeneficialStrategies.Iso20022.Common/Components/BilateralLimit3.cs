// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics and values set for a bilateral limit, including the counterparty upon which the limit applies.
/// </summary>
[IsoId("_FuKlIW4-EeiU9cctagi5ow")]
[DisplayName("Bilateral Limit")]
public record BilateralLimit3
{
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_F3jKo24-EeiU9cctagi5ow")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required BranchAndFinancialInstitutionIdentification6 CounterpartyIdentification { get; init; }

    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_F3jKpW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Amount")]
    [IsoXmlTag("LmtAmt")]
    public required Amount2Choice_ LimitAmount { get; init; }

    /// <summary>
    /// Specifies if a limit is a debit limit or a credit limit.
    /// </summary>
    [IsoId("_F3jKp24-EeiU9cctagi5ow")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Balance calculated with regard to one member in the system.
    /// </summary>
    [IsoId("_F3jKqW4-EeiU9cctagi5ow")]
    [DisplayName("Bilateral Balance")]
    [IsoXmlTag("BilBal")]
    public CashBalance11? BilateralBalance { get; init; }
}
