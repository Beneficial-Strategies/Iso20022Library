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
    [KnownType(typeof(ModificationStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(ModificationStatus2Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationStatus2Choice.NoSpecifiedReason),nameof(ModificationStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ModificationStatus2Choice.Reason),nameof(ModificationStatus2Choice.Reason))]
    #endif
    [IsoId("_0kkl0QlIEeGATtfOBToyew_-1998753292")]
    [DisplayName("Modification Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationStatus2Choice_
    #else
    public abstract partial class ModificationStatus2Choice_
    #endif
    {
    }
}
