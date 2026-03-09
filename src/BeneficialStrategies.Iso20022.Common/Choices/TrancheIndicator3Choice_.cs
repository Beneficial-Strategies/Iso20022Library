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
    /// Indication whether a derivative contract is tranched.
    /// </summary>
    [KnownType(typeof(TrancheIndicator3Choice.Tranched))]
    [KnownType(typeof(TrancheIndicator3Choice.Untranched))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TrancheIndicator3Choice.Tranched),nameof(TrancheIndicator3Choice.Tranched))]
    [JsonDerivedType(typeof(TrancheIndicator3Choice.Untranched),nameof(TrancheIndicator3Choice.Untranched))]
    #endif
    [IsoId("_mq05QQ06EeuJ1fOEB4bQXA")]
    [DisplayName("Tranche Indicator 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TrancheIndicator3Choice_
    #else
    public abstract partial class TrancheIndicator3Choice_
    #endif
    {
    }
}
