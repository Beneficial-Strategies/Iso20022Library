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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus3Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingProcessingStatus3Choice.NoSpecifiedReason),nameof(PendingProcessingStatus3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus3Choice.Reason),nameof(PendingProcessingStatus3Choice.Reason))]
    #endif
    [IsoId("_0_sCgf7qEeCvPoRGOxRobQ")]
    [DisplayName("Pending Processing Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessingStatus3Choice_
    #else
    public abstract partial class PendingProcessingStatus3Choice_
    #endif
    {
    }
}
