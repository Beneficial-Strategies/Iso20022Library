// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason2Choice.Code))]
    [KnownType(typeof(RejectionReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason2Choice.Code), nameof(RejectionReason2Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason2Choice.Proprietary),
        nameof(RejectionReason2Choice.Proprietary)
    )]
    [IsoId("_UWigdNp-Ed-ak6NoX_4Aeg_-439842888")]
    [DisplayName("Rejection Reason 2 Choice")]
    public abstract record RejectionReason2Choice_ { }
}
