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
    /// Choice of modification status.
    /// </summary>
    [KnownType(typeof(ModificationStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(ModificationStatus5Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationStatus5Choice.NoSpecifiedReason),nameof(ModificationStatus5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ModificationStatus5Choice.Reason),nameof(ModificationStatus5Choice.Reason))]
    #endif
    [IsoId("_6QDrU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationStatus5Choice_
    #else
    public abstract partial class ModificationStatus5Choice_
    #endif
    {
    }
}
