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
    [KnownType(typeof(RepurchaseType8Choice.Code))]
    [KnownType(typeof(RepurchaseType8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepurchaseType8Choice.Code),nameof(RepurchaseType8Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType8Choice.Proprietary),nameof(RepurchaseType8Choice.Proprietary))]
    #endif
    [IsoId("_GS4Cgd0dEd-Cb-IGbQ4hBQ")]
    [DisplayName("Repurchase Type 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepurchaseType8Choice_
    #else
    public abstract partial class RepurchaseType8Choice_
    #endif
    {
    }
}
