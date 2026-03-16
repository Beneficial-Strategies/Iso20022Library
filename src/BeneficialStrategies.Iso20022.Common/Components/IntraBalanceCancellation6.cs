// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the cancellation requests.
/// </summary>
[IsoId("_qIqm7znfEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Cancellation")]
public record IntraBalanceCancellation6
{
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_qSppUznfEem7JZMuWtwtsg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccount38? CashAccount { get; init; }

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_qSppUTnfEem7JZMuWtwtsg")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_MpzYETqCEemJ3KLLPeYl6g")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }

    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_qSppVTnfEem7JZMuWtwtsg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus69Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Unambiguous identification of the cancellation request.
    /// </summary>
    [IsoId("_qSppXTnfEem7JZMuWtwtsg")]
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RequestReference { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_qSppXznfEem7JZMuWtwtsg")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDate { get; init; }

    /// <summary>
    /// References of the transaction for which the intra-balance modification is requested.
    /// </summary>
    [IsoId("_qSppZznfEem7JZMuWtwtsg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public References14? TransactionIdentification { get; init; }

    /// <summary>
    /// Identifies additional details of the transaction.
    /// </summary>
    [IsoId("_qSppbznfEem7JZMuWtwtsg")]
    [DisplayName("Underlying Intra Balance")]
    [IsoXmlTag("UndrlygIntraBal")]
    public IntraBalance5? UnderlyingIntraBalance { get; init; }
}
