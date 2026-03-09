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
    /// Choice of format for the modification cancellation information.
    /// </summary>
    [KnownType(typeof(ModificationCancellationAllowed5Choice.Indicator))]
    [KnownType(typeof(ModificationCancellationAllowed5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationCancellationAllowed5Choice.Indicator),nameof(ModificationCancellationAllowed5Choice.Indicator))]
    [JsonDerivedType(typeof(ModificationCancellationAllowed5Choice.Proprietary),nameof(ModificationCancellationAllowed5Choice.Proprietary))]
    #endif
    [IsoId("_6dr4i5NLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Cancellation Allowed 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationCancellationAllowed5Choice_
    #else
    public abstract partial class ModificationCancellationAllowed5Choice_
    #endif
    {
    }
}
