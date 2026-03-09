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
    /// Priority is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(PriorityCode2Choice.Code))]
    [KnownType(typeof(PriorityCode2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriorityCode2Choice.Code),nameof(PriorityCode2Choice.Code))]
    [JsonDerivedType(typeof(PriorityCode2Choice.Proprietary),nameof(PriorityCode2Choice.Proprietary))]
    #endif
    [IsoId("_74UMsqMgEeCJ6YNENx4h-w_784788398")]
    [DisplayName("Priority Code 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriorityCode2Choice_
    #else
    public abstract partial class PriorityCode2Choice_
    #endif
    {
    }
}
