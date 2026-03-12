// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the transaction is pending initiation or has been initiated.
    /// </summary>
    [KnownType(typeof(CollateralStatus2Choice.Code))]
    [KnownType(typeof(CollateralStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(CollateralStatus2Choice.Code),nameof(CollateralStatus2Choice.Code))]
    [JsonDerivedType(typeof(CollateralStatus2Choice.Proprietary),nameof(CollateralStatus2Choice.Proprietary))]
    [IsoId("_5S5l0MX2EeiSF9q-coWegA")]
    [DisplayName("Collateral Status 2 Choice")]
    public abstract partial record CollateralStatus2Choice_
    {
    }
}
