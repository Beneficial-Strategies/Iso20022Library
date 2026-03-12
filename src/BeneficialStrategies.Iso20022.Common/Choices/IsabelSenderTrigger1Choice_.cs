// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the trigger used by the sender to generate the file.
    /// </summary>
    [KnownType(typeof(IsabelSenderTrigger1Choice.Code))]
    [KnownType(typeof(IsabelSenderTrigger1Choice.Proprietary))]
    [JsonDerivedType(typeof(IsabelSenderTrigger1Choice.Code),nameof(IsabelSenderTrigger1Choice.Code))]
    [JsonDerivedType(typeof(IsabelSenderTrigger1Choice.Proprietary),nameof(IsabelSenderTrigger1Choice.Proprietary))]
    [IsoId("_Xmro0MmLEeWAGphE2LvqeA")]
    [DisplayName("Isabel Sender Trigger 1 Choice")]
    public abstract partial record IsabelSenderTrigger1Choice_
    {
    }
}
