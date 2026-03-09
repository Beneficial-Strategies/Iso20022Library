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
    [KnownType(typeof(FailingStatus11Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus11Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FailingStatus11Choice.NoSpecifiedReason),nameof(FailingStatus11Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus11Choice.Reason),nameof(FailingStatus11Choice.Reason))]
    #endif
    [IsoId("_5SGOr5NLEeWGlc8L7oPDIg")]
    [DisplayName("Failing Status 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingStatus11Choice_
    #else
    public abstract partial class FailingStatus11Choice_
    #endif
    {
    }
}
