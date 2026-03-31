// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(ConsentOrRejectionReason5Choice.Code))]
    [KnownType(typeof(ConsentOrRejectionReason5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ConsentOrRejectionReason5Choice.Code),
        nameof(ConsentOrRejectionReason5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ConsentOrRejectionReason5Choice.Proprietary),
        nameof(ConsentOrRejectionReason5Choice.Proprietary)
    )]
    [IsoId("_Vl2wTZNSEeWGlc8L7oPDIg")]
    [DisplayName("Consent Or Rejection Reason 5 Choice")]
    public abstract record ConsentOrRejectionReason5Choice_ { }
}
