// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode9Choice.Code))]
    [KnownType(typeof(PurposeCode9Choice.Proprietary))]
    [JsonDerivedType(typeof(PurposeCode9Choice.Code),nameof(PurposeCode9Choice.Code))]
    [JsonDerivedType(typeof(PurposeCode9Choice.Proprietary),nameof(PurposeCode9Choice.Proprietary))]
    [IsoId("_Vm9X75CAEeakHoV5BVecAQ")]
    [DisplayName("Purpose Code 9 Choice")]
    public abstract partial record PurposeCode9Choice_
    {
    }
}
