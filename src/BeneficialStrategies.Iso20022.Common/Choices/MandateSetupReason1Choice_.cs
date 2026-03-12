// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the setup of the mandate.
    /// </summary>
    [KnownType(typeof(MandateSetupReason1Choice.Code))]
    [KnownType(typeof(MandateSetupReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(MandateSetupReason1Choice.Code),nameof(MandateSetupReason1Choice.Code))]
    [JsonDerivedType(typeof(MandateSetupReason1Choice.Proprietary),nameof(MandateSetupReason1Choice.Proprietary))]
    [IsoId("_iQq8ND2OEeS6DKIV6SF6gw")]
    [DisplayName("Mandate Setup Reason 1 Choice")]
    public abstract partial record MandateSetupReason1Choice_
    {
    }
}
