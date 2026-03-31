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
[IsoId("_rn_kOxIwEeydmIVkS03esw")]
[DisplayName("Cash Movement")]
public record CashMovement8
{
    /// <summary>
    /// Specifies whether the cash amount is to be delivered or received.
    /// </summary>
    [IsoId("_r-pJoRIwEeydmIVkS03esw")]
    [DisplayName("Cash Movement")]
    [IsoXmlTag("CshMvmnt")]
    public required CollateralEntryType1Code CashMovement { get; init; }

    /// <summary>
    /// Amount of the cash movement
    /// </summary>
    [IsoId("_r-pJoxIwEeydmIVkS03esw")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public required ActiveCurrencyAndAmount CashAmount { get; init; }

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_r-pJpRIwEeydmIVkS03esw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Specifies whether the amount is delivered/received as part of collateral or not.
    /// </summary>
    [IsoId("_r-pJpxIwEeydmIVkS03esw")]
    [DisplayName("Collateral Movement")]
    [IsoXmlTag("CollMvmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CollateralMovement { get; init; }

    /// <summary>
    /// Reference assigned by party A to the cash movement.
    /// </summary>
    [IsoId("_r-pJqRIwEeydmIVkS03esw")]
    [DisplayName("Client Cash Movement Identification")]
    [IsoXmlTag("ClntCshMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientCashMovementIdentification { get; init; }

    /// <summary>
    /// Reference assigned by the triparty agent to the cash movement.
    /// </summary>
    [IsoId("_r-pJqxIwEeydmIVkS03esw")]
    [DisplayName("Triparty Agent Service Provider Cash Movement Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCshMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderCashMovementIdentification { get; init; }
}
