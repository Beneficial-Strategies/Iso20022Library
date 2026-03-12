// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the complete status.
    /// </summary>
    [KnownType(typeof(TransferCancellationCompleteStatusChoice.Reason))]
    [KnownType(typeof(TransferCancellationCompleteStatusChoice.DataSourceScheme))]
    [JsonDerivedType(typeof(TransferCancellationCompleteStatusChoice.Reason),nameof(TransferCancellationCompleteStatusChoice.Reason))]
    [JsonDerivedType(typeof(TransferCancellationCompleteStatusChoice.DataSourceScheme),nameof(TransferCancellationCompleteStatusChoice.DataSourceScheme))]
    [IsoId("_U0C70dp-Ed-ak6NoX_4Aeg_-1711844694")]
    [DisplayName("Transfer Cancellation Complete Status Choice")]
    public abstract partial record TransferCancellationCompleteStatusChoice_
    {
    }
}
