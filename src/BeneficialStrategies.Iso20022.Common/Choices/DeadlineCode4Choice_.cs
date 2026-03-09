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
    /// Choice between a code or a proprietary code for a deadline code.
    /// </summary>
    [KnownType(typeof(DeadlineCode4Choice.Code))]
    [KnownType(typeof(DeadlineCode4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeadlineCode4Choice.Code),nameof(DeadlineCode4Choice.Code))]
    [JsonDerivedType(typeof(DeadlineCode4Choice.Proprietary),nameof(DeadlineCode4Choice.Proprietary))]
    #endif
    [IsoId("_cfssk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Deadline Code 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeadlineCode4Choice_
    #else
    public abstract partial class DeadlineCode4Choice_
    #endif
    {
    }
}
