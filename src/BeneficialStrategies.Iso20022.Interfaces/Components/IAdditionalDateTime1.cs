// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Series of additional dates related to the payment.
/// </summary>
[IsoId("_e2UX0G9ZEe-Mlpx0N5T4gg")]
public interface IAdditionalDateTime1 : IIsoComponent
{
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    IsoISODateTime? AcceptanceDateTime { get; }

    /// <summary>
    /// Date and time on which the payment should be expired if it has not settled.
    /// </summary>
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    IsoISODateTime? ExpiryDateTime { get; }

    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    IsoISODate? PoolingAdjustmentDate { get; }
}
