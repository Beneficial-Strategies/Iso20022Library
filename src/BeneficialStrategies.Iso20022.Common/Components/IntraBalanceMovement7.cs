// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Balance Movement7.
/// </summary>
[IsoId("_3vAlMTEyEe6g-ffJsqGiSA")]
[DisplayName("Intra Balance Movement7")]
public partial record IntraBalanceMovement7
{
    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccount40? CashAccount { get; init; }

    /// <summary>
    /// Cash Account Owner.
    /// </summary>
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Cash Account Servicer.
    /// </summary>
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? CashAccountServicer { get; init; }

    /// <summary>
    /// Status And Reason.
    /// </summary>
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public IntraBalanceStatusAndReason2? StatusAndReason { get; init; }

    /// <summary>
    /// Account Owner Transaction Identification.
    /// </summary>
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required Max35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Account Servicer Transaction Identification.
    /// </summary>
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public Max35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Market Infrastructure Transaction Identification.
    /// </summary>
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public Max35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Processor Transaction Identification.
    /// </summary>
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public Max35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Pool Identification.
    /// </summary>
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public Max35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public Max35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Movement Details.
    /// </summary>
    [DisplayName("Movement Details")]
    [IsoXmlTag("MvmntDtls")]
    public IntraBalanceMovement6? MovementDetails { get; init; }
}
