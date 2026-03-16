// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status of the confirmation.
    /// </summary>
    [KnownType(typeof(ConfirmationStatus1Choice.ConfirmationRejected))]
    [KnownType(typeof(ConfirmationStatus1Choice.AmendmentRejected))]
    [KnownType(typeof(ConfirmationStatus1Choice.Status))]
    [JsonDerivedType(
        typeof(ConfirmationStatus1Choice.ConfirmationRejected),
        nameof(ConfirmationStatus1Choice.ConfirmationRejected)
    )]
    [JsonDerivedType(
        typeof(ConfirmationStatus1Choice.AmendmentRejected),
        nameof(ConfirmationStatus1Choice.AmendmentRejected)
    )]
    [JsonDerivedType(
        typeof(ConfirmationStatus1Choice.Status),
        nameof(ConfirmationStatus1Choice.Status)
    )]
    [IsoId("_wK4rIEhCEea8pJjypp-yMQ")]
    [DisplayName("Confirmation Status 1 Choice")]
    public abstract record ConfirmationStatus1Choice_ { }
}
