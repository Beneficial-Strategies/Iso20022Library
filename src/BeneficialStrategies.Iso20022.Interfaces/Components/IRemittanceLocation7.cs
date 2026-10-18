// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_-BcUm24-EeiU9cctagi5ow")]
public interface IRemittanceLocation7 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [IsoId("_-LRmA24-EeiU9cctagi5ow")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    IsoMax35Text? RemittanceIdentification { get; }

    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [IsoId("_-LRmBW4-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    IEnumerable<IRemittanceLocationData1> RemittanceLocationDetails { get; }
}
