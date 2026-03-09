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
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason9Choice.Code))]
    [KnownType(typeof(RejectionReason9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason9Choice.Code),nameof(RejectionReason9Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason9Choice.Proprietary),nameof(RejectionReason9Choice.Proprietary))]
    #endif
    [IsoId("_A5wH8NokEeC60axPepSq7g_1984574511")]
    [DisplayName("Rejection Reason 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason9Choice_
    #else
    public abstract partial class RejectionReason9Choice_
    #endif
    {
    }
}
