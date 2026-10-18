// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by a clearing system, to unambiguously identify a member of the clearing system.
/// </summary>
[IsoId("_TMehHNp-Ed-ak6NoX_4Aeg_151445359")]
public interface IClearingSystemMemberIdentification2 : IIsoComponent
{
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_TMehHdp-Ed-ak6NoX_4Aeg_-1082144614")]
    [DisplayName("Clearing System Identification")]
    [IsoXmlTag("ClrSysId")]
    IClearingSystemIdentification2Choice? ClearingSystemIdentification { get; }

    /// <summary>
    /// Identification of a member of a clearing system.
    /// </summary>
    [IsoId("_TMehHtp-Ed-ak6NoX_4Aeg_151445420")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    IsoMax35Text MemberIdentification { get; }
}
