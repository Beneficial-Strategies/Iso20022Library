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
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus57Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus57Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus57Choice.NoSpecifiedReason),nameof(PendingStatus57Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus57Choice.Reason),nameof(PendingStatus57Choice.Reason))]
    #endif
    [IsoId("_jx4dweXzEemEj48jhmlA0Q")]
    [DisplayName("Pending Status 57 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus57Choice_
    #else
    public abstract partial class PendingStatus57Choice_
    #endif
    {
    }
}
