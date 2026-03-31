// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that enables any payments made in connection with the fulfilment of an account switch to be reconciled by the relevant account servicer with the associated request.
/// </summary>
[IsoId("_6zmxjW48EeiU9cctagi5ow")]
[DisplayName("Balance Transfer")]
public record BalanceTransfer2
{
    /// <summary>
    /// Reference that enables the creditor to reconcile a payment received through a different payment channel with the payment request.
    /// </summary>
    [IsoId("_68jSIW48EeiU9cctagi5ow")]
    [DisplayName("Balance Transfer Reference")]
    [IsoXmlTag("BalTrfRef")]
    public BalanceTransferReference1? BalanceTransferReference { get; init; }

    /// <summary>
    /// Contains details of the clearance and settlement method chosen to make the appropriate payment from account servicer to account servicer in order to transfer the positive or negative closing balance of the old account to the new account.
    /// </summary>
    [IsoId("_68jSI248EeiU9cctagi5ow")]
    [DisplayName("Balance Transfer Method")]
    [IsoXmlTag("BalTrfMtd")]
    public SettlementMethod2Choice_? BalanceTransferMethod { get; init; }

    /// <summary>
    /// Maximum value that the new account servicer will pay to the old account servicer when the closing balance on the old account is negative.
    /// </summary>
    [IsoId("_68jSJW48EeiU9cctagi5ow")]
    [DisplayName("Balance Transfer Funding Limit")]
    [IsoXmlTag("BalTrfFndgLmt")]
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; }
}
