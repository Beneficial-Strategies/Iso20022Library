// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the complete status.
    /// </summary>
    [KnownType(typeof(TransferCancellationCompleteStatusChoice.Reason))]
    [KnownType(typeof(TransferCancellationCompleteStatusChoice.DataSourceScheme))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransferCancellationCompleteStatusChoice.Reason),nameof(TransferCancellationCompleteStatusChoice.Reason))]
    [JsonDerivedType(typeof(TransferCancellationCompleteStatusChoice.DataSourceScheme),nameof(TransferCancellationCompleteStatusChoice.DataSourceScheme))]
    #endif
    [IsoId("_U0C70dp-Ed-ak6NoX_4Aeg_-1711844694")]
    [DisplayName("Transfer Cancellation Complete Status Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferCancellationCompleteStatusChoice_
    #else
    public abstract partial class TransferCancellationCompleteStatusChoice_
    #endif
    {
    }
}
