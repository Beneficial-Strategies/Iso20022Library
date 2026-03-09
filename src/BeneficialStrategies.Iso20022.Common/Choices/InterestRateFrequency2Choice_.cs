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
    [KnownType(typeof(InterestRateFrequency2Choice.Term))]
    [KnownType(typeof(InterestRateFrequency2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRateFrequency2Choice.Term),nameof(InterestRateFrequency2Choice.Term))]
    [JsonDerivedType(typeof(InterestRateFrequency2Choice.Proprietary),nameof(InterestRateFrequency2Choice.Proprietary))]
    #endif
    [IsoId("_mBwkwfOFEeaS7fYULSI4_Q")]
    [DisplayName("Interest Rate Frequency 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateFrequency2Choice_
    #else
    public abstract partial class InterestRateFrequency2Choice_
    #endif
    {
    }
}
