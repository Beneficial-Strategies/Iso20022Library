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
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType13Choice.Code))]
    [KnownType(typeof(RepurchaseType13Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepurchaseType13Choice.Code),nameof(RepurchaseType13Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType13Choice.Proprietary),nameof(RepurchaseType13Choice.Proprietary))]
    #endif
    [IsoId("_mUqXITqnEeWyoP0PbocV1Q")]
    [DisplayName("Repurchase Type 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepurchaseType13Choice_
    #else
    public abstract partial class RepurchaseType13Choice_
    #endif
    {
    }
}
