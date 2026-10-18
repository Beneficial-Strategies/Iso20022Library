// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the amendment of the mandate.
/// </summary>
[IsoId("_t4JrAVkyEeGeoaLUQk__nA_-1184878668")]
public interface IMandateAmendmentReason1 : IIsoComponent
{
    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    [IsoId("_t4JrAlkyEeGeoaLUQk__nA_-177799544")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification43? Originator { get; }

    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    [IsoId("_t4JrA1kyEeGeoaLUQk__nA_-1894437970")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateReason1Choice Reason { get; }

    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    [IsoId("_t4JrBFkyEeGeoaLUQk__nA_-2110542685")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
