// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Describes frequency of payments for interest rates, either using term notation or a proprietary notation.
    /// </summary>
    [KnownType(typeof(InterestRateFrequency2Choice.Term))]
    [KnownType(typeof(InterestRateFrequency2Choice.Proprietary))]
    [JsonDerivedType(typeof(InterestRateFrequency2Choice.Term),nameof(InterestRateFrequency2Choice.Term))]
    [JsonDerivedType(typeof(InterestRateFrequency2Choice.Proprietary),nameof(InterestRateFrequency2Choice.Proprietary))]
    [IsoId("_mBwkwfOFEeaS7fYULSI4_Q")]
    [DisplayName("Interest Rate Frequency 2 Choice")]
    public abstract partial record InterestRateFrequency2Choice_
    {
    }
}
