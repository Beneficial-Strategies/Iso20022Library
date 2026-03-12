// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the charge tax basis.
    /// </summary>
    [KnownType(typeof(ChargeTaxBasisType2Choice.Code))]
    [KnownType(typeof(ChargeTaxBasisType2Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeTaxBasisType2Choice.Code),nameof(ChargeTaxBasisType2Choice.Code))]
    [JsonDerivedType(typeof(ChargeTaxBasisType2Choice.Proprietary),nameof(ChargeTaxBasisType2Choice.Proprietary))]
    [IsoId("_VKcMAZBhEeakHoV5BVecAQ")]
    [DisplayName("Charge Tax Basis Type 2 Choice")]
    public abstract partial record ChargeTaxBasisType2Choice_
    {
    }
}
