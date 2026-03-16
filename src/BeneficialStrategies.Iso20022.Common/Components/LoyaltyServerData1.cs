// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the loyalty server during a loyalty transaction.
/// </summary>
[IsoId("_0ZN1QNxLEeioifFt1dhnJA")]
[DisplayName("Loyalty Server Data")]
public record LoyaltyServerData1
{
    /// <summary>
    /// Identification of the loyalty Server.
    /// </summary>
    [IsoId("__zNMUNxLEeioifFt1dhnJA")]
    [DisplayName("Loyalty Server Identification")]
    [IsoXmlTag("LltySvrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LoyaltyServerIdentification { get; init; }

    /// <summary>
    /// Approval code assigned to a loyalty transaction by the Server.
    /// </summary>
    [IsoId("_JAKEENxMEeioifFt1dhnJA")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 6)]
    public IsoMin6Max8Text? ApprovalCode { get; init; }

    /// <summary>
    /// Identification of the Loyalty transaction in an unambiguous way.
    /// </summary>
    [IsoId("_sjFxENxMEeioifFt1dhnJA")]
    [DisplayName("Loyalty Transaction Identification")]
    [IsoXmlTag("LltyTxId")]
    public TransactionIdentifier1? LoyaltyTransactionIdentification { get; init; }

    /// <summary>
    /// Identifier of a reconciliation period with a payment or loyalty host.
    /// </summary>
    [IsoId("_7kPcENxMEeioifFt1dhnJA")]
    [DisplayName("Host Reconciliation Identification")]
    [IsoXmlTag("HstRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? HostReconciliationIdentification { get; init; }
}
