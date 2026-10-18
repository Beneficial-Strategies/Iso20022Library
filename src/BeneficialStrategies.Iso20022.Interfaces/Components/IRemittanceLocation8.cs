// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_0IULUTEyEe6g-ffJsqGiSA")]
public interface IRemittanceLocation8 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    Max35Text? RemittanceIdentification { get; }

    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    IEnumerable<IRemittanceLocationData2> RemittanceLocationDetails { get; }
}
