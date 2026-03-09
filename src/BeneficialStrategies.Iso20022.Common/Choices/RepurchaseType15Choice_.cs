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
    [KnownType(typeof(RepurchaseType15Choice.Code))]
    [KnownType(typeof(RepurchaseType15Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepurchaseType15Choice.Code),nameof(RepurchaseType15Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType15Choice.Proprietary),nameof(RepurchaseType15Choice.Proprietary))]
    #endif
    [IsoId("_ZzmhwT0BEeWjqIDN7tjEjQ")]
    [DisplayName("Repurchase Type 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepurchaseType15Choice_
    #else
    public abstract partial class RepurchaseType15Choice_
    #endif
    {
    }
}
