// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberIdentification3Choice
{
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_iR9BhXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Clearing System Member Identification")]
    public record ClearingSystemMemberIdentification : MemberIdentification3Choice_
    {
        /// <summary>
        /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
        /// </summary>
        [IsoId("_TMehHdp-Ed-ak6NoX_4Aeg_-1082144614")]
        [DisplayName("Clearing System Identification")]
        [IsoXmlTag("ClrSysId")]
        public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; }

        /// <summary>
        /// Identification of a member of a clearing system.
        /// </summary>
        [IsoId("_TMehHtp-Ed-ak6NoX_4Aeg_151445420")]
        [DisplayName("Member Identification")]
        [IsoXmlTag("MmbId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MemberIdentification { get; init; }
    }
}
