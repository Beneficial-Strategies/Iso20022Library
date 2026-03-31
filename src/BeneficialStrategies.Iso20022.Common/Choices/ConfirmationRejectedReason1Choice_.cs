// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a rejection reason for a confirmation.
    /// </summary>
    [KnownType(typeof(ConfirmationRejectedReason1Choice.Code))]
    [KnownType(typeof(ConfirmationRejectedReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ConfirmationRejectedReason1Choice.Code),
        nameof(ConfirmationRejectedReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ConfirmationRejectedReason1Choice.Proprietary),
        nameof(ConfirmationRejectedReason1Choice.Proprietary)
    )]
    [IsoId("_-qFdQXZxEeaN2c674jyTxQ")]
    [DisplayName("Confirmation Rejected Reason 1 Choice")]
    public abstract record ConfirmationRejectedReason1Choice_ { }
}
