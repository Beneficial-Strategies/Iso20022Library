// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the processing status of the notification advice.
    /// </summary>
    [KnownType(typeof(ProcessedStatus1FormatChoice.Code))]
    [KnownType(typeof(ProcessedStatus1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(ProcessedStatus1FormatChoice.Code),nameof(ProcessedStatus1FormatChoice.Code))]
    [JsonDerivedType(typeof(ProcessedStatus1FormatChoice.Proprietary),nameof(ProcessedStatus1FormatChoice.Proprietary))]
    [IsoId("_RnJiA9p-Ed-ak6NoX_4Aeg_-1353341900")]
    [DisplayName("Processed Status 1 Format Choice")]
    public abstract partial record ProcessedStatus1FormatChoice_
    {
    }
}
