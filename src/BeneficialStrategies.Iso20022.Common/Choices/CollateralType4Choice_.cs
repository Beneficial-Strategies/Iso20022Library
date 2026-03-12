// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the collateral type.
    /// </summary>
    [KnownType(typeof(CollateralType4Choice.Code))]
    [KnownType(typeof(CollateralType4Choice.Proprietary))]
    [JsonDerivedType(typeof(CollateralType4Choice.Code),nameof(CollateralType4Choice.Code))]
    [JsonDerivedType(typeof(CollateralType4Choice.Proprietary),nameof(CollateralType4Choice.Proprietary))]
    [IsoId("_DjSkgZEkEeakHoV5BVecAQ")]
    [DisplayName("Collateral Type 4 Choice")]
    public abstract partial record CollateralType4Choice_
    {
    }
}
