// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the status reason of the transaction.
/// </summary>
[IsoId("_TOkLwNp-Ed-ak6NoX_4Aeg_1982653400")]
public interface IStatusReasonInformation9 : IIsoComponent
{
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_TOkLwdp-Ed-ak6NoX_4Aeg_682524532")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification43? Originator { get; }

    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_TOkLwtp-Ed-ak6NoX_4Aeg_2040335488")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IStatusReason6Choice? Reason { get; }

    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_TOkLw9p-Ed-ak6NoX_4Aeg_181746353")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
