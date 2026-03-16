// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Movements of cash.
/// </summary>
[IsoId("_qliBoRIwEeydmIVkS03esw")]
[DisplayName("Cash Movement")]
public record CashMovement7
{
    /// <summary>
    /// Specifies whether the cash amount is to be delivered or received.
    /// </summary>
    [IsoId("_q7lKIRIwEeydmIVkS03esw")]
    [DisplayName("Cash Movement")]
    [IsoXmlTag("CshMvmnt")]
    public required CreditDebit3Code CashMovement { get; init; }

    /// <summary>
    /// Amount of the cash movement.
    /// </summary>
    [IsoId("_q7lKIxIwEeydmIVkS03esw")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public required ActiveCurrencyAndAmount CashAmount { get; init; }

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_q7lKJRIwEeydmIVkS03esw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Cash movement status
    /// </summary>
    [IsoId("_q7lKJxIwEeydmIVkS03esw")]
    [DisplayName("Movement Status")]
    [IsoXmlTag("MvmntSts")]
    public ProprietaryStatusAndReason6? MovementStatus { get; init; }

    /// <summary>
    /// Specifies whether the amount is delivered/received as part of collateral or not.
    /// </summary>
    [IsoId("_q7lKKRIwEeydmIVkS03esw")]
    [DisplayName("Collateral Movement")]
    [IsoXmlTag("CollMvmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CollateralMovement { get; init; }

    /// <summary>
    /// Indicates whether the proposed cash movements can be accepted.
    /// </summary>
    [IsoId("_q7lKKxIwEeydmIVkS03esw")]
    [DisplayName("Cash Movement Approved")]
    [IsoXmlTag("CshMvmntApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CashMovementApproved { get; init; }

    /// <summary>
    /// Indicates whether the position is fixed (post settlement).
    /// </summary>
    [IsoId("_q7lKLRIwEeydmIVkS03esw")]
    [DisplayName("Position Type")]
    [IsoXmlTag("PosTp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PositionType { get; init; }

    /// <summary>
    /// Reference assigned by party A to the cash movement.
    /// </summary>
    [IsoId("_q7lKLxIwEeydmIVkS03esw")]
    [DisplayName("Client Cash Movement Identification")]
    [IsoXmlTag("ClntCshMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientCashMovementIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the triparty-agent/service-provider to the cash movement.
    /// </summary>
    [IsoId("_q7lKMRIwEeydmIVkS03esw")]
    [DisplayName("Triparty Agent Service Provider Cash Movement Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCshMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderCashMovementIdentification { get; init; }
}
