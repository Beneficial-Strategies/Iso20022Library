// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about a corporate action election.
/// </summary>
[IsoId("_UJ39d9p-Ed-ak6NoX_4Aeg_-1634086378")]
[DisplayName("Corporate Action Election")]
public record CorporateActionElection3
{
    /// <summary>
    /// Provides information about the account.
    /// </summary>
    [IsoId("_UJ39eNp-Ed-ak6NoX_4Aeg_-1717682218")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public SecuritiesAccount7? AccountDetails { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UKBHYNp-Ed-ak6NoX_4Aeg_-1215732423")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CorporateActionOption1FormatChoice_? OptionType { get; init; }

    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UKBHYdp-Ed-ak6NoX_4Aeg_-1591604434")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Quantity of underlying securities to which this instruction applies.
    /// </summary>
    [IsoId("_UKBHYtp-Ed-ak6NoX_4Aeg_-758588422")]
    [DisplayName("Instructed Underlying Securities Quantity")]
    [IsoXmlTag("InstdUndrlygSctiesQty")]
    public UnitOrFaceAmount1Choice_? InstructedUnderlyingSecuritiesQuantity { get; init; }

    /// <summary>
    /// Quantity of the benefits that the account owner wants to receive, eg, as a result of dividend reinvestment.
    /// </summary>
    [IsoId("_UKBHY9p-Ed-ak6NoX_4Aeg_1915148636")]
    [DisplayName("Instructed Securities Quantity To Receive")]
    [IsoXmlTag("InstdSctiesQtyToRcv")]
    public UnitOrFaceAmount1Choice_? InstructedSecuritiesQuantityToReceive { get; init; }

    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_UKBHZNp-Ed-ak6NoX_4Aeg_101209579")]
    [DisplayName("Proposed Rate")]
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProposedRate { get; init; }

    /// <summary>
    /// Provides information about the cash movement resulting from the election instruction.
    /// </summary>
    [IsoId("_UKBHZdp-Ed-ak6NoX_4Aeg_-1328972579")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public CorporateActionCashMovements2? CashMovementDetails { get; init; }

    /// <summary>
    /// Provides information about the securities movement resulting from the election instruction.
    /// </summary>
    [IsoId("_UKBHZtp-Ed-ak6NoX_4Aeg_-1078102161")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public CorporateActionSecuritiesMovement2? SecuritiesMovementDetails { get; init; }
}
