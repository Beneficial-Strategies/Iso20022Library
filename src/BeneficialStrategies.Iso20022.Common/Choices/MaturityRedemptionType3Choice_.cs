// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for maturity redemption type.
    /// </summary>
    [KnownType(typeof(MaturityRedemptionType3Choice.Code))]
    [KnownType(typeof(MaturityRedemptionType3Choice.Proprietary))]
    [JsonDerivedType(typeof(MaturityRedemptionType3Choice.Code),nameof(MaturityRedemptionType3Choice.Code))]
    [JsonDerivedType(typeof(MaturityRedemptionType3Choice.Proprietary),nameof(MaturityRedemptionType3Choice.Proprietary))]
    [IsoId("_d8mHheLxEeWOD7aAy2fAcA")]
    [DisplayName("Maturity Redemption Type 3 Choice")]
    public abstract partial record MaturityRedemptionType3Choice_
    {
    }
}
