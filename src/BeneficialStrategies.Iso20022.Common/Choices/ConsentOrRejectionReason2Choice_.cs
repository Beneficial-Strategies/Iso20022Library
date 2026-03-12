// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(ConsentOrRejectionReason2Choice.Code))]
    [KnownType(typeof(ConsentOrRejectionReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(ConsentOrRejectionReason2Choice.Code),nameof(ConsentOrRejectionReason2Choice.Code))]
    [JsonDerivedType(typeof(ConsentOrRejectionReason2Choice.Proprietary),nameof(ConsentOrRejectionReason2Choice.Proprietary))]
    [IsoId("_0fpplAlIEeGATtfOBToyew_1694942243")]
    [DisplayName("Consent Or Rejection Reason 2 Choice")]
    public abstract partial record ConsentOrRejectionReason2Choice_
    {
    }
}
