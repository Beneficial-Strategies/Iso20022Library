// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the reversal of the transaction.
/// </summary>
[IsoId("_TRGiYtp-Ed-ak6NoX_4Aeg_-494855858")]
public interface IReversalReasonInformation6 : IIsoComponent
{
    /// <summary>
    /// Party that issues the reversal.
    /// </summary>
    [IsoId("_TRGiY9p-Ed-ak6NoX_4Aeg_1648049638")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification32? Originator { get; }

    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_TRGiZNp-Ed-ak6NoX_4Aeg_-494855505")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IReversalReason4Choice? Reason { get; }

    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_TRGiZdp-Ed-ak6NoX_4Aeg_-494855849")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
