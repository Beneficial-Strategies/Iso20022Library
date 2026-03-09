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
    /// Choice of format for the cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationReason11Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationReason11Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason11Choice.NoSpecifiedReason),nameof(CancellationReason11Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationReason11Choice.Reason),nameof(CancellationReason11Choice.Reason))]
    #endif
    [IsoId("_A0Fk0NokEeC60axPepSq7g_1353519465")]
    [DisplayName("Cancellation Reason 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason11Choice_
    #else
    public abstract partial class CancellationReason11Choice_
    #endif
    {
    }
}
