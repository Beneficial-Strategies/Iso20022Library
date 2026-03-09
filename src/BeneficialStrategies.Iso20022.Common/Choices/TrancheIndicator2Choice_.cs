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
    [KnownType(typeof(TrancheIndicator2Choice.Tranched))]
    [KnownType(typeof(TrancheIndicator2Choice.Untranched))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TrancheIndicator2Choice.Tranched),nameof(TrancheIndicator2Choice.Tranched))]
    [JsonDerivedType(typeof(TrancheIndicator2Choice.Untranched),nameof(TrancheIndicator2Choice.Untranched))]
    #endif
    [IsoId("_5tB9YbyOEeaUov4jN5X9Qw")]
    [DisplayName("Tranche Indicator 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TrancheIndicator2Choice_
    #else
    public abstract partial class TrancheIndicator2Choice_
    #endif
    {
    }
}
