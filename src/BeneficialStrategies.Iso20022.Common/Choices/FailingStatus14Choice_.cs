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
    [KnownType(typeof(FailingStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus14Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FailingStatus14Choice.NoSpecifiedReason),nameof(FailingStatus14Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus14Choice.Reason),nameof(FailingStatus14Choice.Reason))]
    #endif
    [IsoId("_f99yAzi8Eeydid5dcNPKvg")]
    [DisplayName("Failing Status 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingStatus14Choice_
    #else
    public abstract partial class FailingStatus14Choice_
    #endif
    {
    }
}
