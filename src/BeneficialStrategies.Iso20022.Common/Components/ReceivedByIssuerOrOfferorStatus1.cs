// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction has been received and accepted by the issuer or offeror.
/// </summary>
[IsoId("_R_R3k475EfCbNJ3GwkFTcw")]
[DisplayName("Received By Issuer Or Offeror Status1")]
public record ReceivedByIssuerOrOfferorStatus1
{
    /// <summary>
    /// Quantity of instructed securities previously accepted has now been accepted by the Issuer.
    /// </summary>
    [IsoId("_R_R3lI75EfCbNJ3GwkFTcw")]
    [DisplayName("Accepted By Issuer Quantity")]
    [IsoXmlTag("AccptdByIssrQty")]
    public Quantity51Choice_? AcceptedByIssuerQuantity { get; init; }

    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_R_R3lY75EfCbNJ3GwkFTcw")]
    [DisplayName("Received By Issuer Or Offeror Reason")]
    [IsoXmlTag("RcvdByIssrOrOfferrRsn")]
    public required NoSpecifiedReason1 ReceivedByIssuerOrOfferorReason { get; init; }
}
