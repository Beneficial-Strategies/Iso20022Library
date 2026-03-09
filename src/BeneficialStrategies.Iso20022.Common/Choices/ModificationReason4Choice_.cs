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
    /// Choice of format for the Modification reason.
    /// </summary>
    [KnownType(typeof(ModificationReason4Choice.Code))]
    [KnownType(typeof(ModificationReason4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationReason4Choice.Code),nameof(ModificationReason4Choice.Code))]
    [JsonDerivedType(typeof(ModificationReason4Choice.Proprietary),nameof(ModificationReason4Choice.Proprietary))]
    #endif
    [IsoId("_DdDr2zq3EeWyoP0PbocV1Q")]
    [DisplayName("Modification Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationReason4Choice_
    #else
    public abstract partial class ModificationReason4Choice_
    #endif
    {
    }
}
