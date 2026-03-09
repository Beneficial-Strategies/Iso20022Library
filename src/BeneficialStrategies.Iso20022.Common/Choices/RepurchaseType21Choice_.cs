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
    [KnownType(typeof(RepurchaseType21Choice.Code))]
    [KnownType(typeof(RepurchaseType21Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepurchaseType21Choice.Code),nameof(RepurchaseType21Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType21Choice.Proprietary),nameof(RepurchaseType21Choice.Proprietary))]
    #endif
    [IsoId("_RLA_kY-REeaVK-2bgpxeYw")]
    [DisplayName("Repurchase Type 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepurchaseType21Choice_
    #else
    public abstract partial class RepurchaseType21Choice_
    #endif
    {
    }
}
