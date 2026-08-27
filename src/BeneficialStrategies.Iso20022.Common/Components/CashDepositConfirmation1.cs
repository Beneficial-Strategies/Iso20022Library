// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Confirmation of how the cash receiver will settle the cash deposit.
/// </summary>
[IsoId("_G165MKtjEfC6tbn8zOl_iw")]
[DisplayName("Cash Deposit Confirmation1")]
public record CashDepositConfirmation1
{
    /// <summary>
    /// Confirms the cash received by the cash receiver for a cash deposit request that will be credited to the account.
    /// </summary>
    [IsoId("_MT2hgqtjEfC6tbn8zOl_iw")]
    [DisplayName("Valid Cash Deposit Received")]
    [IsoXmlTag("VldCshDpstRcvd")]
    public CashBreakdown1? ValidCashDepositReceived { get; init; }

    /// <summary>
    /// Confirms the cash received by the cash receiver for a CashDepositRequest that will not be credited to an account, for example the cash is counterfeit.
    /// </summary>
    [IsoId("_MT2hg6tjEfC6tbn8zOl_iw")]
    [DisplayName("Invalid Cash Deposit Received")]
    [IsoXmlTag("InvldCshDpstRcvd")]
    public CashBreakdown1? InvalidCashDepositReceived { get; init; }

    /// <summary>
    /// Unique identification for the discrepancy.
    /// </summary>
    [IsoId("_f2dHUNEnEfCHIpLhE5dmGg")]
    [DisplayName("Discrepancy Identification")]
    [IsoXmlTag("DscrpncyId")]
    public IsoMax35Text? DiscrepancyIdentification { get; init; }
}
