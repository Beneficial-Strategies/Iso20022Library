// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Conditionally accepted status reason.
    /// </summary>
    [KnownType(typeof(ConditionallyAcceptedStatusReason1Choice.Reason))]
    [KnownType(typeof(ConditionallyAcceptedStatusReason1Choice.Proprietary))]
    [KnownType(typeof(ConditionallyAcceptedStatusReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason1Choice.Reason),nameof(ConditionallyAcceptedStatusReason1Choice.Reason))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason1Choice.Proprietary),nameof(ConditionallyAcceptedStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason1Choice.NoSpecifiedReason),nameof(ConditionallyAcceptedStatusReason1Choice.NoSpecifiedReason))]
    [IsoId("_RgmOENp-Ed-ak6NoX_4Aeg_-317806410")]
    [DisplayName("Conditionally Accepted Status Reason 1 Choice")]
    public abstract partial record ConditionallyAcceptedStatusReason1Choice_
    {
    }
}
