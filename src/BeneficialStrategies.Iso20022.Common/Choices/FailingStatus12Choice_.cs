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
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus12Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FailingStatus12Choice.NoSpecifiedReason),nameof(FailingStatus12Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus12Choice.Reason),nameof(FailingStatus12Choice.Reason))]
    #endif
    [IsoId("_6BKT-ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Failing Status 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingStatus12Choice_
    #else
    public abstract partial class FailingStatus12Choice_
    #endif
    {
    }
}
