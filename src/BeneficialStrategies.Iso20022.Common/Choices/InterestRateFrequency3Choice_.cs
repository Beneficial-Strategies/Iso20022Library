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
    /// Describes frequency of payments for interest rates, either using term notation or a proprietary notation.
    /// </summary>
    [KnownType(typeof(InterestRateFrequency3Choice.Term))]
    [KnownType(typeof(InterestRateFrequency3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRateFrequency3Choice.Term),nameof(InterestRateFrequency3Choice.Term))]
    [JsonDerivedType(typeof(InterestRateFrequency3Choice.Proprietary),nameof(InterestRateFrequency3Choice.Proprietary))]
    #endif
    [IsoId("_61uTH1fREeqqKf65rDYWYw")]
    [DisplayName("Interest Rate Frequency 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateFrequency3Choice_
    #else
    public abstract partial class InterestRateFrequency3Choice_
    #endif
    {
    }
}
