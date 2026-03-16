// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Returned Status1Choice.
    /// </summary>
    [KnownType(typeof(ReturnedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(ReturnedStatus1Choice.Reason))]
    [JsonDerivedType(typeof(ReturnedStatus1Choice.NoSpecifiedReason),nameof(ReturnedStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ReturnedStatus1Choice.Reason),nameof(ReturnedStatus1Choice.Reason))]
    [IsoId("_ohK2U4S_Ee-1WeOqsw_6eA")]
    [DisplayName("Returned Status1Choice")]
    public abstract partial record ReturnedStatus1Choice_
    {
    }
}
