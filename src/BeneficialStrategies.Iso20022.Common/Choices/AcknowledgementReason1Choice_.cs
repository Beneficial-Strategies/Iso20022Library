// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason1Choice.Code))]
    [KnownType(typeof(AcknowledgementReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(AcknowledgementReason1Choice.Code),nameof(AcknowledgementReason1Choice.Code))]
    [JsonDerivedType(typeof(AcknowledgementReason1Choice.Proprietary),nameof(AcknowledgementReason1Choice.Proprietary))]
    [IsoId("_UXuzR9p-Ed-ak6NoX_4Aeg_-355998535")]
    [DisplayName("Acknowledgement Reason 1 Choice")]
    public abstract partial record AcknowledgementReason1Choice_
    {
    }
}
