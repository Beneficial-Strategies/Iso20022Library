// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus1Choice.Reason))]
    [JsonDerivedType(typeof(AcceptedStatus1Choice.NoSpecifiedReason),nameof(AcceptedStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcceptedStatus1Choice.Reason),nameof(AcceptedStatus1Choice.Reason))]
    [IsoId("_QysmRdp-Ed-ak6NoX_4Aeg_788323528")]
    [DisplayName("Accepted Status 1 Choice")]
    public abstract partial record AcceptedStatus1Choice_
    {
    }
}
