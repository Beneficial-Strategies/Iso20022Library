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
    [KnownType(typeof(ModificationReason5Choice.Code))]
    [KnownType(typeof(ModificationReason5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModificationReason5Choice.Code),nameof(ModificationReason5Choice.Code))]
    [JsonDerivedType(typeof(ModificationReason5Choice.Proprietary),nameof(ModificationReason5Choice.Proprietary))]
    #endif
    [IsoId("_6QDrcZNLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Reason 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationReason5Choice_
    #else
    public abstract partial class ModificationReason5Choice_
    #endif
    {
    }
}
