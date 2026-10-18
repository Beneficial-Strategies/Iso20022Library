// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the remittance advice.
/// </summary>
[IsoId("_jmoAoSFBEeSko9Nh5NKf8Q")]
public interface IRemittanceLocation4 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [IsoId("_qah9YyFBEeSko9Nh5NKf8Q")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    IsoMax35Text? RemittanceIdentification { get; }

    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [IsoId("_qah9ZCFBEeSko9Nh5NKf8Q")]
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    IEnumerable<IRemittanceLocationDetails1> RemittanceLocationDetails { get; }
}
