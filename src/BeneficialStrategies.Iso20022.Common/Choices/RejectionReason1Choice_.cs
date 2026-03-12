// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Allows the sender of the rejection message to indicate only one rejection reason that applies to the entire rejected message.
    /// </summary>
    [KnownType(typeof(RejectionReason1Choice.GlobalRejectionReason))]
    [KnownType(typeof(RejectionReason1Choice.RejectedElement))]
    [JsonDerivedType(typeof(RejectionReason1Choice.GlobalRejectionReason),nameof(RejectionReason1Choice.GlobalRejectionReason))]
    [JsonDerivedType(typeof(RejectionReason1Choice.RejectedElement),nameof(RejectionReason1Choice.RejectedElement))]
    [IsoId("_RJ8ooNp-Ed-ak6NoX_4Aeg_891683676")]
    [DisplayName("Rejection Reason 1 Choice")]
    public abstract partial record RejectionReason1Choice_
    {
    }
}
