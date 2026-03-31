// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the status of a debtor activation.
    /// </summary>
    [KnownType(typeof(DebtorActivationStatusReason1Choice.Code))]
    [KnownType(typeof(DebtorActivationStatusReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DebtorActivationStatusReason1Choice.Code),
        nameof(DebtorActivationStatusReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DebtorActivationStatusReason1Choice.Proprietary),
        nameof(DebtorActivationStatusReason1Choice.Proprietary)
    )]
    [IsoId("_yBQtU-IJEeqbls7Gk4-ckA")]
    [DisplayName("Debtor Activation Status Reason 1 Choice")]
    public abstract record DebtorActivationStatusReason1Choice_ { }
}
