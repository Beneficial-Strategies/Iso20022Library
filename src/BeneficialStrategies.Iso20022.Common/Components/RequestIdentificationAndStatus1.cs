// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original request details and status.
/// </summary>
[IsoId("_JRJXgFGoEfC_v5ez7RpMHw")]
[DisplayName("Request Identification And Status1")]
public record RequestIdentificationAndStatus1
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_52SAkGiTEfC7No_UZmyDXw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupInformation29 OriginalGroupInformation { get; init; }

    /// <summary>
    /// Identification of the original CashDepositRequest or CashWithdrawalRequest or CashDepositOrWithdrawalCancellationRequest.
    /// </summary>
    [IsoId("_XGeIklGoEfC_v5ez7RpMHw")]
    [DisplayName("Original Request Identification")]
    [IsoXmlTag("OrgnlReqId")]
    public required RequestIdentification1 OriginalRequestIdentification { get; init; }

    /// <summary>
    /// Provides the status of the request.
    /// </summary>
    [IsoId("_XGeIk1GoEfC_v5ez7RpMHw")]
    [DisplayName("Request Handling")]
    [IsoXmlTag("ReqHdlg")]
    public required RequestHandling4 RequestHandling { get; init; }

    /// <summary>
    /// Confirmation of how the cash receiver has validated the cash deposit.
    /// </summary>
    [IsoId("_9LkTwKtiEfC6tbn8zOl_iw")]
    [DisplayName("Cash Deposit Validation")]
    [IsoXmlTag("CshDpstVldtn")]
    public CashDepositConfirmation1? CashDepositValidation { get; init; }

    /// <summary>
    /// Confirmation of the note and cash denominations used by the cash sender for the cash withdrawal.
    /// </summary>
    [IsoId("_bVAMgKtjEfC6tbn8zOl_iw")]
    [DisplayName("Cash Withdrawal Confirmation")]
    [IsoXmlTag("CshWdrwlConf")]
    public CashWithdrawal1? CashWithdrawalConfirmation { get; init; }
}
