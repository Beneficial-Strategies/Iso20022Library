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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus2Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedStatus2Choice.NoSpecifiedReason),nameof(UnmatchedStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus2Choice.Reason),nameof(UnmatchedStatus2Choice.Reason))]
    #endif
    [IsoId("_UWF0gdp-Ed-ak6NoX_4Aeg_-621975158")]
    [DisplayName("Unmatched Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus2Choice_
    #else
    public abstract partial class UnmatchedStatus2Choice_
    #endif
    {
    }
}
