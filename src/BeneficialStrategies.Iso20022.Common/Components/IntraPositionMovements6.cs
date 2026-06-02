// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the transactions in the response.
/// </summary>
[IsoId("_Tz3iweSkEe-qVZLXW4RRBw")]
[DisplayName("Intra Position Movements6")]
public record IntraPositionMovements6
{
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_Vxlzt-SkEe-qVZLXW4RRBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_VxlzueSkEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_Vxlzu-SkEe-qVZLXW4RRBw")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public IntraPositionStatusAndReason4? StatusAndReason { get; init; }

    /// <summary>
    /// Identifies the individual transaction.
    /// </summary>
    [IsoId("_VxlzveSkEe-qVZLXW4RRBw")]
    [DisplayName("Movement")]
    [IsoXmlTag("Mvmnt")]
    [MinLength(1)]
    public ValueList<IntraPositionMovement10> Movement { get; init; } = [];
}
